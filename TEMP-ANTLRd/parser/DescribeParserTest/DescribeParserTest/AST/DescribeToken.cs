using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.AST
{
    internal class DescribeToken
    {
        public string Text
        { 
            get; 
            private set; 
        }
        public int Start
        {
            get;
            private set;
        }
        public int End
        {
            get;
            private set;
        }

        public DesctibeTokenType TokenType
        {
            get;
            private set;
        }
        public DesctibeVersion DescribeVersion
        {
            get;
            private set;
        }


        public DescribeToken(string text, int start, int end, DesctibeTokenType type, DesctibeVersion version)
        {
            Text = text;
            TokenType = type;
            DescribeVersion = version;
            Start = start;
            End = end;
        }
        public DescribeToken(ITerminalNode token, DesctibeVersion version)
        {

            DescribeVersion = version;
        }


        public override string ToString()
        {
            string message = "T(" + TokenType + "|'" + ReplaceWhitespaceE(Text) + "')";
            return message;
        }


        static string ReplaceWhitespaceE(string text)
        {
            return text.Replace(Environment.NewLine, "\\n")
                .Replace("\r", "\\r")
                .Replace("\t", "\\t");
        }
    }
}
