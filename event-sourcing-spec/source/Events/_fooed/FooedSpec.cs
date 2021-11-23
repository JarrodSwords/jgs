using Jgs.EventSourcing.Messages;
using Jgs.EventSourcing.Spec.Messages;

namespace Jgs.EventSourcing.Spec.Events
{
    public class FooedSpec : MessageSpec
    {
        private static readonly Fooed Fooed = new(new CommandId(), new UserId());

        #region Creation

        public FooedSpec() : base(Fooed)
        {
        }

        #endregion

        public class GivenMetadataSpec : GivenMetadata
        {
            #region Protected Interface

            protected override Message Create(CommandId traceId, UserId userId) => new Fooed(traceId, userId);

            #endregion
        }
    }
}
