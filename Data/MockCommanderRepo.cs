using System.Collections.Generic;
using CommandsPrj.Models;

namespace CommandsPrj.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }


        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            
            var commands = new List<Command>
            {
                new Command{Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Egg and co"},
                new Command{Id = 1, HowTo = "Cut bread", Line = "Get knife", Platform = "Bread and co"},
                new Command{Id = 2, HowTo = "Make cup of tea", Line = "Place teabag in cup", Platform = "Tea and co"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Egg and co"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}