using System.Collections.Generic;
using System.Linq;

namespace Jgs.EventSourcing
{
    public abstract class ValueObject
    {
        #region Equality

        public override bool Equals(object other)
        {
            if (other is null || GetType() != other.GetType())
                return false;

            return GetEqualityComponents().SequenceEqual(
                ((ValueObject) other).GetEqualityComponents()
            );
        }

        public abstract IEnumerable<object> GetEqualityComponents();

        public override int GetHashCode() =>
            GetEqualityComponents().Aggregate(
                1,
                (current, obj) =>
                {
                    unchecked
                    {
                        return current * 23 + (obj?.GetHashCode() ?? 0);
                    }
                }
            );

        #endregion

        #region Static Interface

        public static bool operator ==(ValueObject left, ValueObject right)
        {
            if (left is null)
                return right is null;

            return left.Equals(right);
        }

        public static bool operator !=(ValueObject left, ValueObject right) => !(left == right);

        #endregion
    }
}
