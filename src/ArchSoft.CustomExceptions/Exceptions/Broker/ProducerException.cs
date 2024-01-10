using ArchSoft.CustomExceptions.Exceptions.Http;

namespace ArchSoft.CustomExceptions.Exceptions.Broker;

public class ProducerException : BadGatewayException
{
    public ProducerException()
    {
    }

    public ProducerException(string message) : base(message)
    {
    }

    public ProducerException(string message, Exception inner) : base(message, inner)
    {
    }
}
