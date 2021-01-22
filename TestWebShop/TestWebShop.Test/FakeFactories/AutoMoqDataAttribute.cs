using AutoFixture;
using AutoFixture.Xunit2;

namespace TestWebShop.Test.FakeFactories
{
    public class AutoMoqDataAttribute : AutoDataAttribute
    {
        public AutoMoqDataAttribute() : base(FakeFactory.Fixture)
        {
        }
    }
}