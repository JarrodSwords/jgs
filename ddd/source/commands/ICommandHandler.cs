namespace Jgs.Ddd
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        IResult Handle(T command);
    }
}
