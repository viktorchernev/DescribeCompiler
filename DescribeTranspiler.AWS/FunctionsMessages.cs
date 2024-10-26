using Amazon.Lambda.APIGatewayEvents;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Reflection;
using System.Runtime.InteropServices;


namespace DescribeTranspiler.AWS
{
    //https://patorjk.com/software/taag/#p=display&f=Alpha&t=DESCRIBE
    //cool - 3D Diagonal, Alpha, Impossible, Isometric1
    //Isometric2, Isometric3, Isometric4, Slant Relief, Small Isometric1
    //minimalist - Bulbhead, Graceful, Modular, Ogre, Slant, Small
    //Small Slant, Standard, Twisted, ANSI Shadow

    public static class Messages
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        static Messages()
        {
            Log = "";
        }


        //presets
        /// <summary>
        /// Logs an initial message - like a banner, informing of the version 
        /// of the describe compiler, and the operation we are starting.
        /// </summary>
        /// <param name="operation"></param>
        public static void printInitialMessage(string operation)
        {
            Log += DescribeTranspiler.DescribeCompiler.CompilerName;
            Log += Environment.NewLine;
            Log += "Starting a " + operation + " operation.";
            Log += Environment.NewLine;
        }

        /// <summary>
        /// Logs the command JSON.
        /// </summary>
        /// <param name="json">The JSON to log.</param>
        public static void printCmdJson(string? json)
        {
            string s = "> ";

            if (json == null)
            {
                s += "NULL";
                ConsoleLogInfo(s);
                return;
            }

            try
            {
                JObject jo = JObject.Parse(json);

                // Redact sensitive fields
                if (jo["code"] != null) jo["code"] = "...";
                if (jo["input_password"] != null) jo["input_password"] = "***";
                if (jo["output_password"] != null) jo["output_password"] = "***";
                if (jo["log_password"] != null) jo["log_password"] = "***";
                s += jo.ToString();
            }
            catch (JsonReaderException ex)
            {
                // Handle malformed JSON
                s += "Invalid JSON: " + ex.Message;
            }

            ConsoleLogInfo(s);
        }


        //errors        
        public static void printCompilationSuccess()
        {
            //add to log
            Log += "Task completed successfully. Press any key to exit." + Environment.NewLine;
        }
        public static void printHelpMessage()
        {
            ConsoleLogInfo("-----------------------------------------------------------------");
            ConsoleLog("about: " + DescribeTranspiler.DescribeCompiler.CompilerVersion);
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
        public static void printCommandError(string? commandArg, string expected)
        {
            if (commandArg == null) commandArg = "null";

            Log += "Invalid command argument \"" + commandArg + "\" - was expecting \"" + expected + "\"" + Environment.NewLine;
            //printHelpMessage();
        }
        public static void printArgumentError(string? arg, string? field)
        {
            if (arg == null) arg = "NULL";
            if (field == null) field = "???";

            Log += "Invalid argument \"" + field + "\" - \"" + arg + "\"" + Environment.NewLine;
            printHelpMessage();
            Log += "Press any key to exit." + Environment.NewLine;
        }
        public static void printArgumentError(string? arg, string? field, string? message)
        {
            if (arg == null) arg = "NULL";
            if (field == null) field = "???";
            if (message == null) message = "???";

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