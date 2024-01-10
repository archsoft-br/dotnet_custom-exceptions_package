using ArchSoft.CustomExceptions.Exceptions.Http;

namespace ArchSoft.CustomExceptions.Exceptions.Unexpected;

public class UnexpectedException : InternalServerErrorException
{
    public UnexpectedException()
    {
    }

    public UnexpectedException(string message)
        : base(message)
    {
    }

    public UnexpectedException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
