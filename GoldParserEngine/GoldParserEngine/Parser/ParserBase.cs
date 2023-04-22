using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GoldParser.Grammar;


namespace GoldParser.Parser
{
	public class ParserBase
    {
        private const string _aboutString = "GOLD Parser Engine; Version 5.0; (Refactored)";

        protected GrammarTables _grammar;
        protected bool _tablesLoaded;

		private TextReader _source;
		private string _sourcePath;



		/// <summary>
		/// Library name and version.
		/// </summary>
		public string About
		{
			get
			{
				return _aboutString;
			}
		}



		/// <summary>
		/// Check if parse tables were loaded.
		/// </summary>
		internal bool TablesLoaded
        {
            get
            {
                return _tablesLoaded;
            }
            set
            {
                _tablesLoaded = value;
            }
        }

		/// <summary>
		/// Returns information about the current grammar.
		/// </summary>
		internal GrammarProperties GrammarInfo
        {
            get
            {
                return _grammar.Properties;
            }
        }

		/// <summary>
		/// Returns a list of Symbols recognized by the grammar.
		/// </summary>
		internal GrammarSymbol[] SymbolTable
        {
            get
            {
				return _grammar.Symbols;
			}
        }

		/// <summary>
		/// Returns a list of Productions recognized by the grammar.
		/// </summary>
		internal GrammarProduction[] ProductionTable
        {
            get
            {
				return _grammar.Productions;
			}
        }



		/// <summary>
		/// Check if file for parsing have been opened
		/// </summary>
		internal bool HaveSourcePath
        {
			get
            {
				if(string.IsNullOrEmpty(_sourcePath))
                {
					return false;
                }
				return true;
            }
        }

		/// <summary>
		/// Path of source file to be parsed
		/// </summary>
		internal string SourcePath
		{
			get
			{
				return _sourcePath;
			}
			set
			{
				_sourcePath = value;
			}
		}



		/// <summary>
		/// Ctor.
		/// </summary>
		public ParserBase()
        {
			_tablesLoaded = false;
		}



		/// <summary>
		/// Opens a string for parsing.
		/// </summary>
		/// <param name="Text">The string to be parsed</param>
		/// <returns>true if successful</returns>
		internal bool OpenFile(string text)
		{
			try
            {
				StringReader reader = new StringReader(text);
				return OpenFile(reader);
			}
			catch (Exception ex)
            {
				throw new ParserException(ex.Message, ex, "OpenFile");
            }
		}

		/// <summary>
		/// Opens a text stream for parsing.
		/// </summary>
		/// <param name="Reader">The TextReader stream to be parsed</param>
		/// <returns>Always true</returns>
		public bool OpenFile(TextReader Reader)
		{
			_source = Reader;
			return true;
		}



		/// <summary>
		/// Loads parse tables from the specified filename.
		/// Only EGT (version 5.0) is supported.
		/// </summary>
		/// <param name="Path">
		/// Path to an EGT file containing grammar tables
		/// </param>
		/// <returns>true if successful</returns>
		public bool LoadTables(string filepath)
		{
			try
			{
				Stream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
				BinaryReader reader = new BinaryReader(stream);
				return LoadTables(reader);
			}
			catch (Exception ex)
			{
				_tablesLoaded = false;
				throw new ParserException(ex.Message, ex, "LoadTables");
			}
		}

		/// <summary>
		/// Loads parse tables from the specified BinaryReader.
		/// Only EGT (version 5.0) is supported.
		/// </summary>
		/// <param name="Reader">
		/// A binary reader to the data of EGT file 
		/// containing grammar tables
		/// </param>
		/// <returns>true if successful</returns>
		public bool LoadTables(BinaryReader reader)
		{
			try
			{
				List<Egt.EgtRecord> records = Egt.EgtContentReager.ReadFileRecords(reader);
				_grammar = GrammarContentReader.ReadGrammar(records);
				reader.Close();
				_tablesLoaded = true;
				return true;
			}
			catch (ParserException ex)
			{
				_tablesLoaded = false;
				throw new ParserException(ex.Message, ex, "LoadTables");
			}
		}
	}
}