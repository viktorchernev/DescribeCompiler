//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Describe06.g4 by ANTLR 4.13.1

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
public partial class Describe06Lexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		LINE_COMMENT=1, BLOCK_COMMENT=2, NEWLINE=3, PRODUCER=4, SEPARATOR=5, TERMINATOR=6, 
		ESCAPE_ESCAPE=7, ESCAPE_PRODUCER=8, ESCAPE_SEPARATOR=9, ESCAPE_TERMINATOR=10, 
		ESCAPE_LCOMMENT=11, ESCAPE_BCOMMENT=12, DATA=13;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"LINE_COMMENT", "BLOCK_COMMENT", "NEWLINE", "PRODUCER", "SEPARATOR", "TERMINATOR", 
		"ESCAPE_ESCAPE", "ESCAPE_PRODUCER", "ESCAPE_SEPARATOR", "ESCAPE_TERMINATOR", 
		"ESCAPE_LCOMMENT", "ESCAPE_BCOMMENT", "DATA"
	};


	public Describe06Lexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public Describe06Lexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, "'->'", "','", "';'", "'\\\\'", "'\\->'", "'\\,'", 
		"'\\;'", "'\\//'", "'\\/*'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "LINE_COMMENT", "BLOCK_COMMENT", "NEWLINE", "PRODUCER", "SEPARATOR", 
		"TERMINATOR", "ESCAPE_ESCAPE", "ESCAPE_PRODUCER", "ESCAPE_SEPARATOR", 
		"ESCAPE_TERMINATOR", "ESCAPE_LCOMMENT", "ESCAPE_BCOMMENT", "DATA"
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

	public override string GrammarFileName { get { return "Describe06.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static Describe06Lexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,13,107,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,1,0,1,0,1,0,1,
		0,5,0,32,8,0,10,0,12,0,35,9,0,1,0,3,0,38,8,0,1,0,1,0,3,0,42,8,0,1,0,1,
		0,1,1,1,1,1,1,1,1,5,1,50,8,1,10,1,12,1,53,9,1,1,1,1,1,1,1,1,1,1,1,1,2,
		4,2,61,8,2,11,2,12,2,62,1,2,1,2,4,2,67,8,2,11,2,12,2,68,3,2,71,8,2,1,3,
		1,3,1,3,1,4,1,4,1,5,1,5,1,6,1,6,1,6,1,7,1,7,1,7,1,7,1,8,1,8,1,8,1,9,1,
		9,1,9,1,10,1,10,1,10,1,10,1,11,1,11,1,11,1,11,1,12,1,12,5,12,103,8,12,
		10,12,12,12,106,9,12,2,33,51,0,13,1,1,3,2,5,3,7,4,9,5,11,6,13,7,15,8,17,
		9,19,10,21,11,23,12,25,13,1,0,1,6,0,32,38,40,43,48,58,60,91,93,123,125,
		126,114,0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,
		11,1,0,0,0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,
		0,0,0,0,23,1,0,0,0,0,25,1,0,0,0,1,27,1,0,0,0,3,45,1,0,0,0,5,70,1,0,0,0,
		7,72,1,0,0,0,9,75,1,0,0,0,11,77,1,0,0,0,13,79,1,0,0,0,15,82,1,0,0,0,17,
		86,1,0,0,0,19,89,1,0,0,0,21,92,1,0,0,0,23,96,1,0,0,0,25,100,1,0,0,0,27,
		28,5,47,0,0,28,29,5,47,0,0,29,33,1,0,0,0,30,32,9,0,0,0,31,30,1,0,0,0,32,
		35,1,0,0,0,33,34,1,0,0,0,33,31,1,0,0,0,34,41,1,0,0,0,35,33,1,0,0,0,36,
		38,5,13,0,0,37,36,1,0,0,0,37,38,1,0,0,0,38,39,1,0,0,0,39,42,5,10,0,0,40,
		42,5,0,0,1,41,37,1,0,0,0,41,40,1,0,0,0,42,43,1,0,0,0,43,44,6,0,0,0,44,
		2,1,0,0,0,45,46,5,47,0,0,46,47,5,42,0,0,47,51,1,0,0,0,48,50,9,0,0,0,49,
		48,1,0,0,0,50,53,1,0,0,0,51,52,1,0,0,0,51,49,1,0,0,0,52,54,1,0,0,0,53,
		51,1,0,0,0,54,55,5,42,0,0,55,56,5,47,0,0,56,57,1,0,0,0,57,58,6,1,0,0,58,
		4,1,0,0,0,59,61,5,10,0,0,60,59,1,0,0,0,61,62,1,0,0,0,62,60,1,0,0,0,62,
		63,1,0,0,0,63,71,1,0,0,0,64,65,5,13,0,0,65,67,5,10,0,0,66,64,1,0,0,0,67,
		68,1,0,0,0,68,66,1,0,0,0,68,69,1,0,0,0,69,71,1,0,0,0,70,60,1,0,0,0,70,
		66,1,0,0,0,71,6,1,0,0,0,72,73,5,45,0,0,73,74,5,62,0,0,74,8,1,0,0,0,75,
		76,5,44,0,0,76,10,1,0,0,0,77,78,5,59,0,0,78,12,1,0,0,0,79,80,5,92,0,0,
		80,81,5,92,0,0,81,14,1,0,0,0,82,83,5,92,0,0,83,84,5,45,0,0,84,85,5,62,
		0,0,85,16,1,0,0,0,86,87,5,92,0,0,87,88,5,44,0,0,88,18,1,0,0,0,89,90,5,
		92,0,0,90,91,5,59,0,0,91,20,1,0,0,0,92,93,5,92,0,0,93,94,5,47,0,0,94,95,
		5,47,0,0,95,22,1,0,0,0,96,97,5,92,0,0,97,98,5,47,0,0,98,99,5,42,0,0,99,
		24,1,0,0,0,100,104,9,0,0,0,101,103,7,0,0,0,102,101,1,0,0,0,103,106,1,0,
		0,0,104,102,1,0,0,0,104,105,1,0,0,0,105,26,1,0,0,0,106,104,1,0,0,0,9,0,
		33,37,41,51,62,68,70,104,1,6,0,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
