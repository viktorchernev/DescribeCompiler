using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeCompiler.Compiler
{
    /// <summary>
    /// Indicates how to use artifacts
    /// </summary>
    public enum ArtifactMode
    {
        MakeOnly,
        TakeOnly,
        Use,
        No
    }
}
