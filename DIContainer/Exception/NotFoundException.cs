namespace DIContainer.Exception
{
    internal class NotFoundException : System.Exception
    {
        public NotFoundException()
            : base()
        {
        }

        public NotFoundException(string message)
            : base(message)
        {
        }
    }
}
