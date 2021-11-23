﻿using System.Collections.Generic;

namespace Jgs.Cqrs
{
    public class StreamId : ValueObject
    {
        #region Creation

        public StreamId(Name name, Id entityId = default, bool isCommand = false)
        {
            Name = name;
            EntityId = entityId;
            IsCommand = isCommand;
        }

        #endregion

        #region Public Interface

        public Id EntityId { get; }
        public bool IsCommand { get; }
        public Name Name { get; }

        #endregion

        #region Equality

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return EntityId;
            yield return IsCommand;
            yield return Name;
        }

        #endregion
    }
}
