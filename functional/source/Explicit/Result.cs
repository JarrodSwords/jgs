namespace Jgs.Functional.Explicit
{
    public record Result<T>
    {
        #region Creation

        private Result(T error = default)
        {
            Error = error;
        }

        #endregion

        #region Public Interface

        public T Error { get; }
        public bool IsFailure => !IsSuccess;
        public bool IsSuccess => Error is null;

        #endregion

        #region Static Interface

        public static Result<T> Failure(T error) => new(error);
        public static Result<T> Success() => new();

        #endregion
    }
}
