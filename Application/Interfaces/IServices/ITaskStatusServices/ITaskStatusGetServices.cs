using Application.Response;

namespace Application.Interfaces.IServices.ITaskStatusServices
{
    public interface ITaskStatusGetServices
    {
        public Task<List<GenericResponse>> GetAll();
    }
}
