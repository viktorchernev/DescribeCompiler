using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.AST
{
    public enum DesctibeTokenType
    {
        LineComment,
        BlockComment,
        NewLine,
        Hyphen,
        RightArrow,                 //LeftArrow,
        Separator,
        Terminator,
        ForewardSlash,              //BackwardSlash,
        EscapeEscape,
        EscapeHyphen,
        EscapeRightArrow,
        EscapeSeparator,
        EscapeTerminator,
        EscapeLineComment,
        EscapeBlockComment,
        Data,

        EndOfFile,
        Unknown
    }
}
