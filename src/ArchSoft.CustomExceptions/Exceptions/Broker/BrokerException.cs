using ArchSoft.CustomExceptions.Exceptions.Http;

namespace ArchSoft.CustomExceptions.Exceptions.Broker;

public class BrokerException : BadGatewayException
{
    public BrokerException()
    {
    }

    public BrokerException(string message) : base(message)
    {
    }

    public BrokerException(string message, Exception inner) : base(message, inner)
    {
    }
}
