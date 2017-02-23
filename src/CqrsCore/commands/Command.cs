using System;

namespace CqrsCore.commands
{
    public class Command : ICommand
    {
        public Command(Guid id, int version)
        {
            Id = id;
            Version = version;
        }

        public Guid Id { get; }
        public int Version { get; }
    }
}
