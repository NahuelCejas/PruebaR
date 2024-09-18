
namespace Application.Interfaces.IQuery
{
    public interface ITaskQuery
    {
        public Task<Domain.Entities.Task> GetTaskById(Guid TaskId);
    }
}
