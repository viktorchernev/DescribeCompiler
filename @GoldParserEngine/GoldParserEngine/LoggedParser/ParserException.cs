using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldParser.LoggedParser
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
