using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SixminApi.Models;

namespace SixminApi.Data
{
    public interface ICommandRepo
    {
        Task SaveChanges();
        Task<IEnumerable<Command>> GetAllCommands();
        Task<Command?> GetCommandById(int id);
        void CreateCommand(Command cmd);
        void DeleteCommand(Command cmd);

    }
}