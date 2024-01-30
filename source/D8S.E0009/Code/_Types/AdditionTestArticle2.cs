using System;

using D8S.E0009.F000;
using D8S.E0009.V000;


namespace D8S.E0009
{
    public class AdditionTestArticle2 : IAdditionTestArticle2
    {
        public static IExampleOperator Instance => ExampleOperator.Instance;


        public string Add(string a, string b)
        {
            var output = Instance.Add(a, b);
            return output;
        }
    }
}
