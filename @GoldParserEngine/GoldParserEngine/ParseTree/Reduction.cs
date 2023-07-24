using GoldParser.Grammar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldParser.ParseTree
{
    public class Reduction
    {
		private GrammarProduction _production;
		private List<Token> _tokens = new List<Token>();
		private object _Tag;

		/// <summary>
		/// Returns the token with the specified index.
		/// </summary>
		/// <param name="index"></param>
		public Token this[int index]
		{
			get
			{
				return _tokens[index];
			}
			internal set
			{
				_tokens[index] = value;
			}
		}
		
		/// <summary>
		/// Returns the parent production.
		/// </summary>
		public GrammarProduction Production
		{
			get
			{
				return _production;
			}
			internal set
			{
				_production = value;
			}
		}

		/// <summary>
		/// Returns/sets any additional user-defined data to this object.
		/// </summary>
		public object Tag
		{
			get
			{
				return _Tag;
			}
			set
			{
				_Tag = value;
			}
		}



		public Reduction(int size)
		{
			ReDimension(size);
		}


		public object GetTokenData(int index)
		{
			return _tokens[index].Data;

		}
		public void SetTokenData(int index, object value)
		{
			_tokens[index].Data = value;
		}
		public void ReDimension(int size)
		{
			for (int i = 0; i <= size - 1; i++)
			{
				_tokens.Add(null);
			}
		}

		public void Add(Token item)
		{
			_tokens.Add(item);
		}
		public int Count()
		{
			return _tokens.Count;
		}
		public void Clear()
		{
			_tokens = new List<Token>();
		}
	}
}
//_Parent is _production
//Parent is Production