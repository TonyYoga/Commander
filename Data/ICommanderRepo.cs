
using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        public IEnumerable<Command> GetAllCommands();
        public Command GetCommandById(int id);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void Delete(Command cmd);
    }
}
