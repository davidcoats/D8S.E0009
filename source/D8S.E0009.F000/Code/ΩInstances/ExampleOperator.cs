using System;


namespace D8S.E0009.F000
{
    public class ExampleOperator : IExampleOperator
    {
        #region Infrastructure

        public static IExampleOperator Instance { get; } = new ExampleOperator();


        private ExampleOperator()
        {
        }

        #endregion
    }
}
