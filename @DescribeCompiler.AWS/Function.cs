using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using Newtonsoft.Json;
using System.IO;
using System.Net;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace DescribeCompiler.AWS;

public class Function
{
    //https://www.youtube.com/watch?v=IHIJFVUQyFY - AWS LAMBDA For The .NET Developer
    public static readonly bool LOG_STACK_TRACES = true;

    /// <summary>
    /// The main function
    /// </summary>
    /// <param name="request"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public APIGatewayProxyResponse FunctionHandler(APIGatewayProxyRequest request, ILambdaContext context)
    {
        try
        {
            string? command = null;
            if (request.QueryStringParameters.ContainsKey("command"))
                command = request.QueryStringParameters["command"];

            string? translator = null;
            if (request.QueryStringParameters.ContainsKey("translator"))
                translator = request.QueryStringParameters["translator"];

            string? verbosity = null;
            if (request.QueryStringParameters.ContainsKey("verbosity"))
                verbosity = request.QueryStringParameters["verbosity"];

            string? code = null;
            if (request.QueryStringParameters.ContainsKey("code"))
                code = request.QueryStringParameters["code"];

            code = code.Trim('"');//remove this when implement POST
            code = code.Trim('\'');//remove this when implement POST

            //preset
            //do something about clearing logs or putting a 
            //separator line in logs when starting a new job in the CLI !!!
            Messages.Log = "";
            Messages.printLogo();
            Messages.printCmdLine(request);
            string s = JsonConvert.SerializeObject(request);
            Messages.ConsoleLog("APIGatewayProxyRequest object:");
            Messages.ConsoleLog(s);
            Messages.ConsoleLog("------------------------");


            //read args
            if (command == null)
            {
                Messages.printNoArgumentsError();
                OutputJson result = new OutputJson();
                result.Result = "Success";
                result.Command = command;
                result.Logs = Messages.Log;

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
                result.Logs = Messages.Log;
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
                string json = parse(code, translator, verbosity);
                OutputJson result = new OutputJson();
                if (string.IsNullOrEmpty(json)) result.Result = "Error";
                else result.Result = "Success";
                result.Command = command;
                result.Logs = Messages.Log;
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
                result.Logs = Messages.Log;
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
            result.Logs = Messages.Log;
            var response = new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = JsonConvert.SerializeObject(result),
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
            };
            return response;
        }
    }
    static string parse(string code, string translator, string verbosiy)
    {
        //read options
        if (Arguments.readVerbosityArgument(verbosiy) == false) return null;
        if (Arguments.readTranslatorArgument(translator) == false) return null;

        //Compile
        string result = MainFunctions.Compile(code);
        Messages.printCompilationSuccess();

        //return
        return result;
    }


    public OutputJson FunctionHandlerOld(InputJson inputJson, ILambdaContext context)
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
    static string parse(InputJson inputJson)
    {
        //read options
        if (Arguments.readVerbosityArgument(inputJson) == false) return null;
        if (Arguments.readTranslatorArgument(inputJson) == false) return null;

        //Compile
        string result = MainFunctions.Compile(inputJson.Code);
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