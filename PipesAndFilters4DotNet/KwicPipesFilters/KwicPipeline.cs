
using PipesAndFilters4DotNet;
namespace KwicPipesFilters
{
    public class KwicPipeline : Pipeline<string>
    {
        public KwicPipeline()
        {
            Register(new Reader());
            Register(new Shifter());
            Register(new Sorter());
            Register(new Writer());
        }
    }
}
