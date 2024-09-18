using Domain.Entities;

namespace Application.Interfaces.IQuery
{
    public interface IClientQuery
    {
        public Task<List<Client>> GetListClients();
        public Task<bool> ClientExists(int id);

    }
}
