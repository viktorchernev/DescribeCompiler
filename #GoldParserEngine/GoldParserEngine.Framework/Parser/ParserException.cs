using System;

namespace GoldParser.Parser
{
    public class ParserException : Exception
    {
        internal string Method;

        internal ParserException(string message) : base(message)
        {
            Method = "";
        }
        internal ParserException(string message, Exception inner, string method) : base(message, inner)
        {
            Method = method;
        }
    }
}
