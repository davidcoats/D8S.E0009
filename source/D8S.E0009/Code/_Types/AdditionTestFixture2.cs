using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using D8S.E0009.V000;


namespace D8S.E0009
{
    [TestClass]
    public class AdditionTestFixture2 : AdditionTestFixture2<AdditionTestArticle2>
        //, IAdditionTestFixture3
    {
        public override AdditionTestArticle2 TestArticle { get; } = new AdditionTestArticle2();

        //IAdditionTestArticle2 IAdditionTestFixture3.TestArticle => this.TestArticle;
    }
}
