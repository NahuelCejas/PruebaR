using Application.Interfaces.ICommand;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Command
{
    public class ClientCommand : IClientCommand
    {
        private readonly AppDBContext _context;

        public ClientCommand(AppDBContext context)
        {
            _context = context;
        }

        public async System.Threading.Tasks.Task InsertClient(Client client)
        {
            _context.Add(client);
          
            await _context.SaveChangesAsync();
        }
    }
}
