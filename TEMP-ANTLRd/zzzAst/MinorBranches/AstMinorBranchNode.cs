using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DescribeParser.Ast
{
    public class AstMinorBranchNode : AstBranchNode<AstTokenNode>
    {
        public override List<AstTokenNode> Chunks
        {
            get;
            set;
        }


        public AstMinorBranchNode()
        {
            Chunks = new List<AstTokenNode>();
        }
        public AstMinorBranchNode(SourcePosition position) 
            : base(position)
        {
            Chunks = new List<AstTokenNode>();
        }
        public AstMinorBranchNode(AstMinorBranchNode parent) 
            : base(parent)
        {
            Chunks = new List<AstTokenNode>();
        }
        public AstMinorBranchNode(SourcePosition position, AstMinorBranchNode parent) 
            : base(position, parent)
        {
            Chunks = new List<AstTokenNode>();
        }
        public AstMinorBranchNode(AstMinorBranchNode parent, SourcePosition position) 
            : base(parent, position) 
        {
            Chunks = new List<AstTokenNode>();
        }

        public AstMinorBranchNode(AstTokenNode chunk)
        {
            Chunks = new List<AstTokenNode>() { chunk };

            // set source position for this object
            SourcePosition pos;
            if (chunk.Position == null) pos = null;
            else pos = new SourcePosition(chunk.Position);
        }
        public AstMinorBranchNode(AstTokenNode chunk, AstMinorBranchNode parent)
            : base(parent)
        {
            Chunks = new List<AstTokenNode>() { chunk };

            // set source position for this object
            SourcePosition pos;
            if (chunk.Position == null) pos = null;
            else pos = new SourcePosition(chunk.Position);
        }

        public AstMinorBranchNode(List<AstTokenNode> chunks)
        {
            if (chunks == null)
            {
                Chunks = new List<AstTokenNode>();
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
        public AstMinorBranchNode(List<AstTokenNode> chunks, AstMinorBranchNode parent)
            : base(parent)
        {
            if (chunks == null)
            {
                Chunks = new List<AstTokenNode>();
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
