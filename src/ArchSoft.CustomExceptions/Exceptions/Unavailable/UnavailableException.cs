using ArchSoft.CustomExceptions.Exceptions.Http;

namespace ArchSoft.CustomExceptions.Exceptions.Unavailable;

public class UnavailableException : ServiceUnavailableException
{
    public UnavailableException()
    {
    }

    public UnavailableException(string message)
        : base(message)
    {
    }

    public UnavailableException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
