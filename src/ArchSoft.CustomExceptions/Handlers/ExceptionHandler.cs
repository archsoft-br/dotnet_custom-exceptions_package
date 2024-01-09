using System.Net;
using ArchSoft.CustomExceptions.Exceptions.Api;
using ArchSoft.CustomExceptions.Exceptions.Auth;
using ArchSoft.CustomExceptions.Exceptions.Broker;
using ArchSoft.CustomExceptions.Exceptions.Business;
using ArchSoft.CustomExceptions.Exceptions.Http;
using ArchSoft.CustomExceptions.Exceptions.Integration;
using ArchSoft.CustomExceptions.Exceptions.IO;
using ArchSoft.CustomExceptions.Exceptions.Operation;
using ArchSoft.CustomExceptions.Exceptions.Process;
using ArchSoft.CustomExceptions.Exceptions.Unavailable;

namespace ArchSoft.CustomExceptions.Handlers;

public static class ExceptionHandler
{
    public static HttpStatusCode GetStatusCode(Exception ex)
    {
        switch (ex.GetType().Name)
        {
            case nameof(BadGatewayException):
            case nameof(IntegrationException):
            case nameof(BrokerException):
            case nameof(ConsumerException):
            case nameof(ProducerException):
                return HttpStatusCode.BadGateway;

            case nameof(BadRequestException):
            case nameof(RequestException):
            case nameof(InputException):
            case nameof(ArgumentException):
                return HttpStatusCode.BadRequest;

            case nameof(ConflictException):
            case nameof(OperationException):
            case nameof(InvalidOperationException):
                return HttpStatusCode.Conflict;

            case nameof(ForbiddenException):
            case nameof(AuthenticationException):
                return HttpStatusCode.Forbidden;

            case nameof(GatewayTimeoutException):
                return HttpStatusCode.GatewayTimeout;

            case nameof(GoneException):
                return HttpStatusCode.Gone;

            case nameof(InsufficientStorageException):
                return HttpStatusCode.InsufficientStorage;

            case nameof(LoopDetectedException):
                return HttpStatusCode.LoopDetected;

            case nameof(NotFoundException):
                return HttpStatusCode.NotFound;

            case nameof(NotImplementedException):
                return HttpStatusCode.NotImplemented;

            case nameof(RequestTimeoutException):
            case nameof(TimeoutException):
                return HttpStatusCode.RequestTimeout;

            case nameof(ServiceUnavailableException):
            case nameof(UnavailableException):
                return HttpStatusCode.ServiceUnavailable;

            case nameof(UnauthorizedException):
            case nameof(AuthorizationException):
                return HttpStatusCode.Unauthorized;

            case nameof(UnprocessableEntityException):
            case nameof(ProcessException):
            case nameof(MapException):
            case nameof(ParseException):
            case nameof(BusinessException):
            case nameof(RuleException):
            case nameof(ValidationException):
                return HttpStatusCode.UnprocessableEntity;

            default:
                return HttpStatusCode.InternalServerError;
        }
    }
}
