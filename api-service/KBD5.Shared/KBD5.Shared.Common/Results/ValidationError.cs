namespace KBD5.Shared.Common.Results;

public sealed record ValidationError(Error[] Errors) 
    : Error(
        Code: "Validation.General", 
        Description: "One or more validation errors occurred", 
        ErrorType: ErrorType.Validation)
{
    public static ValidationError FromValidationResults(IEnumerable<Result> results) =>
        new(results.Where(r => r.IsFailure).Select(r => r.Error).ToArray()!);
}