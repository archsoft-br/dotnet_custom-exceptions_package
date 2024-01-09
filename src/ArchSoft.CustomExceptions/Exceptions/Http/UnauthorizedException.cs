using System.Net;

namespace ArchSoft.CustomExceptions.Exceptions.Http;

public class UnauthorizedException : Exception
{
    public static HttpStatusCode StatusCode = HttpStatusCode.Unauthorized;

    public UnauthorizedException()
    {
    }

    public UnauthorizedException(string message) : base(message)
    {
    }

    public UnauthorizedException(string message, Exception inner) : base(message, inner)
    {
    }
}
