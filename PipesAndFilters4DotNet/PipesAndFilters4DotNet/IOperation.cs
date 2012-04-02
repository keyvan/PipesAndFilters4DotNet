using System.Collections.Generic;

namespace PipesAndFilters4DotNet
{
    public interface IOperation<T>
    {
        IEnumerable<T> Execute(IEnumerable<T> input);
    }
}
