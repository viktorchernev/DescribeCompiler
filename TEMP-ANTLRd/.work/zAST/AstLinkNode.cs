using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public class AstLinkNode
    {
        public string Url
        { 
            get;
            internal set; 
        }
        public string? Title
        {
            get;
            internal set;
        }
        public char? Letter
        {
            get;
            internal set;
        }


        public AstLinkNode(string url)
        {
            Url = url;
            Title = null;
            Letter = null;
        }
        public AstLinkNode(string url, string title)
        {
            Url = url;
            Title = title;
            if(string.IsNullOrEmpty(title) || string.IsNullOrWhiteSpace(title))
            {
                Letter = null;
            }
            Letter = title[0];
        }
        public AstLinkNode(string url, string title, char letter)
        {
            Url = url;
            Title = title;
            Letter = letter;
        }
    }
}
