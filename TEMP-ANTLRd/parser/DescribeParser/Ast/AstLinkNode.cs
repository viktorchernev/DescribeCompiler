using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser.Ast
{
    public class AstLinkNode : AstNode
    {
        //OpenBracket
        public AstTextNode Url;
        public AstTextNode? Title;
        public AstTextNode? Letter;
        //CloseBracket


        public AstLinkNode(AstTextNode url)
        {
            initialize(url);
        }
        public AstLinkNode(AstTextNode url, AstSourcePosition position)
            : base(position)
        {
            initialize(url);
        }
        public AstLinkNode(AstTextNode url, AstNode parent)
            : base(parent)
        {
            initialize(url);
        }
        public AstLinkNode(AstTextNode url, AstSourcePosition position, AstNode parent)
            : base(position, parent)
        {
            initialize(url);
        }
        public AstLinkNode(AstTextNode url, AstNode parent, AstSourcePosition position)
            : base(parent, position)
        {
            initialize(url);
        }



        void initialize(AstTextNode url)
        {
            Url = url;
            Position = new AstSourcePosition(url.Position);
        }
        void initialize(AstTextNode url, AstTextNode title)
        {
            Url = url;
            Position = new AstSourcePosition(url.Position);
        }
        void initialize(List<AstTextNode> chunks)
        {
            if (chunks == null)
            {
                Chunks = new List<AstTextNode>();
                return;
            }

            Chunks = chunks;
            if (chunks.Count == 0) return;

            // calculate source position for this object
            AstSourcePosition p0 = chunks[0].Position;
            AstSourcePosition p1 = chunks[chunks.Count - 1].Position;
            if (p0 == null || p1 == null) return;

            // assign source position for this object
            AstSourcePosition pos = new AstSourcePosition();
            pos.FirstIndex = p0.FirstIndex;
            pos.FirstLine = p0.FirstLine;
            pos.FirstColumn = p0.FirstColumn;
            pos.LastIndex = p0.LastIndex;
            pos.LastLine = p0.LastLine;
            pos.LastColumn = p0.LastColumn;
            Position = pos;
        }
    }
}
