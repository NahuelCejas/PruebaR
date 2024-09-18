using Application.Response;

namespace Application.Interfaces.IServices.IClientServices
{
    public interface IClientGetServices
    { 
        public Task<List<Clients>> GetAll();
    }
}
