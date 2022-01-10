namespace Jgs.Functional.Explicit
{
    public record Result
    {
        #region Creation

        private Result(bool isSuccess = true)
        {
            IsSuccess = isSuccess;
        }

        #endregion

        #region Public Interface

        public bool IsFailure => !IsSuccess;
        public bool IsSuccess { get; }

        #endregion

        #region Static Interface

        public static Result Error() => new(false);
        public static Result Success() => new();

        #endregion
    }
}
