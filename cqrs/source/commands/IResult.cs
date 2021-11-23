namespace Jgs.Cqrs
{
    public interface IResult
    {
        bool WasFailure();
        bool WasSuccessful();
    }
}
