using System;

namespace Jgs.Cqrs
{
    public abstract record Event
    {
        #region Creation

        protected Event()
        {
            Id = Guid.NewGuid();
            Type = GetType().Name;
        }

        #endregion

        #region Public Interface

        public Guid Id { get; }
        public string Type { get; }

        #endregion
    }
}
