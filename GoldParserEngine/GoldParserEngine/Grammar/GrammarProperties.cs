using System.Collections.Generic;

namespace GoldParser.Grammar
{
    /// <summary>
    /// Stores a property of the compiled grammar. 
    /// Properties are metadata.
    /// </summary>
    public class GrammarProperty
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public GrammarProperty(int index, string name, string value)
        {
            Index = index;
            Name = name;
            Value = value;
        }
    }

    /// <summary>
    /// Index vs Property name
    /// </summary>
    public enum GrammarPropertyIndex
    {
        Name = 0,
        Version = 1,
        Author = 2,
        About = 3,
        CharacterSet = 4,
        CharacterMapping = 5,
        GeneratedBy = 6,
        GeneratedDate = 7
    }

    /// <summary>
    /// Stores the properties of the grammar - that is, the metadata
    /// </summary>
    public class GrammarProperties
    {
        const int PROPERTY_COUNT = 8;
        readonly string[] _properties = new string[PROPERTY_COUNT];
        List<GrammarProperty> _documentary = new List<GrammarProperty>();

        /// <summary>
        /// Although we store all the expected properties in the "GrammarProperties" class,
        /// we also store each property in a "GrammarProperty" class for documentational purposes,
        /// and this returns all those "GrammarProperty" objects in a list.
        /// 
        /// The original authors have a class - "GrammarProperties" in our code, that stores all 
        /// properties data, but should something go out of the ordinary and we have differently-indexed 
        /// or differently-named properties in the EGT file, this information would be lost to us.
        /// This is why I have created "GrammarProperty" class, to keep that original data, so it can be
        /// used to output JSON or text version of the grammar, for example, without the chance of losing
        /// properties, only because our code does not recognise them (because it is older version, e.g.)
        /// </summary>
        public List<GrammarProperty> DocumentedProperties
        {
            get
            {
                return _documentary;
            }
        }


        /// <summary>
        /// Ctor.
        /// </summary>
        internal GrammarProperties()
        {
            for (int n = 0; n < PROPERTY_COUNT; n++)
            {
                _properties[n] = string.Empty;
            }
        }


        /// <summary>
        /// The name of the grammar
        /// </summary>
        public string Name
        {
            get { return _properties[(int)GrammarPropertyIndex.Name]; }
        }

        /// <summary>
        /// The version of the grammar
        /// </summary>
        public string Version
        {
            get { return _properties[(int)GrammarPropertyIndex.Version]; }
        }

        /// <summary>
        /// Name of the author of the grammar
        /// </summary>
        public string Author
        {
            get { return _properties[(int)GrammarPropertyIndex.Author]; }
        }

        /// <summary>
        /// More info about the grammar
        /// </summary>
        public string About
        {
            get { return _properties[(int)GrammarPropertyIndex.About]; }
        }

        /// <summary>
        /// Unknown. Unicode.
        /// </summary>
        public string CharacterSet
        {
            get { return _properties[(int)GrammarPropertyIndex.CharacterSet]; }
        }

        /// <summary>
        /// Unknown
        /// </summary>
        public string CharacterMapping
        {
            get { return _properties[(int)GrammarPropertyIndex.CharacterMapping]; }
        }

        /// <summary>
        /// The name and version of the builder tool that compiled 
        /// the grammar tables ".egt" file
        /// </summary>
        public string GeneratedBy
        {
            get { return _properties[(int)GrammarPropertyIndex.GeneratedBy]; }
        }

        /// <summary>
        /// The generation date of the grammar
        /// </summary>
        public string GeneratedDate
        {
            get { return _properties[(int)GrammarPropertyIndex.GeneratedDate]; }
        }


        /// <summary>
        /// Set a property
        /// </summary>
        /// <param name="index">Which property is set</param>
        /// <param name="value">The string value to set the property to</param>
        public void SetValue(int index, string name, string value)
        {
            if (index >= 0 & index < PROPERTY_COUNT)
            {
                _properties[index] = value;
            }
            _documentary.Add(new GrammarProperty(index, name, value));
        }
    }
}
//Why is it that "_properties = new string[PROPERTY_COUNT + 1];"?
//string[PROPERTY_COUNT + 1] is string[PROPERTY_COUNT]. Let's see if that blows up
//Added the whole "GrammarProperty" thing - look at "public List<GrammarProperty> DocumentedProperties"