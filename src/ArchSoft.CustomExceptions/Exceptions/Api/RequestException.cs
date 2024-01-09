using ArchSoft.CustomExceptions.Exceptions.Http;

namespace ArchSoft.CustomExceptions.Exceptions.Api;

public class RequestException : BadRequestException
{
    public RequestException()
    {
    }

    public RequestException(string message) : base(message)
    {
    }

    public RequestException(string message, Exception inner) : base(message, inner)
    {
    }
}
