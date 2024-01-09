using System.Net;

namespace ArchSoft.CustomExceptions.Exceptions.Http;

public class UnprocessableEntityException : Exception
{
    public static HttpStatusCode StatusCode = HttpStatusCode.UnprocessableEntity;

    public UnprocessableEntityException()
    {
    }

    public UnprocessableEntityException(string message) : base(message)
    {
    }

    public UnprocessableEntityException(string message, Exception inner) : base(message, inner)
    {
    }
}
