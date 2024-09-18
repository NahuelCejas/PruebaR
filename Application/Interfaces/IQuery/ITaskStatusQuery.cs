
namespace Application.Interfaces.IQuery
{
    public interface ITaskStatusQuery
    {
        public Task<List<Domain.Entities.TaskStatus>> GetListTaskStatus();
        
    }
}
