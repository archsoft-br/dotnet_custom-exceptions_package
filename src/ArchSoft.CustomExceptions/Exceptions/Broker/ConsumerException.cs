using ArchSoft.CustomExceptions.Exceptions.Http;

namespace ArchSoft.CustomExceptions.Exceptions.Broker;

public class ConsumerException : BadGatewayException
{
    public ConsumerException()
    {
    }

    public ConsumerException(string message) : base(message)
    {
    }

    public ConsumerException(string message, Exception inner) : base(message, inner)
    {
    }
}
