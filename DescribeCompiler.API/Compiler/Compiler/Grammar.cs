using System.IO;


namespace DescribeCompiler
{
    public partial class DescribeCompiler
    {
        bool LoadGrammar(byte[] grammar)
        {
            using (MemoryStream memory = new MemoryStream(grammar))
            {
                using (BinaryReader reader = new BinaryReader(memory))
                {
                    bool isLoaded = _GoldParser.LoadTables(reader);
                    return isLoaded;
                }
            }
        }
        string GrammarNameToFullGramarName(GrammarName name)
        {
            switch (name)
            {
                case GrammarName.Basic:
                    return "Basic v0.6";
                case GrammarName.Tags:
                    return "Tags v0.7";
                case GrammarName.Links:
                    return "Links v0.8";
                case GrammarName.Decorators:
                    return "Decorators v0.9";
                case GrammarName.Official:
                    return "Official v1.0";
                default:
                    return "Unknown";
            }
        }
        string GrammarNameToResourceName(GrammarName name)
        {
            switch (name)
            {
                case GrammarName.Basic:
                    return "DescribeBasics.egt";
                case GrammarName.Tags:
                    return "DescribeTags.egt";
                case GrammarName.Links:
                    return "DescribeLinks.egt";
                case GrammarName.Decorators:
                    return "DescribeDecorators.egt";
                case GrammarName.Official:
                    return "DescribeOfficial.egt";
                default:
                    return "Unknown";
            }
        }
    }
}