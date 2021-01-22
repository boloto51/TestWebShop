using System.Linq;
using AutoFixture;
using AutoFixture.Kernel;

namespace TestWebShop.Test.FakeFactories
{
    public class FakeFactory
    {
        public static readonly Fixture Fixture = new Fixture();

        static FakeFactory()
        {
            Fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList()
                .ForEach(b => Fixture.Behaviors.Remove(b));
            Fixture.Behaviors.Add(new OmitOnRecursionBehavior());
        }
    }
}