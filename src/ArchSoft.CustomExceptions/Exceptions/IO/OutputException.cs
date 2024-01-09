using ArchSoft.CustomExceptions.Exceptions.Http;

namespace ArchSoft.CustomExceptions.Exceptions.IO;

public class OutputException : InternalServerErrorException
{
    public OutputException()
    {
    }

    public OutputException(string message) : base(message)
    {
    }

    public OutputException(string message, Exception inner) : base(message, inner)
    {
    }
}
