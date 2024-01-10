using System.Net;

namespace ArchSoft.CustomExceptions.Exceptions.Http;

public class InsufficientStorageException : Exception
{
    public static HttpStatusCode StatusCode = HttpStatusCode.InsufficientStorage;

    public InsufficientStorageException()
    {
    }

    public InsufficientStorageException(string message) : base(message)
    {
    }

    public InsufficientStorageException(string message, Exception inner) : base(message, inner)
    {
    }
}
