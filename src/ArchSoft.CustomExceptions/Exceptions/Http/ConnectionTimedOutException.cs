using System.Net;

namespace ArchSoft.CustomExceptions.Exceptions.Http;

public class ConnectionTimedOutException: Exception
{
    public static HttpStatusCode StatusCode = HttpStatusCode.Tim;

    public ConnectionTimedOutException()
    {
    }

    public ConnectionTimedOutException(string message) : base(message)
    {
    }

    public ConnectionTimedOutException(string message, Exception inner) : base(message, inner)
    {
    }
}
