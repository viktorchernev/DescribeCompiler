using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace DescribeTranspiler.AWS;

public class Function
{
    public static readonly bool LOG_STACK_TRACES = true;


    /// <summary>
    /// Lambda function. Translate single Describe file to single JSON file, using the JSON_PLAIN translator.
    /// </summary>
    /// <param name="request">The Http Request object</param>
    /// <param name="context">The Aws Lambda function context</param>
    /// <returns>A response object</returns>
    public APIGatewayProxyResponse HTranspile_SingleDmlToSingleJson(APIGatewayProxyRequest request, ILambdaContext context)
    {
        try
        {
            // preset
            Messages.Log = "";
            Messages.printInitialMessage("Single DML to Single JSON");

            // check
            if (request == null)
            {
                throw new Exception("APIGatewayProxyRequest object is NULL");
            }

            // decode
            byte[] data = Convert.FromBase64String(request.Body);
            string decodedString = System.Text.Encoding.UTF8.GetString(data);
            Messages.printCmdJson(decodedString);

            // read parameters
            JObject jsonObject = JObject.Parse(decodedString);
            string? command = (string?)jsonObject["command"];
            string? filename = (string?)jsonObject["filename"];
            string? code = (string?)jsonObject["code"];
            string? input_password = (string?)jsonObject["input_password"];
            string? output_password = (string?)jsonObject["output_password"];
            string? log_password = (string?)jsonObject["log_password"];
            string? language_version = (string?)jsonObject["language_version"] ?? "1.0";
            string? translator = "JSON_PLAIN";
            string? beautify = (string?)jsonObject["beautify"] ?? "false";
            string? verbosity = (string?)jsonObject["verbosity"] ?? "low";

            // check command
            if(command != "parse-file")
            {
                Messages.printCommandError(command, "parse-file");
                throw new Exception("Unexpected command");
            }

            // check code
            if(string.IsNullOrEmpty(code) || string.IsNullOrWhiteSpace(code))
            {
                Messages.printArgumentError(code, "code", "Code is NULL or empty");
                throw new Exception("Invalid code");
            }

            // decode code
            byte[] codedata = Convert.FromBase64String(code);
            code = System.Text.Encoding.UTF8.GetString(codedata);

            // check code
            if (string.IsNullOrEmpty(code) || string.IsNullOrWhiteSpace(code))
            {
                Messages.printArgumentError(code, "code", "Code is NULL or empty after decoding");
                throw new Exception("Invalid code");
            }

            // read args
            Arguments.readFilenameArgument(filename);
            Arguments.readTranslatorArgument(translator);
            Arguments.readBeautifyArgument(beautify);
            Arguments.readVerbosityArgument(verbosity);
            Arguments.readLanguageVersion(language_version);
            Arguments.readInputPasswordArgument(input_password);
            Arguments.readOutputPasswordArgument(output_password);
            Arguments.readLogPasswordArgument(log_password);

            // parse
            string? json = MainFunctions.Compile(code);
            if (json != null) Messages.printCompilationSuccess();
            else
            {
                Messages.printFatalError("Parser returned null");
                throw new Exception("Parsing failed");
            }

            // to base64
            byte[] byteArray = Encoding.UTF8.GetBytes(json);
            string base64Json = Convert.ToBase64String(byteArray);

            // output
            OutputJson result = new OutputJson();
            if (string.IsNullOrEmpty(json)) result.Result = "Error";
            else result.Result = "Success";
            result.Command = command;
            result.Logs = Messages.Log;
            result.Output = base64Json;

            // return
            var response = new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = JsonConvert.SerializeObject(result),
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
            };
            return response;
        }
        catch (Exception ex)
        {
            var tres = new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = "ERROR!" + ex.Message,
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
            };
            return tres;
        }
    }

    /// <summary>
    /// Lambda function. Translate single Describe file to single JSON file, using the JSON_LISTIARY translator.
    /// </summary>
    /// <param name="request">The Http Request object</param>
    /// <param name="context">The Aws Lambda function context</param>
    /// <returns>A response object</returns>
    public APIGatewayProxyResponse HTranspile_SingleDmlToSingleJsonListiary(APIGatewayProxyRequest request, ILambdaContext context)
    {
        try
        {
            // preset
            Messages.Log = "";
            Messages.printInitialMessage("Single DML to Single JSON");

            // check
            if (request == null)
            {
                throw new Exception("APIGatewayProxyRequest object is NULL");
            }

            // decode
            byte[] data = Convert.FromBase64String(request.Body);
            string decodedString = System.Text.Encoding.UTF8.GetString(data);
            Messages.printCmdJson(decodedString);

            // read parameters
            JObject jsonObject = JObject.Parse(decodedString);
            string? command = (string?)jsonObject["command"];
            string? filename = (string?)jsonObject["filename"];
            string? code = (string?)jsonObject["code"];
            string? input_password = (string?)jsonObject["input_password"];
            string? output_password = (string?)jsonObject["output_password"];
            string? log_password = (string?)jsonObject["log_password"];
            string? language_version = (string?)jsonObject["language_version"] ?? "1.0";
            string? translator = "JSON_LISTIARY";
            string? beautify = (string?)jsonObject["beautify"] ?? "false";
            string? verbosity = (string?)jsonObject["verbosity"] ?? "low";

            // check command
            if (command != "parse-file")
            {
                Messages.printCommandError(command, "parse-file");
                throw new Exception("Unexpected command");
            }

            // check code
            if (string.IsNullOrEmpty(code) || string.IsNullOrWhiteSpace(code))
            {
                Messages.printArgumentError(code, "code", "Code is NULL or empty");
                throw new Exception("Invalid code");
            }

            // decode code
            byte[] codedata = Convert.FromBase64String(code);
            code = System.Text.Encoding.UTF8.GetString(codedata);

            // check code
            if (string.IsNullOrEmpty(code) || string.IsNullOrWhiteSpace(code))
            {
                Messages.printArgumentError(code, "code", "Code is NULL or empty after decoding");
                throw new Exception("Invalid code");
            }

            // read args
            Arguments.readFilenameArgument(filename);
            Arguments.readTranslatorArgument(translator);
            Arguments.readBeautifyArgument(beautify);
            Arguments.readVerbosityArgument(verbosity);
            Arguments.readLanguageVersion(language_version);
            Arguments.readInputPasswordArgument(input_password);
            Arguments.readOutputPasswordArgument(output_password);
            Arguments.readLogPasswordArgument(log_password);

            // parse
            string? json = MainFunctions.Compile(code);
            if (json != null) Messages.printCompilationSuccess();
            else
            {
                Messages.printFatalError("Parser returned null");
                throw new Exception("Parsing failed");
            }

            // to base64
            byte[] byteArray = Encoding.UTF8.GetBytes(json);
            string base64Json = Convert.ToBase64String(byteArray);

            // output
            OutputJson result = new OutputJson();
            if (string.IsNullOrEmpty(json)) result.Result = "Error";
            else result.Result = "Success";
            result.Command = command;
            result.Logs = Messages.Log;
            result.Output = base64Json;

            // return
            var response = new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = JsonConvert.SerializeObject(result),
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
            };
            return response;
        }
        catch (Exception ex)
        {
            var tres = new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = "ERROR!" + ex.Message,
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
            };
            return tres;
        }
    }

    /// <summary>
    /// Lambda function. Translate single Describe file to single XML file.
    /// </summary>
    /// <param name="request">The Http Request object</param>
    /// <param name="context">The Aws Lambda function context</param>
    /// <returns>A response object</returns>
    public APIGatewayProxyResponse HTranspile_SingleDmlToSingleXml(APIGatewayProxyRequest request, ILambdaContext context)
    {
        try
        {
            // preset
            Messages.Log = "";
            Messages.printInitialMessage("Single DML to Single JSON");

            // check
            if (request == null)
            {
                throw new Exception("APIGatewayProxyRequest object is NULL");
            }

            // decode
            byte[] data = Convert.FromBase64String(request.Body);
            string decodedString = System.Text.Encoding.UTF8.GetString(data);
            Messages.printCmdJson(decodedString);

            // read parameters
            JObject jsonObject = JObject.Parse(decodedString);
            string? command = (string?)jsonObject["command"];
            string? filename = (string?)jsonObject["filename"];
            string? code = (string?)jsonObject["code"];
            string? input_password = (string?)jsonObject["input_password"];
            string? output_password = (string?)jsonObject["output_password"];
            string? log_password = (string?)jsonObject["log_password"];
            string? language_version = (string?)jsonObject["language_version"] ?? "1.0";
            string? translator = (string?)jsonObject["translator"] ?? "XML_PLAIN";
            string? beautify = (string?)jsonObject["beautify"] ?? "false";
            string? verbosity = (string?)jsonObject["verbosity"] ?? "low";

            // check command
            if (command != "parse-file")
            {
                Messages.printCommandError(command, "parse-file");
                throw new Exception("Unexpected command");
            }

            // check code
            if (string.IsNullOrEmpty(code) || string.IsNullOrWhiteSpace(code))
            {
                Messages.printArgumentError(code, "code", "Code is NULL or empty");
                throw new Exception("Invalid code");
            }

            // decode code
            byte[] codedata = Convert.FromBase64String(code);
            code = System.Text.Encoding.UTF8.GetString(codedata);

            // check code
            if (string.IsNullOrEmpty(code) || string.IsNullOrWhiteSpace(code))
            {
                Messages.printArgumentError(code, "code", "Code is NULL or empty after decoding");
                throw new Exception("Invalid code");
            }

            // read args
            Arguments.readFilenameArgument(filename);
            Arguments.readTranslatorArgument(translator);
            Arguments.readBeautifyArgument(beautify);
            Arguments.readVerbosityArgument(verbosity);
            Arguments.readLanguageVersion(language_version);
            Arguments.readInputPasswordArgument(input_password);
            Arguments.readOutputPasswordArgument(output_password);
            Arguments.readLogPasswordArgument(log_password);

            // parse
            string? json = MainFunctions.Compile(code);
            if (json != null) Messages.printCompilationSuccess();
            else
            {
                Messages.printFatalError("Parser returned null");
                throw new Exception("Parsing failed");
            }

            // to base64
            byte[] byteArray = Encoding.UTF8.GetBytes(json);
            string base64Json = Convert.ToBase64String(byteArray);

            // output
            OutputJson result = new OutputJson();
            if (string.IsNullOrEmpty(json)) result.Result = "Error";
            else result.Result = "Success";
            result.Command = command;
            result.Logs = Messages.Log;
            result.Output = base64Json;

            // return
            var response = new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = JsonConvert.SerializeObject(result),
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
            };
            return response;
        }
        catch (Exception ex)
        {
            var tres = new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = "ERROR!" + ex.Message,
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
            };
            return tres;
        }
    }

    /// <summary>
    /// Lambda function. Translate single Describe file to single HTML file, using HTML_PAGE translator.
    /// </summary>
    /// <param name="request">The Http Request object</param>
    /// <param name="context">The Aws Lambda function context</param>
    /// <returns>A response object</returns>
    public APIGatewayProxyResponse HTranspile_SingleDmlToSingleHtml(APIGatewayProxyRequest request, ILambdaContext context)
    {
        try
        {
            // preset
            Messages.Log = "";
            Messages.printInitialMessage("Single DML to Single JSON");

            // check
            if (request == null)
            {
                throw new Exception("APIGatewayProxyRequest object is NULL");
            }

            // decode
            byte[] data = Convert.FromBase64String(request.Body);
            string decodedString = System.Text.Encoding.UTF8.GetString(data);
            Messages.printCmdJson(decodedString);

            // read parameters
            JObject jsonObject = JObject.Parse(decodedString);
            string? command = (string?)jsonObject["command"];
            string? filename = (string?)jsonObject["filename"];
            string? code = (string?)jsonObject["code"];
            string? input_password = (string?)jsonObject["input_password"];
            string? output_password = (string?)jsonObject["output_password"];
            string? log_password = (string?)jsonObject["log_password"];
            string? language_version = (string?)jsonObject["language_version"] ?? "1.0";
            string? translator = "HTML_PAGE";
            string? beautify = (string?)jsonObject["beautify"] ?? "false";
            string? verbosity = (string?)jsonObject["verbosity"] ?? "low";

            // check command
            if (command != "parse-file")
            {
                Messages.printCommandError(command, "parse-file");
                throw new Exception("Unexpected command");
            }

            // check code
            if (string.IsNullOrEmpty(code) || string.IsNullOrWhiteSpace(code))
            {
                Messages.printArgumentError(code, "code", "Code is NULL or empty");
                throw new Exception("Invalid code");
            }

            // decode code
            byte[] codedata = Convert.FromBase64String(code);
            code = System.Text.Encoding.UTF8.GetString(codedata);

            // check code
            if (string.IsNullOrEmpty(code) || string.IsNullOrWhiteSpace(code))
            {
                Messages.printArgumentError(code, "code", "Code is NULL or empty after decoding");
                throw new Exception("Invalid code");
            }

            // read args
            Arguments.readFilenameArgument(filename);
            Arguments.readTranslatorArgument(translator);
            Arguments.readBeautifyArgument(beautify);
            Arguments.readVerbosityArgument(verbosity);
            Arguments.readLanguageVersion(language_version);
            Arguments.readInputPasswordArgument(input_password);
            Arguments.readOutputPasswordArgument(output_password);
            Arguments.readLogPasswordArgument(log_password);

            // parse
            string? json = MainFunctions.Compile(code);
            if (json != null) Messages.printCompilationSuccess();
            else
            {
                Messages.printFatalError("Parser returned null");
                throw new Exception("Parsing failed");
            }

            // to base64
            byte[] byteArray = Encoding.UTF8.GetBytes(json);
            string base64Json = Convert.ToBase64String(byteArray);

            // output
            OutputJson result = new OutputJson();
            if (string.IsNullOrEmpty(json)) result.Result = "Error";
            else result.Result = "Success";
            result.Command = command;
            result.Logs = Messages.Log;
            result.Output = base64Json;

            // return
            var response = new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = JsonConvert.SerializeObject(result),
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
            };
            return response;
        }
        catch (Exception ex)
        {
            var tres = new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = "ERROR!" + ex.Message,
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
            };
            return tres;
        }
    }

    /// <summary>
    /// Lambda function. Translate single Describe file to single HTML file, using HTML_PLAIN translator.
    /// </summary>
    /// <param name="request">The Http Request object</param>
    /// <param name="context">The Aws Lambda function context</param>
    /// <returns>A response object</returns>
    public APIGatewayProxyResponse HTranspile_SingleDmlToSingleHtmlPlain(APIGatewayProxyRequest request, ILambdaContext context)
    {
        try
        {
            // preset
            Messages.Log = "";
            Messages.printInitialMessage("Single DML to Single JSON");

            // check
            if (request == null)
            {
                throw new Exception("APIGatewayProxyRequest object is NULL");
            }

            // decode
            byte[] data = Convert.FromBase64String(request.Body);
            string decodedString = System.Text.Encoding.UTF8.GetString(data);
            Messages.printCmdJson(decodedString);

            // read parameters
            JObject jsonObject = JObject.Parse(decodedString);
            string? command = (string?)jsonObject["command"];
            string? filename = (string?)jsonObject["filename"];
            string? code = (string?)jsonObject["code"];
            string? input_password = (string?)jsonObject["input_password"];
            string? output_password = (string?)jsonObject["output_password"];
            string? log_password = (string?)jsonObject["log_password"];
            string? language_version = (string?)jsonObject["language_version"] ?? "1.0";
            string? translator = "HTML_PLAIN";
            string? beautify = (string?)jsonObject["beautify"] ?? "false";
            string? verbosity = (string?)jsonObject["verbosity"] ?? "low";

            // check command
            if (command != "parse-file")
            {
                Messages.printCommandError(command, "parse-file");
                throw new Exception("Unexpected command");
            }

            // check code
            if (string.IsNullOrEmpty(code) || string.IsNullOrWhiteSpace(code))
            {
                Messages.printArgumentError(code, "code", "Code is NULL or empty");
                throw new Exception("Invalid code");
            }

            // decode code
            byte[] codedata = Convert.FromBase64String(code);
            code = System.Text.Encoding.UTF8.GetString(codedata);

            // check code
            if (string.IsNullOrEmpty(code) || string.IsNullOrWhiteSpace(code))
            {
                Messages.printArgumentError(code, "code", "Code is NULL or empty after decoding");
                throw new Exception("Invalid code");
            }

            // read args
            Arguments.readFilenameArgument(filename);
            Arguments.readTranslatorArgument(translator);
            Arguments.readBeautifyArgument(beautify);
            Arguments.readVerbosityArgument(verbosity);
            Arguments.readLanguageVersion(language_version);
            Arguments.readInputPasswordArgument(input_password);
            Arguments.readOutputPasswordArgument(output_password);
            Arguments.readLogPasswordArgument(log_password);

            // parse
            string? json = MainFunctions.Compile(code);
            if (json != null) Messages.printCompilationSuccess();
            else
            {
                Messages.printFatalError("Parser returned null");
                throw new Exception("Parsing failed");
            }

            // to base64
            byte[] byteArray = Encoding.UTF8.GetBytes(json);
            string base64Json = Convert.ToBase64String(byteArray);

            // output
            OutputJson result = new OutputJson();
            if (string.IsNullOrEmpty(json)) result.Result = "Error";
            else result.Result = "Success";
            result.Command = command;
            result.Logs = Messages.Log;
            result.Output = base64Json;

            // return
            var response = new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = JsonConvert.SerializeObject(result),
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
            };
            return response;
        }
        catch (Exception ex)
        {
            var tres = new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = "ERROR!" + ex.Message,
                Headers = new Dictionary<string, string> { { "Content-Type", "application/json" }, { "Access-Control-Allow-Origin", "*" } }
            };
            return tres;
        }
    }
}
public class OutputJson
{
    public string? Command { get; set; }

    public string? Result { get; set; }
    public string? Logs { get; set; }
    public string? Output { get; set; }
}