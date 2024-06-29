using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser.Ast
{
    public class AstDecoratorNode : AstNode
    {
        public List<AstTextNode> Chunks;


        public AstDecoratorNode()
        {
            initialize();
        }
        public AstDecoratorNode(AstSourcePosition position)
            : base(position)
        {
            initialize();
        }
        public AstDecoratorNode(AstNode parent)
            : base(parent)
        {
            initialize();
        }
        public AstDecoratorNode(AstSourcePosition position, AstNode parent)
            : base(position, parent)
        {
            initialize();
        }
        public AstDecoratorNode(AstNode parent, AstSourcePosition position)
            : base(parent, position)
        {
            initialize();
        }

        public AstDecoratorNode(AstTextNode chunk)
        {
            initialize(chunk);
        }
        public AstDecoratorNode(AstTextNode chunk, AstSourcePosition position)
            : base(position)
        {
            initialize(chunk);
        }
        public AstDecoratorNode(AstTextNode chunk, AstNode parent)
            : base(parent)
        {
            initialize(chunk);
        }
        public AstDecoratorNode(AstTextNode chunk, AstSourcePosition position, AstNode parent)
            : base(position, parent)
        {
            initialize(chunk);
        }
        public AstDecoratorNode(AstTextNode chunk, AstNode parent, AstSourcePosition position)
            : base(parent, position)
        {
            initialize(chunk);
        }

        public AstDecoratorNode(List<AstTextNode> chunks)
        {
            initialize(chunks);
        }
        public AstDecoratorNode(List<AstTextNode> chunks, AstSourcePosition position)
            : base(position)
        {
            initialize(chunks);
        }
        public AstDecoratorNode(List<AstTextNode> chunks, AstNode parent)
            : base(parent)
        {
            initialize(chunks);
        }
        public AstDecoratorNode(List<AstTextNode> chunks, AstSourcePosition position, AstNode parent)
            : base(position, parent)
        {
            initialize(chunks);
        }
        public AstDecoratorNode(List<AstTextNode> chunks, AstNode parent, AstSourcePosition position)
            : base(parent, position)
        {
            initialize(chunks);
        }

        void initialize()
        {
            Chunks = new List<AstTextNode>();
        }
        void initialize(AstTextNode chunk)
        {
            Chunks = new List<AstTextNode>() { chunk };
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
