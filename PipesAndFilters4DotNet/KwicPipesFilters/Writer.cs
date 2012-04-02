using System;
using System.Collections.Generic;
using PipesAndFilters4DotNet;

namespace KwicPipesFilters
{
    public class Writer : IOperation<string>
    {
        public IEnumerable<string> Execute(IEnumerable<string> input)
        {
            foreach (string line in input)
            {
                Console.WriteLine();
                Console.WriteLine(line);
            }
            Console.ReadLine();
            yield break;
        }
    }
}
