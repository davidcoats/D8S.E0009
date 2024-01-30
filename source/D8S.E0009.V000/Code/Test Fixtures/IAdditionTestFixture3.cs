using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace D8S.E0009.V000
{
    /// <summary>
    /// Does not work. (MSTest does not find TestMethod-marked methods in interfaces implemented by TestClass-marked classes.)
    /// </summary>
    public interface IAdditionTestFixture3
    {
        public IAdditionTestArticle2 TestArticle { get; }


        [TestMethod]
        public void Test_Addition3()
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
