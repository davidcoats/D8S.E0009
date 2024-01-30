using System;


namespace D8S.E0009.T000
{
    // See R5T.T0242.TestFixtureBase.
    public abstract class TestFixtureBase<TTestArticle>
    {
        public abstract TTestArticle TestArticle { get; }
    }
}
