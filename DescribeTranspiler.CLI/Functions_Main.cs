using DescribeParser.Unfold;
using DescribeTranspiler.Listiary.Translators;
using DescribeTranspiler.Translators;

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
                        "Template name does not start with \"HTML_\", \"JSON_\", \"XML_\" or \"SQL_\"," +
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
                        DirectoryInfo dinfo = new DirectoryInfo(Datnik.input!);

                        SearchOption searchOption = SearchOption.AllDirectories;
                        //if (comp.PARSE_TOP_DIRECTORY_ONLY) searchOption = SearchOption.TopDirectoryOnly;

                        // get source files
                        List<string> sourceFilesDS = Directory.GetFiles(dinfo.FullName, "*.ds", searchOption).ToList();
                        List<string> sourceFilesDENC = Directory.GetFiles(dinfo.FullName, "*.denc", searchOption).ToList();
                        List<string> sourceFiles = [.. sourceFilesDS, .. sourceFilesDENC];
                        List<string> topSourceFilesDS = Directory.GetFiles(dinfo.FullName, "*.ds", SearchOption.TopDirectoryOnly).ToList();
                        List<string> topSourceFilesDENC = Directory.GetFiles(dinfo.FullName, "*.denc", SearchOption.TopDirectoryOnly).ToList();
                        List<string> topSourceFiles = [.. topSourceFilesDS, .. topSourceFilesDENC];
                        if (sourceFiles.Count() == 0)
                        {
                            Messages.printFatalError("Directory is empty");
                            return false;
                        }

                        //iterate files, set aside one that starts with dot
                        //search first in the parse dir
                        List<SourceCode> sourceCodes = new List<SourceCode>();
                        SourceCode? dotItem = null;
                        foreach(string topFile in topSourceFiles)
                        {
                            string topFileName = Path.GetFileName(topFile).ToString();
                            if (topFileName[0] == '.')
                            {
                                string code = File.ReadAllText(topFile);
                                var item = new SourceCode();
                                item.SourceText = code;
                                item.FileName = topFile;
                                dotItem = item;
                            }
                        }
                        foreach (string file in sourceFiles)
                        {
                            string fileName = Path.GetFileName(file).ToString();
                            string code = File.ReadAllText(file);
                            var item = new SourceCode();
                            item.SourceText = code;
                            item.FileName = file;

                            if (dotItem == null)
                            {
                                if(fileName[0] == '.') dotItem = item;
                                else sourceCodes.Add(item);
                            }
                            else
                            {
                                if (item.FileName == dotItem.Value.FileName) continue;
                                else sourceCodes.Add(item);
                            }
                        }
                        if (dotItem != null) sourceCodes.Insert(0, dotItem.Value);

                        //decrypt those that are .denc
                        for(int i = 0; i < sourceCodes.Count; i++)
                        {
                            var extention = Path.GetExtension(sourceCodes[i].FileName);
                            if(extention == ".denc")
                            {
                                string encrypted = sourceCodes[i].SourceText;
                                string decrypted = Program.CryptoUtil.DecryptString(encrypted, Datnik.inputPassword!);
                                SourceCode newSC = new SourceCode();
                                newSC.SourceText = decrypted;
                                newSC.FileName = sourceCodes[i].FileName;
                                sourceCodes[i] = newSC;
                            }
                        }

                        //do parse folder with that
                        r = comp.ParseStrings(sourceCodes, ref unfold);
                    }
                }

                //translate
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
                        string encryptedOutput = Program.CryptoUtil.EncryptString(result, Datnik.outputPassword!);
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
                        "StackTrace:" + ex.StackTrace + Environment.NewLine;
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
                        "StackTrace:" + ex.StackTrace + Environment.NewLine;
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
                        "StackTrace:" + ex.StackTrace + Environment.NewLine;
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
                        "StackTrace:" + ex.StackTrace + Environment.NewLine;
                }
                Messages.printFatalError(message);
                return false;
            }
        }

        /// <summary>
        /// Encrypt a folder of source file
        /// </summary>
        /// <returns>True if successful, otherwise false</returns>
        internal static bool EncryptFolder()
        {
            try
            {
                // check if source folder exists
                Messages.ConsoleLog("Encrypting - \"" + Datnik.input + "\"");
                if (!Directory.Exists(Datnik.input))
                {
                    Messages.printFatalError("Directory does not exist!");
                    return false;
                }

                // Clean directory
                if (Directory.Exists(Datnik.output))
                {
                    // Delete the directory and all its contents
                    Directory.Delete(Datnik.output, true); // 'true' deletes contents recursively
                }
                // Recreate the directory (if it doesn't exist, it will be created)
                Directory.CreateDirectory(Datnik.output!);
                Messages.ConsoleLogInfo("Output directory cleaned \"" + Datnik.output + "\".");

                // get files
                SearchOption searchOption = SearchOption.AllDirectories;
                string searchMask = "*.ds";
                var sourceFiles = Directory.GetFiles(Datnik.input, searchMask, searchOption).ToList();
                if (sourceFiles == null || sourceFiles.Count() == 0)
                {
                    Messages.printFatalError("Directory is empty!");
                    return false;
                }
                else
                {
                    Messages.ConsoleLogInfo("Directory contains " + sourceFiles.Count.ToString() + " suitable files");
                }

                for(int i = 0; i < sourceFiles.Count; i++)
                {
                    Messages.ConsoleLog("--------------------------------------------------");
                    // read plaitext source
                    string source = "";
                    try
                    {
                        source = File.ReadAllText(sourceFiles[i]);
                        if (string.IsNullOrWhiteSpace(source))
                        {
                            Messages.printFatalError("\"" + sourceFiles[i] + "\" - Source file is empty!");
                            return false;
                        }
                        else if (source.Length == 0)
                        {
                            Messages.printFatalError("\"" + sourceFiles[i] + "\" - Source file is empty!");
                            return false;
                        }
                        else
                        {
                            Messages.ConsoleLog("\"" + sourceFiles[i] + "\" - Reading file succeeded.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Messages.printFatalError("\"" + sourceFiles[i] + "\" - Failed to read source file: " + ex.Message);
                        return false;
                    }

                    // encrypt
                    string encrypted = "";
                    try
                    {
                        encrypted = Program.CryptoUtil.EncryptString(source, Datnik.inputPassword!);
                        if (encrypted == null)
                        {
                            Messages.printFatalError("\"" + sourceFiles[i] + "\" - Failed to encrypt for some reason - result is null");
                            return false;
                        }
                        else if (string.IsNullOrEmpty(encrypted))
                        {
                            Messages.printFatalError("\"" + sourceFiles[i] + "\" - Failed to encrypt for some reason - result is empty");
                            return false;
                        }
                        else if (string.IsNullOrWhiteSpace(encrypted))
                        {
                            Messages.printFatalError("\"" + sourceFiles[i] + "\" - Failed to encrypt for some reason - result is invalid");
                            return false;
                        }
                        else
                        {
                            Messages.ConsoleLog("\"" + sourceFiles[i] + "\" - Encrypting file - succeeded.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Messages.printFatalError("\"" + sourceFiles[i] + "\" - Failed to encrypt: " + ex.Message);
                        return false;
                    }

                    // write to file
                    string relativePath = Path.GetRelativePath(Datnik.input!, sourceFiles[i]);
                    string newPath = Path.Combine(Datnik.output!, relativePath);
                    newPath = Path.ChangeExtension(newPath, ".denc");
                    string? directoryPath = Path.GetDirectoryName(newPath);

                    if (directoryPath != null) Directory.CreateDirectory(directoryPath);
                    File.WriteAllText(newPath, encrypted);
                    Messages.ConsoleLog("\"" + newPath + "\" - Writing file - succeeded.");
                }

                Messages.ConsoleLog("Operation succeeded.");
                return true;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (Program.LOG_STACK_TRACES)
                {
                    message += Environment.NewLine +
                        "StackTrace:" + ex.StackTrace + Environment.NewLine;
                }
                Messages.printFatalError(message);
                return false;
            }
        }

        /// <summary>
        /// Decrypt a folder of source file
        /// </summary>
        /// <returns>True if successful, otherwise false</returns>
        internal static bool DecryptFolder()
        {
            try
            {
                // check if source folder exists
                Messages.ConsoleLog("Decrypting - \"" + Datnik.input + "\"");
                if (!Directory.Exists(Datnik.input))
                {
                    Messages.printFatalError("Directory does not exist!");
                    return false;
                }

                // Clean directory
                if (Directory.Exists(Datnik.output))
                {
                    // Delete the directory and all its contents
                    Directory.Delete(Datnik.output, true); // 'true' deletes contents recursively
                }
                // Recreate the directory (if it doesn't exist, it will be created)
                Directory.CreateDirectory(Datnik.output!);
                Messages.ConsoleLogInfo("Output directory cleaned \"" + Datnik.output + "\".");

                // get files
                SearchOption searchOption = SearchOption.AllDirectories;
                string searchMask = "*.denc";
                var encryptedFiles = Directory.GetFiles(Datnik.input, searchMask, searchOption).ToList();
                if (encryptedFiles == null || encryptedFiles.Count() == 0)
                {
                    Messages.printFatalError("Directory is empty!");
                    return false;
                }
                else
                {
                    Messages.ConsoleLogInfo("Directory contains " + encryptedFiles.Count.ToString() + " suitable files");
                }

                for (int i = 0; i < encryptedFiles.Count; i++)
                {
                    Messages.ConsoleLog("--------------------------------------------------");
                    // read encrypted source
                    string source = "";
                    try
                    {
                        source = File.ReadAllText(encryptedFiles[i]);
                        if (string.IsNullOrWhiteSpace(source))
                        {
                            Messages.printFatalError("\"" + encryptedFiles[i] + "\" - Encrypted file is empty!");
                            return false;
                        }
                        else if (source.Length == 0)
                        {
                            Messages.printFatalError("\"" + encryptedFiles[i] + "\" - Encrypted file is empty!");
                            return false;
                        }
                        else
                        {
                            Messages.ConsoleLog("\"" + encryptedFiles[i] + "\" - Reading file succeeded.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Messages.printFatalError("\"" + encryptedFiles[i] + "\" - Failed to read encrypted file: " + ex.Message);
                        return false;
                    }

                    // decrypt
                    string decrypted = "";
                    try
                    {
                        decrypted = Program.CryptoUtil.DecryptString(source, Datnik.inputPassword!);
                        if (decrypted == null)
                        {
                            Messages.printFatalError("\"" + encryptedFiles[i] + "\" - Failed to decrypt for some reason - result is null");
                            return false;
                        }
                        else if (string.IsNullOrEmpty(decrypted))
                        {
                            Messages.printFatalError("\"" + encryptedFiles[i] + "\" - Failed to decrypt for some reason - result is empty");
                            return false;
                        }
                        else if (string.IsNullOrWhiteSpace(decrypted))
                        {
                            Messages.printFatalError("\"" + encryptedFiles[i] + "\" - Failed to decrypt for some reason - result is invalid");
                            return false;
                        }
                        else
                        {
                            Messages.ConsoleLog("\"" + encryptedFiles[i] + "\" - Decrypting file - succeeded.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Messages.printFatalError("\"" + encryptedFiles[i] + "\" - Failed to decrypt: " + ex.Message);
                        return false;
                    }

                    // write to file
                    string relativePath = Path.GetRelativePath(Datnik.input!, encryptedFiles[i]);
                    string newPath = Path.Combine(Datnik.output!, relativePath);
                    newPath = Path.ChangeExtension(newPath, ".ds");
                    string? directoryPath = Path.GetDirectoryName(newPath);

                    if (directoryPath != null) Directory.CreateDirectory(directoryPath);
                    File.WriteAllText(newPath, decrypted);
                    Messages.ConsoleLog("\"" + newPath + "\" - Writing file - succeeded.");
                }

                Messages.ConsoleLog("Operation succeeded.");
                return true;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (Program.LOG_STACK_TRACES)
                {
                    message += Environment.NewLine +
                        "StackTrace:" + ex.StackTrace + Environment.NewLine;
                }
                Messages.printFatalError(message);
                return false;
            }
        }

        /// <summary>
        /// Recrypt a folder of source file
        /// </summary>
        /// <returns>True if successful, otherwise false</returns>
        internal static bool RecryptFolder()
        {
            try
            {
                // check if source folder exists
                Messages.ConsoleLog("Recrypting - \"" + Datnik.input + "\"");
                if (!Directory.Exists(Datnik.input))
                {
                    Messages.printFatalError("Directory does not exist!");
                    return false;
                }

                // Clean directory
                if (Directory.Exists(Datnik.output))
                {
                    // Delete the directory and all its contents
                    Directory.Delete(Datnik.output, true); // 'true' deletes contents recursively
                }
                // Recreate the directory (if it doesn't exist, it will be created)
                Directory.CreateDirectory(Datnik.output!);
                Messages.ConsoleLogInfo("Output directory cleaned \"" + Datnik.output + "\".");

                // get files
                SearchOption searchOption = SearchOption.AllDirectories;
                string searchMask = "*.denc";
                var encryptedFiles = Directory.GetFiles(Datnik.input, searchMask, searchOption).ToList();
                if (encryptedFiles == null || encryptedFiles.Count() == 0)
                {
                    Messages.printFatalError("Directory is empty!");
                    return false;
                }
                else
                {
                    Messages.ConsoleLogInfo("Directory contains " + encryptedFiles.Count.ToString() + " suitable files");
                }

                for (int i = 0; i < encryptedFiles.Count; i++)
                {
                    Messages.ConsoleLog("--------------------------------------------------");
                    // read encrypted source
                    string source = "";
                    try
                    {
                        source = File.ReadAllText(encryptedFiles[i]);
                        if (string.IsNullOrWhiteSpace(source))
                        {
                            Messages.printFatalError("\"" + encryptedFiles[i] + "\" - Encrypted file is empty!");
                            return false;
                        }
                        else if (source.Length == 0)
                        {
                            Messages.printFatalError("\"" + encryptedFiles[i] + "\" - Encrypted file is empty!");
                            return false;
                        }
                        else
                        {
                            Messages.ConsoleLog("\"" + encryptedFiles[i] + "\" - Reading file succeeded.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Messages.printFatalError("\"" + encryptedFiles[i] + "\" - Failed to read encrypted file: " + ex.Message);
                        return false;
                    }

                    // decrypt
                    string decrypted = "";
                    try
                    {
                        decrypted = Program.CryptoUtil.DecryptString(source, Datnik.inputPassword!);
                        if (decrypted == null)
                        {
                            Messages.printFatalError("\"" + encryptedFiles[i] + "\" - Failed to decrypt for some reason - result is null");
                            return false;
                        }
                        else if (string.IsNullOrEmpty(decrypted))
                        {
                            Messages.printFatalError("\"" + encryptedFiles[i] + "\" - Failed to decrypt for some reason - result is empty");
                            return false;
                        }
                        else if (string.IsNullOrWhiteSpace(decrypted))
                        {
                            Messages.printFatalError("\"" + encryptedFiles[i] + "\" - Failed to decrypt for some reason - result is invalid");
                            return false;
                        }
                        else
                        {
                            Messages.ConsoleLog("\"" + encryptedFiles[i] + "\" - Decrypting file - succeeded.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Messages.printFatalError("\"" + encryptedFiles[i] + "\" - Failed to decrypt: " + ex.Message);
                        return false;
                    }

                    // recrypt
                    string recrypted = "";
                    try
                    {
                        recrypted = Program.CryptoUtil.EncryptString(decrypted, Datnik.outputPassword!);
                        if (recrypted == null)
                        {
                            Messages.printFatalError("\"" + encryptedFiles[i] + "\" - Failed to encrypt for some reason - result is null");
                            return false;
                        }
                        else if (string.IsNullOrEmpty(recrypted))
                        {
                            Messages.printFatalError("\"" + encryptedFiles[i] + "\" - Failed to encrypt for some reason - result is empty");
                            return false;
                        }
                        else if (string.IsNullOrWhiteSpace(recrypted))
                        {
                            Messages.printFatalError("\"" + encryptedFiles[i] + "\" - Failed to encrypt for some reason - result is invalid");
                            return false;
                        }
                        else
                        {
                            Messages.ConsoleLog("\"" + encryptedFiles[i] + "\" - Encrypting file - succeeded.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Messages.printFatalError("\"" + encryptedFiles[i] + "\" - Failed to encrypt: " + ex.Message);
                        return false;
                    }

                    // write to file
                    string relativePath = Path.GetRelativePath(Datnik.input!, encryptedFiles[i]);
                    string newPath = Path.Combine(Datnik.output!, relativePath);
                    string? directoryPath = Path.GetDirectoryName(newPath);

                    if (directoryPath != null) Directory.CreateDirectory(directoryPath);
                    File.WriteAllText(newPath, recrypted);
                    Messages.ConsoleLog("\"" + newPath + "\" - Writing file - succeeded.");
                }

                Messages.ConsoleLog("Operation succeeded.");
                return true;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (Program.LOG_STACK_TRACES)
                {
                    message += Environment.NewLine +
                        "StackTrace:" + ex.StackTrace + Environment.NewLine;
                }
                Messages.printFatalError(message);
                return false;
            }
        }
    }
}
