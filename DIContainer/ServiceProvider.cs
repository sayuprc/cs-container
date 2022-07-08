namespace DIContainer
{
    public abstract class ServiceProvider
    {
        protected Container container;

        public ServiceProvider(Container container)
        {
            this.container = container;
        }

        public abstract void Register();
    }
}
