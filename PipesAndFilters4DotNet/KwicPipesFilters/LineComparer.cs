using System.Collections.Generic;

namespace KwicPipesFilters
{
    public class LineComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y);
        }
    }
}
