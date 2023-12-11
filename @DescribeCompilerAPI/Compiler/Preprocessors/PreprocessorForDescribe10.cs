using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeCompiler.Compiler.Preprocessors
{
    public class PreprocessorForDescribe10 : IDescribePreprocessor
    {
        bool BiLimited = false;


        public string ProcessSource(string value)
        {
            ReadDirectives(value);

            //we add a character before and after that we will not use,
            //in order to skip if tests to see if we are not on the first or last char
            //for null reference. The new line we keep, as it is a workaround for the
            //runaway group last comment bug
            value = "." + value + Environment.NewLine + Environment.NewLine;

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < value.Length - 2; i++)
            {
                if (value[i] > 127) processNonLatin(value, sb, ref i);
                else if (value[i] == '-') processHyphen(value, sb, ref i);
                else if (value[i] == '*') processStar(value, sb, ref i);
                else if (value[i] == '/') processFSlash(value, sb, ref i);
                else if (value[i] == '\\') processBSlash(value, sb, ref i);
                else if (value[i] == '[') processSquareBracketLeft(value, sb, ref i);
                else if (value[i] == ']') processSquareBracketRight(value, sb, ref i);
                else if (value[i] == '{') processCurlyBracketLeft(value, sb, ref i);
                else if (value[i] == '}') processCurlyBracketRight(value, sb, ref i);
                else if (value[i] == '<') processArrowLeft(value, sb, ref i);
                else if (value[i] == '>') processArrowRight(value, sb, ref i);
                else if (value[i] == ',') processComma(value, sb, ref i);
                else if (value[i] == ';') processSemicolon(value, sb, ref i);
                else sb.Append(value[i]);
            }
            return sb.ToString();
        }



        // Read preprocessor directives
        void ReadDirectives(string value)
        {
            if (value.TrimStart().ToLower().StartsWith("directives") == false) return;

            try
            {
                string text = value.Split(';')[0];
                text = RemoveWhitespace(text);
                if(text.StartsWith("directives->") == false) return;

                string[] directives = text.Substring(12).TrimStart('>').Split(',');
                foreach (string directive in directives)
                {
                    string[] sep = directive.Split('<');
                    if (sep[0] == "delimiter-mode") ReadDelimiterMode(sep[sep.Length - 1]);
                }
            }
            catch { }

            //directives ->
            //      delimiter-mode <bi>,
            //      namespace <treeofall.public>;
        }
        void ReadDelimiterMode(string value)
        {
            if(value.StartsWith("bi>")) BiLimited = true;
            else if (value.StartsWith("mono>")) BiLimited = false;
            else if (value.StartsWith("2>")) BiLimited = true;
            else if (value.StartsWith("1>")) BiLimited = false;
        }
        string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }



        // Preprocess special characters
        void processNonLatin(string source, StringBuilder sb, ref int i)
        {
            // https://stackoverflow.com/questions/1615559/convert-a-unicode-string-to-an-escaped-ascii-string
            // This character is too big for ASCII
            string encodedValue = "&#x" + ((int)source[i]).ToString("x4") + "\\;";
            sb.Append(encodedValue);
        }
        void processHyphen(string source, StringBuilder sb, ref int i)
        {
            // source[i] == '-' here.
            // When we have '-' and it is not possibly to be a part of a producer
            // and is not escaped, escape it.

            if (source[i + 1] != '>' && isEscaped(source, i) == false)
            {
                sb.Append('\\');
            }
            sb.Append(source[i]);
        }
        void processStar(string source, StringBuilder sb, ref int i)
        {
            // source[i] == '*' here.
            // When we have '*' and it is not possibly to be a part of a delimited
            // comment start '/*' or delimited comment end '*/' and is not escaped,
            // escape it

            if (source[i + 1] != '/' 
                && source[i - 1] != '/' 
                && isEscaped(source, i) == false)
            {
                sb.Append('\\');
            }
            sb.Append(source[i]);
        }
        void processFSlash(string source, StringBuilder sb, ref int i)
        {
            // source[i] == '/' here.
            // When we have '/' and it is not part of a line comment start '//' or delimited
            // comment start '/*' or delimited comment end '*/' and is not escaped, escape it.

            if (source[i + 1] != '/'
                && source[i - 1] != '/'
                && source[i + 1] != '*'
                && source[i - 1] != '*'
                && isEscaped(source, i) == false)
            {
                sb.Append('\\');
            }
            sb.Append(source[i]);
        }
        void processBSlash(string source, StringBuilder sb, ref int i)
        {
            // source[i] == '\' here.
            // When we have '\' and it is not part of an escape sequence, escape it.

            if (source[i + 1] != '\\'
                && source[i + 1] != '-'
                && source[i + 1] != '*'
                && source[i + 1] != '/'
                && source[i + 1] != '<'
                && source[i + 1] != '>'
                && source[i + 1] != '['
                && source[i + 1] != ']'
                && source[i + 1] != '{'
                && source[i + 1] != '}'
                && source[i + 1] != ','
                && source[i + 1] != ';'
                && isEscapingEscaper(source, i) == false
                && isEscaped(source, i) == false)
            {
                sb.Append('\\');
            }
            sb.Append(source[i]);
        }

        // start BiLimited
        void processSquareBracketLeft(string source, StringBuilder sb, ref int i)
        {
            if (BiLimited)
            {
                // source[i] == '[' here.
                // When we find '[' we will either escape it or double it or do nothing.
                // If the symbol before and the symbol after is not also '[' or an
                // escape sequence, we escape it. Otherwise, we do nothing.

                if ((source[i - 1] != '[' || isEscaped(source, i - 1))
                    && source[i + 1] != '['
                    && isEscaped(source, i) == false)
                {
                    // if we have an alone symbol, and we are using double symbols (BiLimited)
                    // then we escape it, otherwise we double it
                    sb.Append('\\');
                }
                sb.Append(source[i]);
            }
            else
            {
                if (isEscaped(source, i) == false)
                {
                    sb.Append('[');
                }
                sb.Append(source[i]);
            }
        }
        void processSquareBracketRight(string source, StringBuilder sb, ref int i)
        {
            if (BiLimited)
            {
                // source[i] == ']' here.
                // When we find ']' we will either escape it or double it or do nothing.
                // If the symbol before and the symbol after is not also ']' or an
                // escape sequence, we escape it. Otherwise, we do nothing.

                if ((source[i - 1] != ']' || isEscaped(source, i - 1))
                    && source[i + 1] != ']'
                    && isEscaped(source, i) == false)
                {
                    // if we have an alone symbol, and we are using double symbols (BiLimited)
                    // then we escape it, otherwise we double it
                    sb.Append('\\');
                }
                sb.Append(source[i]);
            }
            else
            {
                if (isEscaped(source, i) == false)
                {
                    sb.Append(']');
                }
                sb.Append(source[i]);
            }
        }
        void processCurlyBracketLeft(string source, StringBuilder sb, ref int i)
        {
            if (BiLimited)
            {
                // source[i] == '{' here.
                // When we find '{' we will either escape it or double it or do nothing.
                // If the symbol before and the symbol after is not also '{' or an
                // escape sequence, we escape it. Otherwise, we do nothing.

                if ((source[i - 1] != '{' || isEscaped(source, i - 1))
                    && source[i + 1] != '{'
                    && isEscaped(source, i) == false)
                {
                    // if we have an alone symbol, and we are using double symbols (BiLimited)
                    // then we escape it, otherwise we double it
                    sb.Append('\\');
                }
                sb.Append(source[i]);
            }
            else
            {
                if (isEscaped(source, i) == false)
                {
                    sb.Append('{');
                }
                sb.Append(source[i]);
            }
        }
        void processCurlyBracketRight(string source, StringBuilder sb, ref int i)
        {
            if (BiLimited)
            {
                // source[i] == '}' here.
                // When we find '}' we will either escape it or double it or do nothing.
                // If the symbol before and the symbol after is not also '}' or an
                // escape sequence, we escape it. Otherwise, we do nothing.

                if ((source[i - 1] != '}' || isEscaped(source, i - 1))
                && source[i + 1] != '}'
                && isEscaped(source, i) == false)
                {
                    // if we have an alone symbol, and we are using double symbols (BiLimited)
                    // then we escape it, otherwise we double it
                    sb.Append('\\');
                }
                sb.Append(source[i]);
            }
            else
            {
                if(isEscaped(source, i) == false)
                {
                    sb.Append('}');
                }
                sb.Append(source[i]);
            }
        }
        void processArrowLeft(string source, StringBuilder sb, ref int i)
        {
            if (BiLimited)
            {
                // source[i] == '<' here.
                // When we find '<' we will either escape it or double it or do nothing.
                // If the symbol before and the symbol after is not also '<' or an
                // escape sequence, we escape it. Otherwise, we do nothing.

                if (((source[i - 1] != '<' || isEscaped(source, i - 1))
                    && source[i + 1] != '<'
                    && isEscaped(source, i) == false)
                        || (source[i + 1] == '<' && source[i + 2] == '<'))
                {
                    // if we have an alone symbol, and we are using double symbols (BiLimited)
                    // then we escape it, otherwise we double it
                    sb.Append('\\');
                }
                else if (BiLimited == false)
                {
                    sb.Append('<');
                }
                sb.Append(source[i]);
            }
            else
            {
                if (isEscaped(source, i) == false)
                {
                    sb.Append('<');
                }
                sb.Append(source[i]);
            }
        }
        void processArrowRight(string source, StringBuilder sb, ref int i)
        {
            if (BiLimited)
            {
                // source[i] == '>' here.
                // When we find '>' we will either escape it or double it or do nothing.

                // If the symbol before or after is also '>', or current symbol is already
                // escaped, we do nothing.
                if ((source[i - 1] == '>' && isEscaped(source, i - 1) == false)
                    || source[i + 1] == '>'
                    || isEscaped(source, i))
                {
                    //do nothing 
                    //unles triple. however, we are not allowed to have text after a tag
                    if (source[i - 2] == '>' && source[i - 1] == '>' && isEscaped(source, i - 2) == false) sb.Append('\\');
                }

                // If the symbol before is '-' and the symbol after is either a new line
                // ('\n' or '\r') or whitespace(s) followed by a new line or a line comment,
                // or a delimited comment(s) followed by new line, we double the sign by
                // adding an extra '>' symbol
                else if (source[i - 1] == '-' && isEscaped(source, i - 1) == false)
                {
                    if (isLineEndingWithStar(source, i)) sb.Append('>');
                    else
                    {
                        sb.Insert(sb.Length - 1, '\\');
                        sb.Append('\\');
                    }
                }

                // otherwise we escape
                else
                {
                    // if we have an alone symbol, and we are using double symbols (BiLimited)
                    // then we escape it, otherwise we double it
                    if (BiLimited) sb.Append('\\');
                    else sb.Append('>');
                }

                // append actual symbol
                sb.Append(source[i]);
            }
            else
            {
                if (isEscaped(source, i) == false) sb.Append('>');

                // append actual symbol
                sb.Append(source[i]);
            }

        }
        // end BiLimited

        void processComma(string source, StringBuilder sb, ref int i)
        {
            // source[i] == ',' here.
            // When we find ',' we will either escape it or double it or do nothing.

            // If the symbol before or after is also ',', or current symbol is already
            // escaped, we do nothing.
            if ((source[i - 1] == ',' && isEscaped(source, i - 1) == false)
                || source[i + 1] == ','
                || isEscaped(source, i))
            {
                //do nothing
            }

            // If the symbol after is either a new line ('\n' or '\r') or whitespace(s)
            // followed by a new line or a line comment, or a delimited comment(s)
            // followed by new line, we double the sign by adding an extra ',' symbol.
            // Otherwise we escape.
            else if (isLineEndingWithStar(source, i)) sb.Append(',');
            else sb.Append('\\');

            // append actual symbol
            sb.Append(source[i]);
        }
        void processSemicolon(string source, StringBuilder sb, ref int i)
        {
            // source[i] == ';' here.
            // When we find ';' we will either escape it or double it or do nothing.

            // If the symbol before or after is also ';', or current symbol is already
            // escaped, we do nothing.
            if ((source[i - 1] == ';' && isEscaped(source, i - 1) == false)
                || source[i + 1] == ';'
                || isEscaped(source, i))
            {
                //do nothing
            }

            // If the symbol after is either a new line ('\n' or '\r') or whitespace(s)
            // followed by a new line or a line comment, or a delimited comment(s)
            // followed by new line, we double the sign by adding an extra ',' symbol.
            // Otherwise we escape.
            else if (isLineEndingWithStar(source, i)) sb.Append(';');
            else sb.Append('\\');

            // append actual symbol
            sb.Append(source[i]);
        }


        bool isEscaped(string source, int i)
        {
            int count = 0;
            for (int j = i - 1; j > -1; j--)
            {
                if (source[j] == '\\') count++;
                else break;
            }
            return (count % 2) > 0;
        }
        bool isEscapingEscaper(string source, int i)
        {
            int count = 0;
            for (int j = i + 1; j < source.Length; j++)
            {
                if (source[j] == '\\') count++;
                else break;
            }
            return (count % 2) > 0;
        }
        bool isLineEnding(string source, int i)
        {
            for (int j = i + 1; j < source.Length; j++)
            {
                // We have Windows-style new line, so yes,
                // the character we are testing is line ending.
                if (source[j] == '\r') return true;
                else if (source[j] == '\n') return true;

                // We have a whitespace char, so we continue to search
                else if (char.IsWhiteSpace(source[j])) continue;

                // We have line comment, so yes,
                // the character we are testing is line ending.
                else if (source[j] == '/' && j < source.Length - 1 && source[j + 1] == '/') return true;

                // We have a non-whitespace char that is not the start of a comment,
                // so no, the character we are testing is not line ending.
                else return false;
            }

            // Loop did not execute even once, so the character
            // we are testing must be file ending, so yes
            return true;
        }
        bool isLineEndingWithStar(string source, int i)
        {
            // This is same as isLineEnding, but with star comments
            // accounted for

            bool inDelimitedComment = false;
            for (int j = i + 1; j < source.Length; j++)
            {
                if(inDelimitedComment == false)
                {
                    // We have Windows-style new line, so yes,
                    // the character we are testing is line ending.
                    if (source[j] == '\r') return true;
                    else if (source[j] == '\n') return true;

                    // We have a whitespace char, so we continue to search
                    else if (char.IsWhiteSpace(source[j])) continue;

                    // We have line comment, so yes,
                    // the character we are testing is line ending.
                    else if (source[j] == '/' && j < source.Length - 1 && source[j + 1] == '/') return true;

                    // We encounter a delimited comment start
                    else if (source[j] == '/' && j < source.Length - 1 && source[j + 1] == '*')
                    {
                        inDelimitedComment = true;
                    }

                    // We have a non-whitespace char that is not the start of a comment,
                    // so no, the character we are testing is not line ending.
                    else return false;
                }
                else
                {
                    if (source[j] == '*' && j < source.Length - 1 && source[j + 1] == '/')
                    {
                        inDelimitedComment = false;
                    }
                }
            }

            // Loop did not execute even once, or we are in a comment,
            // so the character we are testing must be file ending, yes
            return true;
        }
    }
}
