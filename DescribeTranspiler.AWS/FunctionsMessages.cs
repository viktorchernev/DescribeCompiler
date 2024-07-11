using Amazon.Lambda.APIGatewayEvents;
using System;
using System.Reflection;
using System.Runtime.InteropServices;


namespace DescribeCompiler.AWS
{
    public static class Messages
    {
        static Messages()
        {
            Log = "";
        }



        //presets
        public static void printLogo()
        {
            Log += DescribeTranspiler.DescribeCompiler.COMPILER_NAME;
            Log += Environment.NewLine;
        }



        //errors
        public static void printCmdLine(InputJson source)
        {
            string s = "> ";

            s += "{ \"Command\":\"" + source.Command + "\", ";
            s += "\"Translator\":\"" + source.Translator + "\", ";
            s += "\"Verbosity\":\"" + source.Verbosity + "\", ";

            string code = source.Code;
            if (code.Length > 12) code = code.Substring(0, 12) + " ... ";
            s += "\"Code\":\"" + code + "\"; }";
            ConsoleLogInfo(s);
        }
        public static void printCmdLineForGET(APIGatewayProxyRequest request)
        {
            string s = "> ";

            string command = "null";
            if(request.QueryStringParameters.ContainsKey("command"))
            {
                command = request.QueryStringParameters["command"];
            }
            s += "{ \"Command\":\"" + command + "\", ";

            string translator = "null";
            if (request.QueryStringParameters.ContainsKey("translator"))
            {
                translator = request.QueryStringParameters["translator"];
            }
            s += "\"Translator\":\"" + translator + "\", ";

            string verbosity = "null";
            if (request.QueryStringParameters.ContainsKey("verbosity"))
            {
                verbosity = request.QueryStringParameters["verbosity"];
            }
            s += "\"Verbosity\":\"" + verbosity + "\", ";

            string code = "null";
            if (request.QueryStringParameters.ContainsKey("code"))
            {
                code = request.QueryStringParameters["code"];
                if(code.Length > 12) code = code.Substring(0, 12) + " ... ";
            }
            s += "\"Code\":\"" + code + "\"; }";

            ConsoleLogInfo(s);
        }
        public static void printCmdLineForPOST(string command, string translator, string verbosity, string filename)
        {
            string s = "> ";

            if(command == null) command = "null";
            s += "{ \"Command\":\"" + command + "\", ";

            if (translator == null) translator = "null";
            s += "\"Translator\":\"" + translator + "\", ";

            if (verbosity == null) verbosity = "null";
            s += "\"Verbosity\":\"" + verbosity + "\", ";
            s += "\"Filename\":\"" + filename + "\", ";
            s += "\"Code\":[CODE]; }";

            ConsoleLogInfo(s);
        }
        public static void printCompilationSuccess()
        {
            //add to log
            Log += "Task completed successfully. Press any key to exit." + Environment.NewLine;
        }
        public static void printHelpMessage()
        {
            ConsoleLogInfo("-----------------------------------------------------------------");
            ConsoleLog("about: " + DescribeTranspiler.DescribeCompiler.COMPILER_NAME);
            ConsoleLogInfo("Describe is a domain specific language used to write and maintain complex data lists");
            ConsoleLogInfo("that are compiled on demand to html, xaml, xml, sql, json and any other language needed.");
            ConsoleLogInfo("Describe is licensed under the GNU Affero General Public License v3.0");
            ConsoleLogInfo("For more information visit https://github.com/viktorchernev/DescribeCompiler");
            ConsoleLogInfo("-----------------------------------------------------------------");
            
            Log += "Press any key to exit." + Environment.NewLine;
        }
        public static void printWarning(string message)
        {
            Log += "Warning: " + message + Environment.NewLine;
            Log += "Press any key to continue." + Environment.NewLine;
        }
        public static void printNoArgumentsError()
        {
            Log += "No arguments or invalid argument count." + Environment.NewLine;
            printHelpMessage();
            Log += "Press any key to exit." + Environment.NewLine;
        }
        public static void printArgumentError(string arg, string field)
        {
            Log += "Invalid argument \"" + field + "\" - \"" + arg + "\"" + Environment.NewLine;
            printHelpMessage();
            Log += "Press any key to exit." + Environment.NewLine;
        }
        public static void printArgumentError(string arg, string field, string message)
        {
            Log += "Invalid argument \"" + field + 
                "\" : \"" + arg + "\" - " + message + Environment.NewLine;
            Log += "Press any key to exit." + Environment.NewLine;
        }
        public static void printFatalError(string message)
        {
            Log += "Fatal error: " + message + Environment.NewLine;
            Log += "Press any key to exit." + Environment.NewLine;
        }


        //log
        public static string Log
        {
            get;
            set;
        }
        public static void ConsoleLog(string text)
        {
            if (text == null) text = "null";
            Log += text + Environment.NewLine;
        }
        public static void ConsoleLogInfo(string text)
        {
            if (text == null) text = "null";
            Log += text + Environment.NewLine;
        }
        public static void ConsoleLogError(string text)
        {
            if (text == null) text = "null";
            Log += text + Environment.NewLine;
        }
        public static void ConsoleLogParseInfo(string text)
        {
            if (text == null) text = "null";
            Log += text + Environment.NewLine;
        }
    }
}