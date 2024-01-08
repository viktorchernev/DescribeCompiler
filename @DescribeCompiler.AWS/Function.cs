using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Newtonsoft.Json;
using System.Net;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace DescribeCompiler.AWS;

public class Function
{
    //https://www.youtube.com/watch?v=IHIJFVUQyFY - AWS LAMBDA For The .NET Developer
    public static readonly bool LOG_STACK_TRACES = true;



    /// <summary>
    /// The main function - handles HTTP POST request invocation
    /// </summary>
    /// <param name="request">The Http Request object</param>
    /// <param name="context">The Aws Lambda function context</param>
    /// <returns>A response object</returns>
    public APIGatewayProxyResponse FunctionHandler(APIGatewayProxyRequest request, ILambdaContext context)
    {
        try
        {
            //request.Body = @"";


            //preset
            //do something about clearing logs or putting a 
            //separator line in logs when starting a new job in the CLI !!!
            Messages.Log = "";
            Messages.printLogo();

            //check
            if (request == null)
                throw new Exception("APIGatewayProxyRequest object is NULL");

            //decode
            byte[] data = Convert.FromBase64String(request.Body);
            string decodedString = System.Text.Encoding.UTF8.GetString(data);

            //check
            if (decodedString.StartsWith("command=") == false)
                throw new Exception("command string must start with \"command=\"");
            //Messages.ConsoleLog("decodedString : " + decodedString);


            // read parameters
            string? command = null;
            string? translator = null;
            string? verbosity = null;
            string? filename = null;
            string? code = null;

            //loop
            string[] sep = decodedString.Split('&');
            foreach (string param in sep)
            {
                if (param.StartsWith("command=")) command = param.Substring(8);
                else if (param.StartsWith("verbosity=")) verbosity = param.Substring(10);
                else if (param.StartsWith("translator=")) translator = param.Substring(11);
                else if (param.StartsWith("filename="))
                {
                    filename = param.Substring(9);
                    filename = filename.Replace("%3D", "=").Replace("%2B", "+").Replace("%2F", "/");
                    byte[] cdata = Convert.FromBase64String(filename);
                    filename = System.Text.Encoding.UTF8.GetString(cdata);
                }
                else if (param.StartsWith("code="))
                {
                    code = param.Substring(5);
                    code = code.Replace("%3D", "=").Replace("%2B", "+").Replace("%2F", "/");
                    byte[] cdata = Convert.FromBase64String(code);
                    code = System.Text.Encoding.UTF8.GetString(cdata);
                }
            }
            Messages.printCmdLineForPOST(command, translator, verbosity, filename);


            //read args
            if (command == null)
            {
                Messages.printNoArgumentsError();
                OutputJson result = new OutputJson();
                result.Result = "Success";
                result.Command = command;
                result.Logs = Messages.Log.Replace("\r\n", "<br>").Replace("\n", "<br>");

                var response = new APIGatewayProxyResponse
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Body = JsonConvert.SerializeObject(result),
                    Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
                };
                return response;
            }
            //help | -h
            else if (command == "help" || command == "h")
            {
                Messages.printHelpMessage();
                OutputJson result = new OutputJson();
                result.Result = "Success";
                result.Command = command;
                result.Logs = Messages.Log.Replace("\r\n", "<br>").Replace("\n", "<br>");
                var response = new APIGatewayProxyResponse
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Body = JsonConvert.SerializeObject(result),
                    Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
                };
                return response;
            }
            //parse
            else if (command == "parse")
            {
                string json = parse(code, translator, verbosity, filename);
                OutputJson result = new OutputJson();
                if (string.IsNullOrEmpty(json)) result.Result = "Error";
                else result.Result = "Success";
                result.Command = command;
                result.Logs = Messages.Log.Replace("\r\n", "<br>").Replace("\n", "<br>");
                result.Json = json;
                var response = new APIGatewayProxyResponse
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Body = JsonConvert.SerializeObject(result),
                    Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
                };
                return response;
            }
            else if (command == "multi-parse")
            {
                //output request object as JSON for testing
                //string sssss = JsonConvert.SerializeObject(request);
                

                string json = multiparse(code, translator, verbosity);
                OutputJson result = new OutputJson();
                if (string.IsNullOrEmpty(json)) result.Result = "Error";
                else result.Result = "Success";
                result.Command = command;
                result.Logs = Messages.Log.Replace("\r\n", "<br>").Replace("\n", "<br>");
                result.Json = json;
                //result.Json = sssss;
                //string gggggg = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(json));
                //result.Json = result.Json.Replace("Built with Describe Compiler version 0.9.4", request.Body + "{{{BODY|ENDS|HERE}}}" + gggggg);



                var response = new APIGatewayProxyResponse
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Body = JsonConvert.SerializeObject(result),
                    Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
                };
                return response;
            }
            else
            {
                Messages.printArgumentError(command, "Command");
                OutputJson result = new OutputJson();
                result.Result = "Error";
                result.Command = command;
                result.Logs = Messages.Log.Replace("\r\n", "<br>").Replace("\n", "<br>");
                var response = new APIGatewayProxyResponse
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Body = JsonConvert.SerializeObject(result),
                    Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
                };
                return response;
            }
        }
        catch (Exception ex)
        {
            string message = ex.Message;
            if (LOG_STACK_TRACES)
            {
                message += Environment.NewLine +
                    "StackTrace:" + ex.StackTrace + Environment.NewLine;
            }
            Messages.printFatalError(message);
            OutputJson result = new OutputJson();
            result.Result = "Error";
            //result.Command = inputJson.Command;
            result.Logs = Messages.Log.Replace("\r\n", "<br>").Replace("\n", "<br>");
            var response = new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = JsonConvert.SerializeObject(result),
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
            };
            return response;
        }
    }

    /// <summary>
    /// The main function - handles HTTP GET request invocation
    /// </summary>
    /// <param name="request">The Http Request object</param>
    /// <param name="context">The Aws Lambda function context</param>
    /// <returns>A response object</returns>
    public APIGatewayProxyResponse FunctionHandlerGET(APIGatewayProxyRequest request, ILambdaContext context)
    {
        try
        {
            //string s = JsonConvert.SerializeObject(request);
            //Messages.ConsoleLog("APIGatewayProxyRequest object:");
            //Messages.ConsoleLog(s);
            //Messages.ConsoleLog("------------------------");

            string? command = null;
            if (request.QueryStringParameters.ContainsKey("command"))
                command = request.QueryStringParameters["command"];

            string? translator = null;
            if (request.QueryStringParameters.ContainsKey("translator"))
                translator = request.QueryStringParameters["translator"];

            string? verbosity = null;
            if (request.QueryStringParameters.ContainsKey("verbosity"))
                verbosity = request.QueryStringParameters["verbosity"];

            string? filename = null;
            if (request.QueryStringParameters.ContainsKey("filename"))
                filename = request.QueryStringParameters["filename"];

            //this parameter in URL might be in ""s
            filename = filename.Trim('"');
            filename = filename.Trim('\'');

            string? code = null;
            if (request.QueryStringParameters.ContainsKey("code"))
                code = request.QueryStringParameters["code"];

            //this parameter in URL might be in ""s
            code = code.Trim('"');
            code = code.Trim('\'');

            //preset
            //do something about clearing logs or putting a 
            //separator line in logs when starting a new job in the CLI !!!
            Messages.Log = "";
            Messages.printLogo();
            Messages.printCmdLineForGET(request);


            //read args
            if (command == null)
            {
                Messages.printNoArgumentsError();
                OutputJson result = new OutputJson();
                result.Result = "Success";
                result.Command = command;
                result.Logs = Messages.Log.Replace("\r\n", "<br>").Replace("\n", "<br>");

                var response = new APIGatewayProxyResponse
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Body = JsonConvert.SerializeObject(result),
                    Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
                };
                return response;
            }
            //help | -h
            else if (command == "help" || command == "h")
            {
                Messages.printHelpMessage();
                OutputJson result = new OutputJson();
                result.Result = "Success";
                result.Command = command;
                result.Logs = Messages.Log.Replace("\r\n", "<br>").Replace("\n", "<br>");
                var response = new APIGatewayProxyResponse
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Body = JsonConvert.SerializeObject(result),
                    Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
                };
                return response;
            }
            //parse
            else if (command == "parse")
            {
                string json = parse(code, translator, verbosity, filename);
                OutputJson result = new OutputJson();
                if (string.IsNullOrEmpty(json)) result.Result = "Error";
                else result.Result = "Success";
                result.Command = command;
                result.Logs = Messages.Log.Replace("\r\n", "<br>").Replace("\n", "<br>");
                result.Json = json;
                var response = new APIGatewayProxyResponse
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Body = JsonConvert.SerializeObject(result),
                    Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
                };
                return response;
            }
            else
            {
                Messages.printArgumentError(command, "Command");
                OutputJson result = new OutputJson();
                result.Result = "Error";
                result.Command = command;
                result.Logs = Messages.Log.Replace("\r\n", "<br>").Replace("\n", "<br>");
                var response = new APIGatewayProxyResponse
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Body = JsonConvert.SerializeObject(result),
                    Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
                };
                return response;
            }
        }
        catch (Exception ex)
        {
            string message = ex.Message;
            if (LOG_STACK_TRACES)
            {
                message += Environment.NewLine +
                    "StackTrace:" + ex.StackTrace + Environment.NewLine;
            }
            Messages.printFatalError(message);
            OutputJson result = new OutputJson();
            result.Result = "Error";
            //result.Command = inputJson.Command;
            result.Logs = Messages.Log.Replace("\r\n", "<br>").Replace("\n", "<br>");
            var response = new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = JsonConvert.SerializeObject(result),
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
            };
            return response;
        }
    }

    /// <summary>
    /// The main function - handles Mock Test tool invocation
    /// </summary>
    /// <param name="inputJson">The input object from input JSON</param>
    /// <param name="context">The Aws Lambda function context</param>
    /// <returns>An OutputJson object</returns>
    public OutputJson FunctionHandlerMock(InputJson inputJson, ILambdaContext context)
    {
        try
        {
            //preset
            Messages.printLogo();
            Messages.printCmdLine(inputJson);
            
            //read args
            if (inputJson.Command == null)
            {
                Messages.printNoArgumentsError();
                OutputJson result = new OutputJson();
                result.Result = "Success";
                result.Command = inputJson.Command;
                result.Logs = Messages.Log;
                return result;
            }
            //help | -h
            else if (inputJson.Command == "help" || inputJson.Command == "h")
            {
                Messages.printHelpMessage();
                OutputJson result = new OutputJson();
                result.Result = "Success";
                result.Command = inputJson.Command;
                result.Logs = Messages.Log;
                return result;
            }
            //parse
            else if (inputJson.Command == "parse")
            {
                string json = parse(inputJson);
                OutputJson result = new OutputJson();
                if (string.IsNullOrEmpty(json)) result.Result = "Error";
                else result.Result = "Success";
                result.Command = inputJson.Command;
                result.Logs = Messages.Log;
                result.Json = json;
                return result;
            }
            else
            {
                Messages.printArgumentError(inputJson.Command, "Command");
                OutputJson result = new OutputJson();
                result.Result = "Error";
                result.Command = inputJson.Command;
                result.Logs = Messages.Log;
                return result;
            }
        }
        catch (Exception ex)
        {
            string message = ex.Message;
            if (LOG_STACK_TRACES)
            {
                message += Environment.NewLine +
                    "StackTrace:" + Environment.NewLine;
            }
            Messages.printFatalError(message);
            OutputJson result = new OutputJson();
            result.Result = "Error";
            result.Command = inputJson.Command;
            result.Logs = Messages.Log;
            return result;
        }
    }


    static string multiparse(string code, string translator, string verbosiy)
    {
        //read options
        if (Arguments.readVerbosityArgument(verbosiy) == false) return null;
        if (Arguments.readTranslatorArgument(translator) == false) return null;

        List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
        string[] sep = code.Split(new string[] { "~~~FILE~~~" }, StringSplitOptions.RemoveEmptyEntries);
        for(int i = 0; i < sep.Length; i++)
        {
            string[] pair = sep[i].Split(new string[] { "~~N~~" }, StringSplitOptions.RemoveEmptyEntries);
            list.Add(new KeyValuePair<string, string>(pair[0], pair[1]));
        }

        string result = MainFunctions.CompileMulty(list);
        if (result != null) Messages.printCompilationSuccess();
        else Messages.printFatalError("Parser returned null");

        //return
        return result;
    }
    static string parse(string code, string translator, string verbosiy, string filename)
    {
        //read options
        if (Arguments.readVerbosityArgument(verbosiy) == false) return null;
        if (Arguments.readTranslatorArgument(translator) == false) return null;

        //Compile
        string result = MainFunctions.Compile(code, filename);
        if (result != null) Messages.printCompilationSuccess();
        else Messages.printFatalError("Parser returned null");

        //return
        return result;
    }
    static string parse(InputJson inputJson)
    {
        //read options
        if (Arguments.readVerbosityArgument(inputJson) == false) return null;
        if (Arguments.readTranslatorArgument(inputJson) == false) return null;

        //Compile
        string result = MainFunctions.Compile(inputJson.Code, inputJson.Filename);
        Messages.printCompilationSuccess();

        //return
        return result;
    }
}

public class InputJson
{
    public string Command { get; set; }
    public string Verbosity { get; set; }
    public string Translator { get; set; }

    public string Filename { get; set; }
    public string Code { get; set; }
}
public class OutputJson
{
    public string? Command { get; set; }

    public string? Result { get; set; }
    public string? Logs { get; set; }
    public string? Json { get; set; }
}
//search for "AWS Explorer"