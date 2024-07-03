using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    /// <summary>
    /// Represents an Ast Item object 
    /// </summary>
    public class AstItemNode : AstNode, IAstBranchNode, IAstChildNode
    {
        // Vars
        /// <summary>
        /// The Leaf Node representing the tilde symbol of the Item object
        /// </summary>
        public AstLeafNode? Tilde
        {
            get;
            internal set;
        }

        /// <summary>
        /// The Leaf Node representing the text of the Item object
        /// </summary>
        public AstLeafNode Text
        {
            get;
            internal set;
        }

        /// <summary>
        /// The Tag Node representing the Tag object of the Item object
        /// </summary>
        public AstTagNode? Tag
        {
            get;
            internal set;
        }

        /// <summary>
        /// The List representing the Link objects of the Item object
        /// </summary>
        public List<AstLinkNode>? Links
        {
            get;
            internal set;
        }

        /// <summary>
        /// The List representing the Decorator objects of the Item object
        /// </summary>
        public List<AstDecoratorNode>? Decorators
        {
            get;
            internal set;
        }



        // Properties
        /// <summary>
        /// Wether the Item object has a Tag
        /// </summary>
        public bool HasTag
        {
            get
            {
                return Tag == null;
            }
        }

        /// <summary>
        /// Wether the Item object has Links
        /// </summary>
        public bool HasLinks
        {
            get
            {
                return Links == null;
            }
        }

        /// <summary>
        /// Wether the Item object has Decorators
        /// </summary>
        public bool HasDecorators
        {
            get
            {
                return Decorators == null;
            }
        }



        // IAstBranchNode
        /// <summary>
        /// Gets all the direct descendant nodes of this Item object
        /// </summary>
        public List<object> Children
        {
            get
            {
                List<object> result = new List<object>();
                if (Tilde != null) result.Add(Tilde);
                result.Add(Text);
                if (Tag != null) result.Add(Tag);
                if (Links != null) result.Add(Links);
                if (Decorators != null) result.Add(Decorators);

                return result;
            }
        }

        /// <summary>
        /// Gets all the Leaf Nodes contained in this Item object
        /// </summary>
        public List<AstLeafNode> Leafs
        {
            get
            {
                List<AstLeafNode> li = new List<AstLeafNode>();
                li.Add(Text);
                if (Tag != null) 
                { 
                    li.AddRange(Tag.Leafs); 
                }
                if (Links != null) 
                { 
                    for(int i = 0; i < Links.Count; i++)
                    {
                        if (Links[i] != null) li.AddRange(Links[i].Leafs);
                    }
                }
                if (Decorators != null)
                {
                    for (int i = 0; i < Decorators.Count; i++)
                    {
                        if (Decorators[i] != null) li.AddRange(Decorators[i].Leafs);
                    }
                }

                return li;
            }
        }



        // IAstChildNode
        /// <summary>
        /// Get the SourcePosition of this Item object
        /// </summary>
        public SourcePosition? Position
        {
            get;
            internal set;
        }

        /// <summary>
        /// Get the Parent of this Item object
        /// </summary>
        public IAstBranchNode? Parent
        {
            get;
            set;
        }



        // Internal Ctor - to prevent external instantiation
        /// <summary>
        /// Internal constructor to prevent external instantiation of <see cref="AstTagNode"/>.
        /// </summary>
        internal AstItemNode()
        { }
 


        // ToString()
        /// <summary>
        /// Get a string representation of the Item object for logging purposes
        /// </summary>
        public override string ToString()
        {
            string s = "Item : " + Environment.NewLine;
            if (Tilde != null) s += "\"" + Tilde.ToString() + "\"" + Environment.NewLine;
            s += "\"" + Text.ToString() + "\"" + Environment.NewLine;
            if (Tag != null) s += "\"" + Tag.ToString() + "\"" + Environment.NewLine;
            
            if(Links != null && Links.Count > 0)
            {
                for(int i = 0; i < Links.Count; i++)
                {
                    if (Links[i] != null) s += "\"" + Links[i].ToString() + "\"" + Environment.NewLine;
                }
            }

            if (Decorators != null && Decorators.Count > 0)
            {
                for (int i = 0; i < Decorators.Count; i++)
                {
                    if (Decorators[i] != null) s += "\"" + Decorators[i].ToString() + "\"" + Environment.NewLine;
                }
            }

            return s;
        }

        /// <summary>
        /// Get a JSON string representation of the Item object for logging purposes
        /// </summary>
        public override string ToJson()
        {
            var jsonObject = new
            {
                tilde = Tilde?.ToJson(),
                text = Text != null ? JsonConvert.DeserializeObject(Text.ToJson()) : null,
                tag = Tag?.ToJson(),
                links = Links?.Select(link => JsonConvert.DeserializeObject(link.ToJson())).ToList(),
                decorators = Decorators?.Select(decorator => JsonConvert.DeserializeObject(decorator.ToJson())).ToList()
            };

            return JsonConvert.SerializeObject(jsonObject);
        }

        /// <summary>
        /// Get a source code string representation of the Tag object
        /// </summary>
        public override string ToCode()
        {
            string s = "";
            if (Tilde != null) s += Tilde.ToCode();
            s += Text.ToCode();

            // Figure out order
            int tagindex = Tag?.Position?.FirstIndex ?? -1;
            int linkindex = Links?.FirstOrDefault()?.Position?.FirstIndex ?? -1;
            int decoratorindex = Decorators?.FirstOrDefault()?.Position?.FirstIndex ?? -1;

            // Sort
            var indexes = new (int index, string name)[] {
                (tagindex, "Tag"),
                (linkindex, "Links"),
                (decoratorindex, "Decorators")
            };
            var sortedIndexes = indexes.OrderBy(x => x.index).ToList();

            // Loop
            for(int i = 0; i < sortedIndexes.Count; i++ )
            {
                if (sortedIndexes[i].index == -1) continue;
                if (sortedIndexes[i].name == "Tag")
                {
                    s += Tag?.ToCode();
                }
                else if (sortedIndexes[i].name == "Links")
                {
                    if (Links.Count < 1) continue;
                    for(int j = 0; j < Links.Count; j++)
                    {
                        s += Links[j]?.ToCode();
                    }
                }
                else if (sortedIndexes[i].name == "Decorators")
                {
                    if (Decorators.Count < 1) continue;
                    for (int j = 0; j < Decorators.Count; j++)
                    {
                        s += Decorators[j]?.ToCode();
                    }
                }
            }

            return s;
        }
    }
}