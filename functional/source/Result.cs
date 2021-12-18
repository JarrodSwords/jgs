using System;

namespace Jgs.Functional
{
    public class Result
    {
        #region Creation

        protected Result(string message = default)
        {
            Message = message;
            IsFailure = !string.IsNullOrWhiteSpace(Message);
        }

        #endregion

        #region Public Interface

        public bool IsFailure { get; }
        public bool IsSuccess => !IsFailure;
        public string Message { get; }

        public Result Bind(Func<Result> func) => IsFailure ? this : func();

        #endregion

        #region Static Interface

        public static Result Failure(string message) => new(message);
        public static Result<T> Failure<T>(string message) => new(message);
        public static Result Success() => new();
        public static Result<T> Success<T>(T value) => new(value);

        public static Result Combine(params Result[] results)
        {
            foreach (var result in results)
                if (result.IsFailure)
                    return result;

            return Success();
        }

        #endregion
    }

    public class Result<T> : Result
    {
        #region Creation

        protected internal Result(T value)
        {
            Value = value;
        }

        protected internal Result(string message) : base(message)
        {
            Value = default;
        }

        #endregion

        #region Public Interface

        public T Value { get; }
        public Result<T> Bind(Func<T, Result<T>> func) => func(Value);

        #endregion
    }
}
