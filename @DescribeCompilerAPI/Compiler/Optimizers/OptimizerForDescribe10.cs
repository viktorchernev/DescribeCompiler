using GoldParser.ParseTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeCompiler.Compiler.Optimizers
{
    public class OptimizerForDescribe10 : IDescribeOptimizer
    {
        private static Random random = new Random();
        private static string getRandomString(int length = 8)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        //Name
        private string GetRuleName(Reduction r)
        {
            string ruleName = r.Production.Head.Name;
            return ruleName;
        }


        //Tags
        private string DoTag(Reduction r)
        {
            //string id = DoText(r[1].Data as Reduction);
            //return id;
            return "";
        }

        public bool DoScripture(DescribeUnfold u, Reduction r)
        {
            throw new NotImplementedException();
        }
    }
}
