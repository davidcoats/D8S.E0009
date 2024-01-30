using System;

using R5T.T0131;


namespace D8S.E0009.V000
{
    [ValuesMarker]
    public partial interface IValues : IValuesMarker
    {
        /// <summary>
        /// <para><value>A</value></para>
        /// </summary>
        public string A => "A";

        /// <summary>
        /// <para><value>B</value></para>
        /// </summary>
        public string B => "B";

        /// <summary>
        /// <para><value>AB</value></para>
        /// </summary>
        public string AB => "AB";
    }
}
