using Amazon.Lambda.Core;

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
    /// <param name="inputJson"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public string FunctionHandler(InputJson inputJson, ILambdaContext context)
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
                return result.ToJsonString();
            }
            //help | -h
            else if (inputJson.Command == "help" || inputJson.Command == "h")
            {
                Messages.printHelpMessage();
                OutputJson result = new OutputJson();
                result.Result = "Success";
                result.Command = inputJson.Command;
                result.Logs = Messages.Log;
                return result.ToJsonString();
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
                return result.ToJsonString();
            }
            else
            {
                Messages.printArgumentError(inputJson.Command, "Command");
                OutputJson result = new OutputJson();
                result.Result = "Error";
                result.Command = inputJson.Command;
                result.Logs = Messages.Log;
                return result.ToJsonString();
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
            return result.ToJsonString();
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
    public string Command { get; set; }

    public string Result { get; set; }
    public string Logs { get; set; }
    public string Json { get; set; }

    public string ToJsonString()
    {
        string s = "{";
        s += "\"Command\":\"" + Command + "\",";        //escape?

        s += "\"Result\":\"" + Result + "\",";
        s += "\"Logs\":\"" + Logs + "\",";              //escape?
        s += "\"Json\":" + Json + "}";

        return s;
    }
}
//search for "AWS Explorer"