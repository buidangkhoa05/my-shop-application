namespace KBD5.Shared.Common.Results;

public record Result(bool IsSuccess, Error? Error)
{
    public bool IsFailure => !IsSuccess;

    public static Result Success()
    {
        return new Result(true, Error.None);
    }

    public static Result<TValue> Success<TValue>(TValue value)
        => new(value, true, Error.None);

    public static Result Failure(Error error)
        => new(false, error);

    public static Result<TValue> Failure<TValue>(Error error)
        => new(default, false, error);
}

public record Result<TValue> : Result
{
    private readonly TValue? _value;

    public Result(TValue? value, bool isSuccess, Error error)
        : base(isSuccess, error)
    {
        _value = value;
    }

    public TValue Value => IsSuccess
        ? _value!
        : throw new InvalidOperationException("The value of a failure result can't be accessed.");

    public static implicit operator Result<TValue>(TValue? value)
        => value is not null
            ? Success(value)
            : Failure<TValue>(Error.NullValue);
}