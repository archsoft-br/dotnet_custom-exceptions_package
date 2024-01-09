using System.Net;

namespace ArchSoft.CustomExceptions.Exceptions.Http;

public class BadRequestException : Exception
{
    public static HttpStatusCode StatusCode = HttpStatusCode.BadRequest;

    public BadRequestException()
    {
    }

    public BadRequestException(string message) : base(message)
    {
    }

    public BadRequestException(string message, Exception inner) : base(message, inner)
    {
    }
}
