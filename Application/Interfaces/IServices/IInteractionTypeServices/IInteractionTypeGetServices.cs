using Application.Response;

namespace Application.Interfaces.IServices.IInteractionTypeServices
{
    public interface IInteractionTypeGetServices
    {
        public Task<List<GenericResponse>> GetAll();
    }
}
