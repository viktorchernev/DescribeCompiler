﻿using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeTranspiler.Preprocessors
{
    /// <summary>
    /// A preprocessor for Describe 0.6 source code.
    /// </summary>
    public class PreprocessorFor06 : IDescribePreprocessor
    {
        private DescribeCompiler _Compiler;


        /// <summary>
        /// Preprocess Describe 0.6 source code
        /// </summary>
        /// <param name="value">The source code string to be preprocessed</param>
        /// <returns>The preprocessed source code string</returns>
        public string ProcessSource(string text)
        {
            int len = readDirectives(text);
            if (len > 0)
            {
                text = text.Substring(len);
                text = text.TrimStart();
            }

            AntlrInputStream inputstream = new AntlrInputStream(text);
            Describe06Lexer lexer = new Describe06Lexer(inputstream);
            CommonTokenStream tokenstream = new CommonTokenStream(lexer);
            tokenstream.Fill();

            //auto-closer
            bool wasHyphen = false;
            int counter = 0;
            var tokenList = tokenstream.GetTokens();
            foreach (var token in tokenList)
            {
                int tokenType = token.Type;
                string type = GetTokenType(tokenType);
                if (type == "HYPHEN") wasHyphen = true;
                else
                {
                    if (type == "RIGHT_ARROW" && wasHyphen) counter++;
                    else if (type == "TERMINATOR") counter--;
                    wasHyphen = false;
                }
            }

            //we want to be creating tokens `Antlr4.Runtime.CommonToken` and passing
            //the same token list as token stream or smth, and not having to run the
            //lexer again later on.
            //var li = tokenList[26];
            //Type t = li.GetType();
            //var options = new JsonSerializerOptions { WriteIndented = true };
            //string json = JsonSerializer.Serialize(t, options);
            //var tokenList = tokenstream.GetTokens();
            //int index = GetTokenTypeIndex("TERMINATOR");

            //insert at correct index.
            //we do this because there might be a thrilling comment in our file.
            if (counter < 1) return text;
            string tail = new string(';', counter);
            int insertionIndex = tokenList[tokenList.Count - 2].StopIndex;
            string output = text;
            if (insertionIndex == text.Length - 1) output += tail;
            else output = output.Insert(insertionIndex + 1, tail);
            return output;
        }
        int readDirectives(string value)
        {
            if (value.TrimStart().ToLower().StartsWith("directives") == false) return 0;

            try
            {
                string text = value.Split(';')[0];
                int length = text.Length + 1;
                text = RemoveWhitespace(text);
                if (text.StartsWith("directives->") == false) return 0;

                string[] directives = text.Substring(12).TrimStart('>').Split(',');
                foreach (string directive in directives)
                {
                    string[] sep = directive.Split('<');
                    if (sep[0] == "language-version") readLanguageVersion(sep[sep.Length - 1]);
                    else if (sep[0] == "namespace") readNamespace(sep[sep.Length - 1]);
                }

                return length;
            }
            catch { return -1; }
        }
        void readLanguageVersion(string value)
        {
            if (value.StartsWith("0.6>")) _Compiler.LanguageVersion = DescribeVersionNumber.Version06;
            else if (value.StartsWith("0.7>")) _Compiler.LanguageVersion = DescribeVersionNumber.Version07;
            else if (value.StartsWith("0.8>")) _Compiler.LanguageVersion = DescribeVersionNumber.Version08;
            else if (value.StartsWith("0.9>")) _Compiler.LanguageVersion = DescribeVersionNumber.Version09;
            else if (value.StartsWith("1.0>")) _Compiler.LanguageVersion = DescribeVersionNumber.Version10;
            else if (value.StartsWith("1.1>")) _Compiler.LanguageVersion = DescribeVersionNumber.Version11;
        }
        void readNamespace(string value)
        {
            string name = value.Split('>')[0];
            name = name.Trim();
            _Compiler.CurrentJob.LastNamespace = name;
        }


        /// <summary>
        /// Ctor. Preprocessor dirrectives do set some compiler options.
        /// This is why we need access to the compiler instance for this preprocessor.
        /// </summary>
        /// <param name="compiler">The compiler for the preprocessor.</param>
        public PreprocessorFor06(DescribeCompiler compiler)
        {
            _Compiler = compiler;
        }


        string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
        static string GetTokenType(int tokenType)
        {
            //an alternative (possibly slower)
            //another alternative is to manually thanslate those values
            //in a switch statement, with values we can know by looking
            //in the generated lexer source code. However, the problem
            //is that it won't universal like its now.
            return Describe06Lexer.DefaultVocabulary.GetSymbolicName(tokenType);
        }
    }
}
