using Application.Response;

namespace Application.Interfaces.IServices.IUserServices
{
    public interface IUserGetServices
    {
        public Task<List<Users>> GetAll();
    }
}
