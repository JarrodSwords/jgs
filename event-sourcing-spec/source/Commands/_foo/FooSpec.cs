using System;
using Jgs.EventSourcing.Messages;
using Jgs.EventSourcing.Spec.Messages;

namespace Jgs.EventSourcing.Spec.Commands
{
    public class FooSpec : MessageSpec
    {
        private static readonly Foo Foo = new(new UserId());

        #region Creation

        public FooSpec() : base(Foo)
        {
        }

        #endregion

        public class GivenMetadataSpec : GivenMetadata
        {
            #region Protected Interface

            protected override Message Create(CommandId traceId, UserId userId) => new Foo(userId, traceId);

            #endregion
        }

        public class GivenNoTraceIdSpec : GivenNoTraceId
        {
            #region Creation

            public GivenNoTraceIdSpec() : base(new Foo(Guid.NewGuid()))
            {
            }

            #endregion
        }
    }
}
