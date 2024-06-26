//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Describe061.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public partial class Describe061Lexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		LINE_COMMENT=1, BLOCK_COMMENT=2, NEWLINE=3, HYPHEN=4, RIGHT_ARROW=5, SEPARATOR=6, 
		TERMINATOR=7, FIRWARD_SLASH=8, ESCAPE_ESCAPE=9, ESCAPE_HYPHEN=10, ESCAPE_RIGHT_ARROW=11, 
		ESCAPE_SEPARATOR=12, ESCAPE_TERMINATOR=13, ESCAPE_LCOMMENT=14, ESCAPE_BCOMMENT=15, 
		DATA=16;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"LINE_COMMENT", "BLOCK_COMMENT", "NEWLINE", "HYPHEN", "RIGHT_ARROW", "SEPARATOR", 
		"TERMINATOR", "FIRWARD_SLASH", "ESCAPE_ESCAPE", "ESCAPE_HYPHEN", "ESCAPE_RIGHT_ARROW", 
		"ESCAPE_SEPARATOR", "ESCAPE_TERMINATOR", "ESCAPE_LCOMMENT", "ESCAPE_BCOMMENT", 
		"DATA_CHAR", "DATA"
	};


	public Describe061Lexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public Describe061Lexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, "'-'", "'>'", "','", "';'", "'/'", "'\\\\'", "'\\-'", 
		"'\\>'", "'\\,'", "'\\;'", "'\\//'", "'\\/*'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "LINE_COMMENT", "BLOCK_COMMENT", "NEWLINE", "HYPHEN", "RIGHT_ARROW", 
		"SEPARATOR", "TERMINATOR", "FIRWARD_SLASH", "ESCAPE_ESCAPE", "ESCAPE_HYPHEN", 
		"ESCAPE_RIGHT_ARROW", "ESCAPE_SEPARATOR", "ESCAPE_TERMINATOR", "ESCAPE_LCOMMENT", 
		"ESCAPE_BCOMMENT", "DATA"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Describe061.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static Describe061Lexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,16,120,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,1,0,1,0,1,0,1,0,5,0,40,8,0,10,0,12,0,43,9,0,1,
		0,3,0,46,8,0,1,0,1,0,3,0,50,8,0,1,0,1,0,1,1,1,1,1,1,1,1,5,1,58,8,1,10,
		1,12,1,61,9,1,1,1,1,1,1,1,1,1,1,1,1,2,4,2,69,8,2,11,2,12,2,70,1,2,1,2,
		4,2,75,8,2,11,2,12,2,76,3,2,79,8,2,1,3,1,3,1,4,1,4,1,5,1,5,1,6,1,6,1,7,
		1,7,1,8,1,8,1,8,1,9,1,9,1,9,1,10,1,10,1,10,1,11,1,11,1,11,1,12,1,12,1,
		12,1,13,1,13,1,13,1,13,1,14,1,14,1,14,1,14,1,15,1,15,1,16,4,16,117,8,16,
		11,16,12,16,118,2,41,59,0,17,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,9,19,
		10,21,11,23,12,25,13,27,14,29,15,31,0,33,16,1,0,1,6,0,42,42,44,45,47,47,
		59,60,62,62,92,92,126,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,
		0,9,1,0,0,0,0,11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,
		0,0,0,0,21,1,0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,
		0,33,1,0,0,0,1,35,1,0,0,0,3,53,1,0,0,0,5,78,1,0,0,0,7,80,1,0,0,0,9,82,
		1,0,0,0,11,84,1,0,0,0,13,86,1,0,0,0,15,88,1,0,0,0,17,90,1,0,0,0,19,93,
		1,0,0,0,21,96,1,0,0,0,23,99,1,0,0,0,25,102,1,0,0,0,27,105,1,0,0,0,29,109,
		1,0,0,0,31,113,1,0,0,0,33,116,1,0,0,0,35,36,5,47,0,0,36,37,5,47,0,0,37,
		41,1,0,0,0,38,40,9,0,0,0,39,38,1,0,0,0,40,43,1,0,0,0,41,42,1,0,0,0,41,
		39,1,0,0,0,42,49,1,0,0,0,43,41,1,0,0,0,44,46,5,13,0,0,45,44,1,0,0,0,45,
		46,1,0,0,0,46,47,1,0,0,0,47,50,5,10,0,0,48,50,5,0,0,1,49,45,1,0,0,0,49,
		48,1,0,0,0,50,51,1,0,0,0,51,52,6,0,0,0,52,2,1,0,0,0,53,54,5,47,0,0,54,
		55,5,42,0,0,55,59,1,0,0,0,56,58,9,0,0,0,57,56,1,0,0,0,58,61,1,0,0,0,59,
		60,1,0,0,0,59,57,1,0,0,0,60,62,1,0,0,0,61,59,1,0,0,0,62,63,5,42,0,0,63,
		64,5,47,0,0,64,65,1,0,0,0,65,66,6,1,0,0,66,4,1,0,0,0,67,69,5,10,0,0,68,
		67,1,0,0,0,69,70,1,0,0,0,70,68,1,0,0,0,70,71,1,0,0,0,71,79,1,0,0,0,72,
		73,5,13,0,0,73,75,5,10,0,0,74,72,1,0,0,0,75,76,1,0,0,0,76,74,1,0,0,0,76,
		77,1,0,0,0,77,79,1,0,0,0,78,68,1,0,0,0,78,74,1,0,0,0,79,6,1,0,0,0,80,81,
		5,45,0,0,81,8,1,0,0,0,82,83,5,62,0,0,83,10,1,0,0,0,84,85,5,44,0,0,85,12,
		1,0,0,0,86,87,5,59,0,0,87,14,1,0,0,0,88,89,5,47,0,0,89,16,1,0,0,0,90,91,
		5,92,0,0,91,92,5,92,0,0,92,18,1,0,0,0,93,94,5,92,0,0,94,95,5,45,0,0,95,
		20,1,0,0,0,96,97,5,92,0,0,97,98,5,62,0,0,98,22,1,0,0,0,99,100,5,92,0,0,
		100,101,5,44,0,0,101,24,1,0,0,0,102,103,5,92,0,0,103,104,5,59,0,0,104,
		26,1,0,0,0,105,106,5,92,0,0,106,107,5,47,0,0,107,108,5,47,0,0,108,28,1,
		0,0,0,109,110,5,92,0,0,110,111,5,47,0,0,111,112,5,42,0,0,112,30,1,0,0,
		0,113,114,8,0,0,0,114,32,1,0,0,0,115,117,3,31,15,0,116,115,1,0,0,0,117,
		118,1,0,0,0,118,116,1,0,0,0,118,119,1,0,0,0,119,34,1,0,0,0,9,0,41,45,49,
		59,70,76,78,118,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
