namespace Jgs.Cqrs
{
    public interface IQueryHandler<in T, out TResult> where T : IQuery
    {
        TResult Handle(T query);
    }
}
