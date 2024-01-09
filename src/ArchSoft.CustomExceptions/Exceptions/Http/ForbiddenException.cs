using System.Net;

namespace ArchSoft.CustomExceptions.Exceptions.Http;

public class ForbiddenException : Exception
{
    public static HttpStatusCode StatusCode = HttpStatusCode.Forbidden;

    public ForbiddenException()
    {
    }

    public ForbiddenException(string message) : base(message)
    {
    }

    public ForbiddenException(string message, Exception inner) : base(message, inner)
    {
    }
}
