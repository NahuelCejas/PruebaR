using Application.Models;
using Application.Response;

namespace Application.Interfaces.IServices.IProjectServices
{
    public interface IProjectPutServices
    {
        public Task<Tasks> UpdateTask(Guid taskId, TasksRequest request);

    }


}
