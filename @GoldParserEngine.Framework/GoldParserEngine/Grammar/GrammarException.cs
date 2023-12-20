using System;

namespace GoldParser.Grammar
{
    public class GrammarException : Exception
    {
        public string Method;

        public GrammarException(string message) : base(message)
        {
            Method = "";
        }
        public GrammarException(string message, Exception inner, string method) : base(message, inner)
        {
            Method = method;
        }
    }
}
