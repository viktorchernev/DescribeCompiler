using System;

namespace GoldParser.Egt
{
    public class EgtException : Exception
    {
        public string Method;

        public EgtException(string message) : base(message)
        {
            Method = "";
        }
        public EgtException(string message, Exception inner, string method) : base(message, inner)
        {
            Method = method;
        }
    }
}
