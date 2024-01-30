using System;

using R5T.T0132;


namespace D8S.E0009.F000
{
    /// <summary>
    /// An example operator that is merely functionality with a method instance for use in testing.
    /// </summary>
    [FunctionalityMarker]
    public partial interface IExampleOperator : IFunctionalityMarker
    {
        public string Add(string a, string b)
        {
            var output = a + b;
            return output;
        }
    }
}
