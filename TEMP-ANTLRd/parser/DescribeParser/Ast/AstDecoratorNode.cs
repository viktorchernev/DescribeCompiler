using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstDecoratorNode
    {
        public List<string> Values
        { 
            get; 
            private set; 
        }
        public string Name
        { 
            get
            {
                return Values[0];
            }
        }
        public string Value
        {
            get;
            internal set;
        }


        public AstDecoratorNode(string name)
        {
            Values = new List<string>() { name };
        }
        public AstDecoratorNode(string name, string value)
        {
            Values = new List<string>() { name, value };
        }
        public AstDecoratorNode(string name, List<string> values)
        {
            Values = new List<string>() { name };
            Values.AddRange(values);
        }
    }
}
