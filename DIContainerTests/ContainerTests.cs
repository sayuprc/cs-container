using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DIContainer.Tests
{
    [TestClass()]
    public class ContainerTests
    {
        [TestMethod()]
        public void Test()
        {
            var container = new Container();

            var provider = new AppServiceProvider(container);

            provider.Register();

            var concrete = container.Get<SampleInterface>();

            Assert.AreEqual<string>(concrete.Execute(), "Mock");
        }
    }
}