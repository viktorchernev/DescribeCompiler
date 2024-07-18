using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Unfold
{
    public partial class DescribeUnfoldV3
    {
        // should be removed or smth
        // probably offset to a ParseJob class
        public string LastNamespace;    //current namespace we are in
        public string LastFile;         //current file we are in



        public int AddId(string id)
        {
            //check if Ids don't contain id
            int x = Ids.Count;
            Ids.Add(x, id); 
            return x;
        }

        public void AddPrimaryProduction(string id)
        {
            int x = IdToIndex(id);
            if (x == -1) x = AddId(id);
            PrimaryProductions.Add(x);
        }
        public void RemovePrimaryProduction(string id)
        {
            int x = IdToIndex(id);
            PrimaryProductions.RemoveAll(num => num == 4);
        }



        public string? GetTranslation(string id)
        {
            int x = IdToIndex(id);
            return Translations[x];
        }
        public void RemoveTranslation(string id)
        {
            int x = IdToIndex(id);
            Translations.Remove(x);
        }

        int IdToIndex(string id)
        {
            foreach (KeyValuePair<int, string> kvp in Ids)
            {
                if (kvp.Value == id)
                {
                    int x = kvp.Key;
                    return x;
                }
            }
            return -1;
        }
        string? IndexToId(int index)
        {
            string? id = Ids[index];
            return id;
        }
    }
}

// Isn't all this logic slowing things down, insead of 
// saving time from string comparason?