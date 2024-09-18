using Domain.Entities;

namespace Application.Interfaces.IQuery
{
    public interface IInteractionTypeQuery
    {
        public Task<List<InteractionType>> GetListInteractionTypes();

        public Task<InteractionType> GetInteractionTypeById(int id);
    }
}
