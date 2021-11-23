namespace Jgs.Ddd
{
    public interface IResult
    {
        bool WasFailure();
        bool WasSuccessful();
    }
}
