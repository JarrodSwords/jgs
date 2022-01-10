namespace Jgs.Functional.Explicit
{
    public record Result
    {
        #region Public Interface

        public bool IsFailure { get; } = true;

        #endregion

        #region Static Interface

        public static Result Error() => new();

        #endregion
    }
}
