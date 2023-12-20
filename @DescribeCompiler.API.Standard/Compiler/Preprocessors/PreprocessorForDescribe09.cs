using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeCompiler.Compiler.Preprocessors
{
    public class PreprocessorForDescribe09 : IDescribePreprocessor
    {
        public string ProcessSource(string value)
        {
            //we add a character before and after that we will not use,
            //in order to skip if tests to see if we are not on the first or last char
            //for null reference. The new line we keep, as it is a workaround for the
            //runaway group last comment bug
            value = "." + value + Environment.NewLine;

            //https://stackoverflow.com/questions/1615559/convert-a-unicode-string-to-an-escaped-ascii-string
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < value.Length - 1; i++)
            {
                if (value[i] > 127)
                {
                    // This character is too big for ASCII
                    string encodedValue = "&#x" + ((int)value[i]).ToString("x4") + "\\;";
                    sb.Append(encodedValue);
                }
                else
                {
                    if (value[i] == '-'
                       && value[i + 1] != '>'
                       && value[i - 1] != '\\')
                    {
                        sb.Append('\\');
                    }
                    else if (value[i] == '*'
                          && value[i + 1] != '/'
                          && value[i - 1] != '/'
                          && value[i - 1] != '\\')
                    {
                        sb.Append('\\');
                    }
                    else if (value[i] == '/'
                          && value[i + 1] != '/'
                          && value[i - 1] != '/'
                          && value[i + 1] != '*'
                          && value[i - 1] != '*'
                          && value[i - 1] != '\\')
                    {
                        sb.Append('\\');
                    }
                    else if (value[i] == '\\'
                          && value[i - 1] != '\\'
                          && value[i + 1] != '\\'
                          && value[i + 1] != '-'
                          && value[i + 1] != '*'
                          && value[i + 1] != '/'
                          && value[i + 1] != '<'
                          && value[i + 1] != '>'
                          && value[i + 1] != '['
                          && value[i + 1] != ']'
                          && value[i + 1] != '{'
                          && value[i + 1] != '}'
                          && value[i + 1] != ','
                          && value[i + 1] != ';')
                    {
                        sb.Append('\\');
                    }

                    sb.Append(value[i]);
                }
            }
            return sb.ToString();
        }
    }
}
