using DescribeParser.Ast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescribeParser.Ast
{
    public static partial class AstFactory
    {
        /// <summary>
        /// Creates a new <see cref="SourcePosition"/> with the specified parameters.
        /// </summary>
        /// <param name="firstIndex">The index of the first character.</param>
        /// <param name="firstLine">The line number of the first character.</param>
        /// <param name="firstColumn">The column number of the first character.</param>
        /// <param name="lastIndex">The index of the last character.</param>
        /// <param name="lastLine">The line number of the last character.</param>
        /// <param name="lastColumn">The column number of the last character.</param>
        /// <returns>A new <see cref="SourcePosition"/> with the specified parameters.</returns>
        public static SourcePosition CreateSourcePosition(
            int firstIndex, int firstLine, int firstColumn, 
            int lastIndex, int lastLine, int lastColumn)
        {
            SourcePosition position = new SourcePosition();
            position.FirstIndex = firstIndex;
            position.FirstLine = firstLine;
            position.FirstColumn = firstColumn;
            position.LastIndex = lastIndex;
            position.LastLine = lastLine;
            position.LastColumn = lastColumn;

            return position;
        }

        /// <summary>
        /// Creates a new <see cref="SourcePosition"/> by copying the values from an existing <see cref="SourcePosition"/>.
        /// </summary>
        /// <param name="position">The <see cref="SourcePosition"/> to copy.</param>
        /// <returns>A new <see cref="SourcePosition"/> with the same values as the specified <paramref name="position"/>.</returns>
        public static SourcePosition CreateSourcePosition(
            SourcePosition position)
        {
            SourcePosition pos = new SourcePosition();
            pos.FirstIndex = position.FirstIndex;
            pos.FirstLine = position.FirstLine;
            pos.FirstColumn = position.FirstColumn;

            pos.LastIndex = position.LastIndex;
            pos.LastLine = position.LastLine;
            pos.LastColumn = position.LastColumn;

            return pos;
        }

        /// <summary>
        /// Creates a new <see cref="SourcePosition"/> by combining values from two existing <see cref="SourcePosition"/> instances.
        /// </summary>
        /// <param name="position0">The <see cref="SourcePosition"/> to use for the first part of the range.</param>
        /// <param name="position1">The <see cref="SourcePosition"/> to use for the last part of the range.</param>
        /// <returns>A new <see cref="SourcePosition"/> with the first values from <paramref name="position0"/> and last values from <paramref name="position1"/>.</returns>
        public static SourcePosition CreateSourcePosition(
            SourcePosition position0, SourcePosition position1)
        {
            SourcePosition pos = new SourcePosition();
            pos.FirstIndex = position0.FirstIndex;
            pos.FirstLine = position0.FirstLine;
            pos.FirstColumn = position0.FirstColumn;

            pos.LastIndex = position1.LastIndex;
            pos.LastLine = position1.LastLine;
            pos.LastColumn = position1.LastColumn;

            return pos;
        }
    }
}
