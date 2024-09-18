using Application.Models;
using Application.Response;

namespace Application.Interfaces.IServices.IClientServices
{
    public interface IClientPostServices
    {
        public Task<Clients> CreateClient(ClientsRequest request);
    }
}
