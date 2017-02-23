using System;

namespace CqrsCore.commands
{
    interface ICommand
    {
        Guid Id { get; }
    }
}
