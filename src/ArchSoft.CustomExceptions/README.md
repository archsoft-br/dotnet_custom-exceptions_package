# Collection of Custom Exceptions

## Library with a compilation of Custom Exceptions

### Http

- BadGatewayException
- BadRequestException
- ConflictException
- ForbiddenException
- GatewayTimeoutException
- GoneException
- InsufficientStorageException
- LoopDetectedException
- NotFoundException
- RequestTimeoutException
- ServiceUnavailableException
- UnauthorizedException
- UnprocessableEntityException
- InternalServerErrorException

### Auth

- AuthenticationException
- AuthorizationException

### Api

- RequestException
- ResponseException

### Broker

- BrokerException
- ConsumerException
- ProducerException

### Business

- BusinessException
- RuleException
- ValidationException

### Integration

- IntegrationException

### IO

- InputException
- OutputException

### Operation

- OperationException

### Process

- ProcessException
- MapException
- ParseException

### Unavailable

- UnavailableException

### Unexpected

- UnexpectedException

## Handlers

Get HTTP Status Code by Exception:

```csharp
var httpStatusCode = ExceptionHandler.GetStatusCode(ex);
```
