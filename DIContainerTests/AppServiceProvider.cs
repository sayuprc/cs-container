namespace DIContainer.Tests
{
    internal class AppServiceProvider : ServiceProvider
    {
        public AppServiceProvider(Container container)
            : base(container)
        {
        }

        public override void Register()
        {
            this.container.Bind<SampleInterface>(new Mock());
        }
    }
}
