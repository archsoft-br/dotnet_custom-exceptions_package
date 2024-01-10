using ArchSoft.CustomExceptions.Exceptions.Http;

namespace ArchSoft.CustomExceptions.Exceptions.Business;

public class RuleException : UnprocessableEntityException
{
    public RuleException()
    {
    }

    public RuleException(string message) : base(message)
    {
    }

    public RuleException(string message, Exception inner) : base(message, inner)
    {
    }
}
