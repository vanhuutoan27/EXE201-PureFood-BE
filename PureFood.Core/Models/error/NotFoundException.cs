namespace PureFood.Core.Models.error
{
    public class NotFoundException : Exception
    {
        protected NotFoundException(string message) : base(message) { }

    }
}
