# Collection of Custom Exceptions

## Library with a compilation of Custom Exceptions

- AuthenticationException
- AuthorizationException
- BusinessException
- ConflictException
- FieldException
- InputException
- IntegrationException
- MapException
- NotFoundException
- OperationException
- OutputException
- ParseException
- ProcessException
- RequestException
- ResponseException
- RuleException
- UnavailableException
- UnexpectedException
- ValidationException

## Handlers

Get HTTP Status Code by Exception:

```csharp
var httpStatusCode = ExceptionHandler.GetStatusCode(ex);
```
