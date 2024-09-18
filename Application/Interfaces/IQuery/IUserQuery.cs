using Domain.Entities;

namespace Application.Interfaces.IQuery
{
    public interface IUserQuery
    {
        public Task<List<User>> GetListUsers();       
    }
}
