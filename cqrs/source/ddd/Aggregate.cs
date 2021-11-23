namespace Jgs.Cqrs
{
    public abstract class Aggregate : Entity
    {
        #region Creation

        protected Aggregate(Id id = default) : base(id)
        {
        }

        #endregion
    }
}
