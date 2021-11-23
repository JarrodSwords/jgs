using System.Collections.Generic;
using System.Diagnostics;

namespace Jgs.EventSourcing
{
    [DebuggerDisplay("{Value}")]
    public abstract class TinyType<T> : ValueObject
    {
        protected readonly T Value;

        #region Creation

        protected TinyType(T value)
        {
            Value = value;
        }

        #endregion

        #region Public Interface

        public override string ToString() => Value.ToString();

        #endregion

        #region Equality

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }

        #endregion

        #region Static Interface

        public static implicit operator T(TinyType<T> source) => source.Value;

        #endregion
    }
}
