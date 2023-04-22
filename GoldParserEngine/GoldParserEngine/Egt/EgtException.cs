using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
