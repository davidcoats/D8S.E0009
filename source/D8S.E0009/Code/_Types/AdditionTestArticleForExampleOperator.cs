using System;

using D8S.E0009.F000;


namespace D8S.E0009
{
    public class AdditionTestArticleForExampleOperator : IAdditionTestArticle
    {
        public static IExampleOperator Instance => ExampleOperator.Instance;



        public string Add(string a, string b)
        {
            var output = Instance.Add(a, b);
            return output;
        }
    }
}
