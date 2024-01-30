using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using D8S.E0009.T000;


namespace D8S.E0009.V000
{
    // See R5T.T0243.TestFixtureMarkerAttribute.
    public abstract class AdditionTestFixture2<TTestArticle> : TestFixtureBase<TTestArticle>
        //, IAdditionTestFixture3
        where TTestArticle : IAdditionTestArticle2
    {
        //IAdditionTestArticle2 IAdditionTestFixture3.TestArticle => this.TestArticle;

        [TestMethod]
        public void Test_Addition2()
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
