using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
