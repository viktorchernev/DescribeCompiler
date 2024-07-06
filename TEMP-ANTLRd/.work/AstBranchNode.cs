using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser.Ast
{
    public class AstBranchNode : AstNode
    {
        public List<AstLeafNode> Chunks;

        public AstBranchNode()
        {
            Chunks = new List<AstLeafNode>();
        }
        public AstBranchNode(SourcePosition position) 
            : base(position) { }
        public AstBranchNode(AstBranchNode parent) 
            : base(parent) { }
        public AstBranchNode(SourcePosition position, AstBranchNode parent) 
            : base(position, parent) { }
        public AstBranchNode(AstBranchNode parent, SourcePosition position) 
            : base(parent, position) { }

        public AstBranchNode(AstLeafNode chunk)
        {
            Chunks = new List<AstLeafNode>() { chunk };

            // set source position for this object
            SourcePosition pos;
            if (chunk.Position == null) pos = null;
            else pos = new SourcePosition(chunk.Position);
        }
        public AstBranchNode(AstLeafNode chunk, AstBranchNode parent)
            : base(parent)
        {
            Chunks = new List<AstLeafNode>() { chunk };

            // set source position for this object
            SourcePosition pos;
            if (chunk.Position == null) pos = null;
            else pos = new SourcePosition(chunk.Position);
        }

        public AstBranchNode(List<AstLeafNode> chunks)
        {
            if (chunks == null)
            {
                Chunks = new List<AstLeafNode>();
                return;
            }

            Chunks = chunks;
            if (chunks.Count == 0) return;

            // calculate source position for this object
            SourcePosition p0 = chunks[0].Position;
            SourcePosition p1 = chunks[chunks.Count - 1].Position;
            if (p0 == null || p1 == null) return;

            // assign source position for this object
            SourcePosition pos = new SourcePosition(p0.FirstIndex, 
                p0.FirstLine, p0.FirstColumn, p0.LastIndex, p0.LastLine, p0.LastColumn);
            Position = pos;
        }
        public AstBranchNode(List<AstLeafNode> chunks, AstBranchNode parent)
            : base(parent)
        {
            if (chunks == null)
            {
                Chunks = new List<AstLeafNode>();
                return;
            }

            Chunks = chunks;
            if (chunks.Count == 0) return;

            // calculate source position for this object
            SourcePosition p0 = chunks[0].Position;
            SourcePosition p1 = chunks[chunks.Count - 1].Position;
            if (p0 == null || p1 == null) return;

            // assign source position for this object
            SourcePosition pos = new SourcePosition(p0.FirstIndex,
                p0.FirstLine, p0.FirstColumn, p0.LastIndex, p0.LastLine, p0.LastColumn);
            Position = pos;
        }



        
        public override string ToString()
        {
            string s = "(BRANCH : ";
            for (int i = 0; i < Chunks.Count - 1; i++)
            {
                s += "\"" + Chunks[i].ToCode() + "\", ";
            }
            if(Chunks.Count > 0)
            {
                s += "\"" + Chunks[Chunks.Count -1].ToCode() + "\"";
            }
            s += ")";

            return s;
        }
        public override string ToJson()
        {
            var jsonObject = new
            {
                Chunks = this.Chunks.ConvertAll(chunk => JsonConvert.DeserializeObject(chunk.ToJson()))
            };

            return JsonConvert.SerializeObject(jsonObject);
        }
        public override string ToCode()
        {
            string s = "";
            for(int i = 0; i < Chunks.Count; i++)
            {
                s += Chunks[i].ToCode();
            }
            return s;
        }
    }
}
