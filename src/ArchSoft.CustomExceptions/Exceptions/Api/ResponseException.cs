using ArchSoft.CustomExceptions.Exceptions.Http;

namespace ArchSoft.CustomExceptions.Exceptions.Api;

public class ResponseException : InternalServerErrorException
{
    public ResponseException()
    {
    }

    public ResponseException(string message) : base(message)
    {
    }

    public ResponseException(string message, Exception inner) : base(message, inner)
    {
    }
}
