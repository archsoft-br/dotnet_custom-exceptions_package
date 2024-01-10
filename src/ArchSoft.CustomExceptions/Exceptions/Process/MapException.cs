using ArchSoft.CustomExceptions.Exceptions.Http;

namespace ArchSoft.CustomExceptions.Exceptions.Process;

public class MapException : UnprocessableEntityException
{
    public MapException()
    {
    }

    public MapException(string message) : base(message)
    {
    }

    public MapException(string message, Exception inner) : base(message, inner)
    {
    }
}
