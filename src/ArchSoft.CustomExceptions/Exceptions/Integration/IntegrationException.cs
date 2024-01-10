using ArchSoft.CustomExceptions.Exceptions.Http;

namespace ArchSoft.CustomExceptions.Exceptions.Integration;

public class IntegrationException : BadGatewayException
{
    public IntegrationException()
    {
    }

    public IntegrationException(string message) : base(message)
    {
    }

    public IntegrationException(string message, Exception inner) : base(message, inner)
    {
    }
}
