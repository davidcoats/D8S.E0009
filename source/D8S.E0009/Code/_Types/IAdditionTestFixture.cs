using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace D8S.E0009
{
    /// <summary>
    /// Does not work.
    /// As in, MStest does not find TestMethod-marked methods defined in interfaces implemented by TestClass-marked class implementations.
    /// Classes must be used.
    /// </summary>
    public interface IAdditionTestFixture
    {
        public IAdditionTestArticle TestArticle { get; }


        [TestMethod]
        public void Test_Addition()
        {
            var a = Instances.Values.A;
            var b = Instances.Values.B;

            var expectation = Instances.Values.AB;

            var actual = this.TestArticle.Add(
                a,
                b);

            Assert.AreEqual(
                expectation,
                actual);
        }
    }
}
