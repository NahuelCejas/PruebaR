using Domain.Entities;

namespace Application.Interfaces.IQuery
{
    public interface IInteractionQuery
    {
        public Task<Interaction> GetInteractionById(Guid id);
    }
}
