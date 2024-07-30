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
    public class AstItemNode : AstNode, IAstBranchChildNode
    {
        // Vars
        private AstLeafNode? _tilde;
        private AstLeafNode _text;
        private AstTagNode? _tag;
        private List<AstLinkNode>? _linksList;
        private List<AstDecoratorNode>? _decoratorsList;

        /// <summary>
        /// The Leaf Node representing the tilde symbol of the Item object
        /// </summary>
        public AstLeafNode? Tilde
        {
            get
            {
                return _tilde;
            }
            internal set
            {
                _tilde = value;
                if(_tilde != null) _tilde.Parent = this;
            }
        }

        /// <summary>
        /// The Leaf Node representing the text of the Item object
        /// </summary>
        public AstLeafNode Text
        {
            get
            {
                return _text;
            }
            internal set
            {
                _text = value;
                if (_text != null) _text.Parent = this;
            }
        }

        /// <summary>
        /// The Tag Node representing the Tag object of the Item object
        /// </summary>
        public AstTagNode? Tag
        {
            get
            {
                return _tag;
            }
            internal set
            {
                _tag = value;
                if (_tag != null) _tag.Parent = this;
            }
        }

        /// <summary>
        /// The List representing the Link objects of the Item object
        /// </summary>
        public List<AstLinkNode>? Links
        {
            get
            {
                return _linksList;
            }
            internal set
            {
                _linksList = value;
                if (_linksList == null) return; 
                for(int i = 0; i < _linksList.Count; i++)
                {
                    if (_linksList[i] != null) _linksList[i].Parent = this;
                }
            }
        }

        /// <summary>
        /// The List representing the Decorator objects of the Item object
        /// </summary>
        public List<AstDecoratorNode>? Decorators
        {
            get
            {
                return _decoratorsList;
            }
            internal set
            {
                _decoratorsList = value;
                if (_decoratorsList == null) return;
                for (int i = 0; i < _decoratorsList.Count; i++)
                {
                    if (_decoratorsList[i] != null) _decoratorsList[i].Parent = this;
                }
            }
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
        public SourcePosition Position
        {
            get;
            set;
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
        {
            _text = null!;
            Position = null!;
        }
 


        // ToString()
        /// <summary>
        /// Get a string representation of the Item object for logging purposes
        /// </summary>
        public override string ToString()
        {
            string indent = "    ";
            string s = "Item : " + Environment.NewLine + Environment.NewLine;

            if (Tilde != null) s += indent + "tilde - \"" + Tilde.ToString() + "\"" + Environment.NewLine;
            else s += indent + "tilde - NULL" + Environment.NewLine;

            s += indent + "text - " + Text.ToString() + Environment.NewLine;

            if (Tag != null) s += indent + "tag - \"" + Tag.ToString() + "\"" + Environment.NewLine;
            else s += indent + "tag - NULL" + Environment.NewLine;

            if (Links != null && Links.Count > 0)
            {
                for(int i = 0; i < Links.Count; i++)
                {
                    if (Links[i] != null) s += indent + "link - \"" + Links[i].ToString() + "\"" + Environment.NewLine;
                    else s += indent + "link - NULL" + Environment.NewLine;
                }
            }
            else s += indent + "links - NULL" + Environment.NewLine;

            if (Decorators != null && Decorators.Count > 0)
            {
                for (int i = 0; i < Decorators.Count; i++)
                {
                    if (Decorators[i] != null) s += indent + "decorator - \"" + Decorators[i].ToString() + "\"" + Environment.NewLine;
                    else s += indent + "decorator - NULL" + Environment.NewLine;
                }
            }
            else s += indent + "decorators - NULL" + Environment.NewLine;

            return s;
        }

        /// <summary>
        /// Get a JSON string representation of the Item object for logging purposes
        /// </summary>
        public override string ToJson()
        {
            // TildeItem
            string? jt = Tilde?.ToJson();
            object? t = null;
            if (jt != null) t = JsonConvert.DeserializeObject(jt);

            // Text
            string? je = Text?.ToJson();
            object? e = null;
            if (je != null) e = JsonConvert.DeserializeObject(je);

            // Tag
            string? ja = Tag?.ToJson();
            object? a = null;
            if (ja != null) a = JsonConvert.DeserializeObject(ja);

            // Links
            List<object?>? ls = null;
            if (Links != null)
            {
                ls = new List<object?>();
                foreach (var link in Links)
                {
                    string? jsonLink = link.ToJson();
                    if (jsonLink != null)
                    {
                        ls.Add(JsonConvert.DeserializeObject(jsonLink));
                    }
                    else ls.Add(null);
                }
            }

            // Decorators
            List<object?>? lsd = null;
            if (Decorators != null)
            {
                lsd = new List<object?>();
                foreach (var decorator in Decorators)
                {
                    string? jsonDecorator = decorator.ToJson();
                    if (jsonDecorator != null)
                    {
                        lsd.Add(JsonConvert.DeserializeObject(jsonDecorator));
                    }
                    else lsd.Add(null);
                }
            }

            // Json object
            var jsonObject = new
            {
                tilde = t,
                text = e,
                tag = a,
                links = ls,
                decorators = lsd
            };

            // Json string
            string s = JsonConvert.SerializeObject(jsonObject);
            return s;
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
                    if (Links == null || Links.Count < 1) continue;
                    for(int j = 0; j < Links.Count; j++)
                    {
                        s += Links[j]?.ToCode();
                    }
                }
                else if (sortedIndexes[i].name == "Decorators")
                {
                    if (Decorators == null || Decorators.Count < 1) continue;
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