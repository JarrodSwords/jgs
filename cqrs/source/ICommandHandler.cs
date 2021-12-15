﻿namespace Jgs.Cqrs
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        void Handle(T command);
    }

    public interface ICommandHandler<in T, out TResult> where T : ICommand
    {
        TResult Handle(T command);
    }
}
