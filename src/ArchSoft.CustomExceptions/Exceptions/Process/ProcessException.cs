using ArchSoft.CustomExceptions.Exceptions.Http;

namespace ArchSoft.CustomExceptions.Exceptions.Process;

public class ProcessException : UnprocessableEntityException
{
    public ProcessException()
    {
    }

    public ProcessException(string message) : base(message)
    {
    }

    public ProcessException(string message, Exception inner) : base(message, inner)
    {
    }
}
