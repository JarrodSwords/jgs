﻿namespace Jgs.Functional.Explicit
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
        public static implicit operator Result<TError>(TError error) => new(error);

        #endregion
    }

    public record Result<TValue, TError> : Result<TError>
    {
        #region Creation

        protected internal Result(TError error) : base(error)
        {
        }

        #endregion

        #region Public Interface

        public TValue Value { get; set; }

        #endregion
    }
}
