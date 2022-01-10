namespace Jgs.Functional.Explicit
{
    public record Result<TError>
    {
        #region Creation

        protected internal Result(TError error = default)
        {
            Error = error;
        }

        #endregion

        #region Public Interface

        public TError Error { get; }
        public bool IsFailure => !IsSuccess;
        public bool IsSuccess => Error is null;

        #endregion

        #region Static Interface

        public static Result<TError> Failure(TError error) => new(error);
        public static Result<TValue, TError> Failure<TValue>(TError error) => new(error);
        public static Result<TError> Success() => new();
        public static Result<TValue, TError> Success<TValue>(TValue value) => new(value);

        public static Result<TError> Combine(params Result<TError>[] results)
        {
            foreach (var r in results)
                if (r.IsFailure)
                    return r;

            return Success();
        }

        public static implicit operator Result<TError>(TError error) => new(error);

        #endregion
    }

    public record Result<TValue, TError> : Result<TError>
    {
        #region Creation

        protected internal Result(TError error) : base(error)
        {
        }

        protected internal Result(TValue value)
        {
            Value = value;
        }

        #endregion

        #region Public Interface

        public TValue Value { get; set; }

        #endregion

        #region Static Interface

        public static implicit operator Result<TValue, TError>(TError error) => new(error);
        public static implicit operator Result<TValue, TError>(TValue value) => new(value);

        #endregion
    }
}
