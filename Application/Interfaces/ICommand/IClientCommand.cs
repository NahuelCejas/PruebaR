using Domain.Entities;
using Task = System.Threading.Tasks.Task;


namespace Application.Interfaces.ICommand
{
    public interface IClientCommand
    {
        public Task InsertClient(Client client);
    }
}
