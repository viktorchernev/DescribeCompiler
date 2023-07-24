using GoldParser.Grammar;
using GoldParser.ParseTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldParser
{
    public static class Logging
    {
		public static string LOG;


		static Logging()
        {
			LOG = "";
        }


		public static void Log(string s)
        {
			Console.WriteLine(s);
			LOG += s + Environment.NewLine;
        }
		public static string GetTokenLogParagraph(Token t)
		{
			string s = "TOKEN" + Environment.NewLine;
			s += "Data:           " + t.Data.ToString() + Environment.NewLine;
			s += "Type:           " + t.SymbolType.ToString() + Environment.NewLine;
			s += "State:          " + t.State.ToString() + Environment.NewLine;
			s += "Position:       " + t.Position.Line.ToString() + "," + t.Position.Column.ToString();
			s += Environment.NewLine + Environment.NewLine;

			return s;
		}
		public static string GetTokenLogLine(Token t)
		{
			string s = 
				"TOKEN: Data: \"" + t.Data.ToString() + 
				"\"; Type: {" + t.SymbolType.ToString() + 
				"}; State: " + t.State.ToString() + 
				"; Position: " + t.Position.Line.ToString() + "," + t.Position.Column.ToString();

			return s;
		}
		public static string GetSymbolLogLine(GrammarSymbol symbol)
		{
			string group = "null";
			if (symbol.Group != null) group = symbol.Group.TableIndex.ToString();

			string s =
				"SYMBOL: Name: \"" + symbol.Name.ToString() +
				"\"; Type: {" + symbol.Type.ToString() +
				"}; Table Index: " + symbol.TableIndex.ToString() +
				"; Group Index: " + group;

			return s;
		}
		public static string GetLRActionLogLine(GrammarLRAction action)
		{
			if (action == null) return "LR_ACTION: null";

			string s =
				"LR_ACTION: Type: {" + action.Type.ToString() +
				"}; Value: " + action.Value.ToString();

			return s;
		}
	}
}
