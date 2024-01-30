using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace D8S.E0009
{
    [TestClass]
    public class AdditionTestFixtureForExampleOperator
        // Does not work. (MSTest does not find TestMethod-marked methods in interfaces implemented by TestClass-marked classes.
        // Must use abstract class, generic in the test article type.
        //: IAdditionTestFixture
    {
        public AdditionTestArticleForExampleOperator TestArticle { get; } = new AdditionTestArticleForExampleOperator();

        //IAdditionTestArticle IAdditionTestFixture.TestArticle => this.TestArticle;

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
