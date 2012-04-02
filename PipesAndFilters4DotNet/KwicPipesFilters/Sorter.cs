using System.Collections.Generic;
using System.Linq;
using PipesAndFilters4DotNet;

namespace KwicPipesFilters
{
    public class Sorter : IOperation<string>
    {
        public IEnumerable<string> Execute(IEnumerable<string> input)
        {
            LineComparer lineComparer = new LineComparer();
            input.ToList<string>().Sort(lineComparer);
            return input;
        }
    }
}
