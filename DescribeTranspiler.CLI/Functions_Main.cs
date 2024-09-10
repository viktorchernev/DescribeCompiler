using DescribeTranspiler.Translators;
using DescribeParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DescribeParser.Unfold;
using DescribeTranspiler.Listiary.Translators;
using DescribeTranspiler.CLI;
using MySqlX.XDevAPI.Common;

namespace DescribeTranspiler.Cli
{
    internal static class MainFunctions
    {
        /// <summary>
        /// Compile source file(s)
        /// </summary>
        /// <returns>True if successful, otherwise false</returns>
        internal static bool Compile()
        {
            try
            {
                DescribeTranspiler.DescribeCompiler comp =
                new DescribeTranspiler.DescribeCompiler(
                    Datnik.verbosity,
                    Messages.ConsoleLog,
                    Messages.ConsoleLogError,
                    Messages.ConsoleLogInfo,
                    Messages.ConsoleLogParseInfo);

                //settings
                comp.PARSE_TOP_DIRECTORY_ONLY = Datnik.topOnly;
                comp.PARSE_DS_ONLY = Datnik.dsOnly;
                comp.STOP_ON_ERROR = Datnik.requireSuccess;
                if(comp.LanguageVersion != Datnik.langVer) comp.LanguageVersion = Datnik.langVer;

                //templates
                DescribeUnfoldTranslator translator;
                if (Datnik.translatorName.ToLower().StartsWith("json_listiary")
                    || Datnik.translatorName.ToLower() == "json_listiary")
                {
                    translator = new JsonListiaryTranslator(
                        Messages.ConsoleLog,
                        Messages.ConsoleLogError,
                        Messages.ConsoleLogInfo);
                }
                else if (Datnik.translatorName.ToLower().StartsWith("json_")
                    || Datnik.translatorName.ToLower() == "json")
                {
                    translator = new JsonBasicTranslator(
                        Messages.ConsoleLog,
                        Messages.ConsoleLogError,
                        Messages.ConsoleLogInfo);
                }
                else if (Datnik.translatorName.ToLower().StartsWith("html_plain"))
                {
                    translator = new HtmlBasicTranslator(
                        Messages.ConsoleLog,
                        Messages.ConsoleLogError,
                        Messages.ConsoleLogInfo);
                }
                else if (Datnik.translatorName.ToLower().StartsWith("html_")
                    || Datnik.translatorName.ToLower() == "html")
                {
                    translator = new HtmlPageTranslator(
                        Messages.ConsoleLog,
                        Messages.ConsoleLogError,
                        Messages.ConsoleLogInfo);
                }
                else if (Datnik.translatorName.ToLower().StartsWith("xml_")
                    || Datnik.translatorName.ToLower() == "xml")
                {
                    translator = new XmlBasicTranslator(
                        Messages.ConsoleLog,
                        Messages.ConsoleLogError,
                        Messages.ConsoleLogInfo);
                }
                else if (Datnik.translatorName.ToLower().StartsWith("sql_")
                    || Datnik.translatorName.ToLower() == "sql")
                {
                    translator = new SqlFileFillTranslator(
                        Messages.ConsoleLog,
                        Messages.ConsoleLogError,
                        Messages.ConsoleLogInfo);
                }
                else
                {
                    Messages.printFatalError(
                        "Template name does not start with \"HTML_\" or \"JSON_\"," +
                        " thus, it is not known which translator to use");
                    return false;
                }

                //compile
                DescribeUnfold unfold = new DescribeUnfold();
                bool r = false;
                if (Datnik.parseEncryptedFiles == false)
                {
                    if (Datnik.isInputDir == false) r = comp.ParseFile(new FileInfo(Datnik.input!), ref unfold);
                    else r = comp.ParseFolder(new DirectoryInfo(Datnik.input!), ref unfold);
                }
                else
                {
                    if (Datnik.isInputDir == false) // single encrypted file
                    {
                        FileInfo finfo = new FileInfo(Datnik.input!);
                        bool isEncrypted = (finfo.Extension == ".denc");
                        if(isEncrypted == false) r = comp.ParseFile(finfo, ref unfold);
                        else
                        {
                            string filename = finfo.FullName;
                            string source = File.ReadAllText(finfo.FullName);
                            string decoded = Program.CryptoUtil.DecryptString(source, Datnik.inputPassword!);
                            r = comp.ParseString(decoded, filename, ref unfold);
                        }
                    }
                    else // folder with encrypted files
                    {

                    }
                }

                string? result; 
                if(Datnik.isBeautified)
                {
                    if (translator is JsonBasicTranslator)
                        result = (translator as JsonBasicTranslator)!.TranslateUnfoldPretty(unfold);
                    else if (translator is JsonListiaryTranslator)
                        result = (translator as JsonListiaryTranslator)!.TranslateUnfoldPretty(unfold);
                    else if (translator is XmlBasicTranslator)
                        result = (translator as XmlBasicTranslator)!.TranslateUnfoldPretty(unfold);
                    else result = translator.TranslateUnfold(unfold);
                }
                else
                {
                    result = translator.TranslateUnfold(unfold);
                }

                if (result != null)
                {
                    if(Datnik.encryptOutput)
                    {
                        string log = Messages.Log;
                        string encryptedOutput = Program.CryptoUtil.EncryptString(result, Datnik.logPassword!);
                        File.WriteAllText(Datnik.output!, encryptedOutput);
                    }
                    else
                    {
                        File.WriteAllText(Datnik.output!, result);
                    }
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (Program.LOG_STACK_TRACES)
                {
                    message += Environment.NewLine +
                        "StackTrace:" + Environment.NewLine;
                }
                Messages.printFatalError(message);
                return false;
            }
        }

        /// <summary>
        /// Encrypt source file(s)
        /// </summary>
        /// <returns>True if successful, otherwise false</returns>
        internal static bool EncryptFile()
        {
            try
            {
                // check if source file exists
                Messages.ConsoleLog("Encrypting - \"" + Datnik.input + "\"");
                if (!File.Exists(Datnik.input))
                {
                    Messages.printFatalError("File does not exist!");
                    return false;
                }

                // read plaitext source
                string source = "";
                try
                {
                    source = File.ReadAllText(Datnik.input);
                    if (string.IsNullOrWhiteSpace(source))
                    {
                        Messages.printFatalError("Source file is empty!");
                        return false;
                    }
                    else if (source.Length == 0)
                    {
                        Messages.printFatalError("Source file is empty!");
                        return false;
                    }
                    else
                    {
                        Messages.ConsoleLog("Reading file - succeeded.");
                    }
                }
                catch (Exception ex)
                {
                    Messages.printFatalError("Failed to read source file: " + ex.Message);
                    return false;
                }

                // encrypt
                string encrypted = "";
                try
                {
                    encrypted = Program.CryptoUtil.EncryptString(source, Datnik.inputPassword!);
                    if (encrypted == null)
                    {
                        Messages.printFatalError("Failed to encrypt for some reason - result is null");
                        return false;
                    }
                    else if (string.IsNullOrEmpty(encrypted))
                    {
                        Messages.printFatalError("Failed to encrypt for some reason - result is empty");
                        return false;
                    }
                    else if (string.IsNullOrWhiteSpace(encrypted))
                    {
                        Messages.printFatalError("Failed to encrypt for some reason - result is invalid");
                        return false;
                    }
                    else
                    {
                        Messages.ConsoleLog("Encrypting file - succeeded.");
                    }
                }
                catch (Exception ex)
                {
                    Messages.printFatalError("Failed to encrypt: " + ex.Message);
                    return false;
                }

                // write to file
                File.WriteAllText(Datnik.output!, encrypted);
                Messages.ConsoleLog("Writing file - succeeded.");
                return true;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (Program.LOG_STACK_TRACES)
                {
                    message += Environment.NewLine +
                        "StackTrace:" + Environment.NewLine;
                }
                Messages.printFatalError(message);
                return false;
            }
        }

        /// <summary>
        /// Decrypt source file(s)
        /// </summary>
        /// <returns>True if successful, otherwise false</returns>
        internal static bool DecryptFile()
        {
            try
            {
                // check if source file exists
                Messages.ConsoleLog("Decrypting - \"" + Datnik.input + "\"");
                if (!File.Exists(Datnik.input))
                {
                    Messages.printFatalError("File does not exist!");
                    return false;
                }

                // read cyphertext source
                string encrypted = "";
                try
                {
                    string extention = Path.GetExtension(Datnik.input);
                    if(extention.ToLower() != ".denc")
                    {
                        Messages.printWarning(
                            "File extention of encryted file is not \".denc\". It is \"" + extention + "\".", false);
                    }

                    encrypted = File.ReadAllText(Datnik.input);
                    if (string.IsNullOrWhiteSpace(encrypted))
                    {
                        Messages.printFatalError("Encrypted file is empty!");
                        return false;
                    }
                    else if (encrypted.Length == 0)
                    {
                        Messages.printFatalError("Encrypted file is empty!");
                        return false;
                    }
                    else
                    {
                        Messages.ConsoleLog("Reading file - succeeded.");
                    }
                }
                catch (Exception ex)
                {
                    Messages.printFatalError("Failed to read encrypted file: " + ex.Message);
                    return false;
                }

                // decrypt
                string decrypted = "";
                try
                {
                    decrypted = Program.CryptoUtil.DecryptString(encrypted, Datnik.inputPassword!);
                    if (encrypted == null)
                    {
                        Messages.printFatalError("Failed to decrypt for some reason - result is null");
                        return false;
                    }
                    else if (string.IsNullOrEmpty(encrypted))
                    {
                        Messages.printFatalError("Failed to decrypt for some reason - result is empty");
                        return false;
                    }
                    else if (string.IsNullOrWhiteSpace(encrypted))
                    {
                        Messages.printFatalError("Failed to decrypt for some reason - result is invalid");
                        return false;
                    }
                    else
                    {
                        Messages.ConsoleLog("Decrypting file - succeeded.");
                    }
                }
                catch (Exception ex)
                {
                    Messages.printFatalError("Failed to decrypt: " + ex.Message);
                    return false;
                }

                // write to file
                File.WriteAllText(Datnik.output!, decrypted);
                Messages.ConsoleLog("Writing file - succeeded.");
                return true;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (Program.LOG_STACK_TRACES)
                {
                    message += Environment.NewLine +
                        "StackTrace:" + Environment.NewLine;
                }
                Messages.printFatalError(message);
                return false;
            }
        }

        /// <summary>
        /// Recrypt source file(s)
        /// </summary>
        /// <returns>True if successful, otherwise false</returns>
        internal static bool RecryptFile()
        {
            try
            {
                // check if source file exists
                Messages.ConsoleLog("Recrypting - \"" + Datnik.input + "\"");
                if (!File.Exists(Datnik.input))
                {
                    Messages.printFatalError("File does not exist!");
                    return false;
                }

                // read cyphertext source
                string encrypted = "";
                try
                {
                    string extention = Path.GetExtension(Datnik.input);
                    if (extention.ToLower() != ".denc")
                    {
                        Messages.printWarning(
                            "File extention of encryted file is not \".denc\". It is \"" + extention + "\".", false);
                    }

                    encrypted = File.ReadAllText(Datnik.input);
                    if (string.IsNullOrWhiteSpace(encrypted))
                    {
                        Messages.printFatalError("Encrypted file is empty!");
                        return false;
                    }
                    else if (encrypted.Length == 0)
                    {
                        Messages.printFatalError("Encrypted file is empty!");
                        return false;
                    }
                    else
                    {
                        Messages.ConsoleLog("Reading file - succeeded.");
                    }
                }
                catch (Exception ex)
                {
                    Messages.printFatalError("Failed to read encrypted file: " + ex.Message);
                    return false;
                }

                // decrypt
                string decrypted = "";
                try
                {
                    decrypted = Program.CryptoUtil.DecryptString(encrypted, Datnik.inputPassword!);
                    if (encrypted == null)
                    {
                        Messages.printFatalError("Failed to decrypt for some reason - result is null");
                        return false;
                    }
                    else if (string.IsNullOrEmpty(encrypted))
                    {
                        Messages.printFatalError("Failed to decrypt for some reason - result is empty");
                        return false;
                    }
                    else if (string.IsNullOrWhiteSpace(encrypted))
                    {
                        Messages.printFatalError("Failed to decrypt for some reason - result is invalid");
                        return false;
                    }
                    else
                    {
                        Messages.ConsoleLog("Decrypting file - succeeded.");
                    }
                }
                catch (Exception ex)
                {
                    Messages.printFatalError("Failed to decrypt: " + ex.Message);
                    return false;
                }

                // encrypt
                string recrypted = "";
                try
                {
                    recrypted = Program.CryptoUtil.EncryptString(decrypted, Datnik.outputPassword!);
                    if (recrypted == null)
                    {
                        Messages.printFatalError("Failed to encrypt for some reason - result is null");
                        return false;
                    }
                    else if (string.IsNullOrEmpty(recrypted))
                    {
                        Messages.printFatalError("Failed to encrypt for some reason - result is empty");
                        return false;
                    }
                    else if (string.IsNullOrWhiteSpace(recrypted))
                    {
                        Messages.printFatalError("Failed to encrypt for some reason - result is invalid");
                        return false;
                    }
                    else
                    {
                        Messages.ConsoleLog("Encrypting file - succeeded.");
                    }
                }
                catch (Exception ex)
                {
                    Messages.printFatalError("Failed to encrypt: " + ex.Message);
                    return false;
                }

                // write to file
                File.WriteAllText(Datnik.output!, recrypted);
                Messages.ConsoleLog("Writing file - succeeded.");
                return true;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (Program.LOG_STACK_TRACES)
                {
                    message += Environment.NewLine +
                        "StackTrace:" + Environment.NewLine;
                }
                Messages.printFatalError(message);
                return false;
            }
        }
    }
}
