using Application.Response;

namespace Application.Interfaces.IServices.IProjectServices
{
    public interface IProjectGetServices
    {
        public Task<ProjectDetails> GetProjectById(Guid projectId);

        Task<List<Response.Project>> GetProjects(string? name, int? campaign, int? client, int? offset, int? size);

    }


}
