using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeCompiler
{
    public interface IUnfoldTranslator
    {
        bool IsInitialized();
        string TranslateUnfold(DescribeUnfold u);
    }
}
