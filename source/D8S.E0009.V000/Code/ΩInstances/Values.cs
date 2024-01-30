using System;


namespace D8S.E0009.V000
{
    public class Values : IValues
    {
        #region Infrastructure

        public static IValues Instance { get; } = new Values();


        private Values()
        {
        }

        #endregion
    }
}
