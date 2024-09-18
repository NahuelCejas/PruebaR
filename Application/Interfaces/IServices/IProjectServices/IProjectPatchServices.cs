using Application.Models;
using Application.Request;
using Application.Response;

namespace Application.Interfaces.IServices.IProjectServices
{
    public interface IProjectPatchServices
    {
        public Task<Interactions> AddInteraction(Guid projectId, InteractionsRequest request);
        public Task<Tasks> AddTask(Guid projectId, TasksRequest request);
    }


}
