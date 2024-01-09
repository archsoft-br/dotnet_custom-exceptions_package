using ArchSoft.CustomExceptions.Exceptions.Http;

namespace ArchSoft.CustomExceptions.Exceptions.Operation;

public class OperationException : ConflictException
{
    public OperationException()
    {
    }

    public OperationException(string message) : base(message)
    {
    }

    public OperationException(string message, Exception inner) : base(message, inner)
    {
    }
}
