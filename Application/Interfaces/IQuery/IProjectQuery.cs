using Domain.Entities;

namespace Application.Interfaces.IQuery
{
    public interface IProjectQuery
    {
        public Task<Project> GetProjectById(Guid id);
        public Task<Project> GetProjectByName(string name);
        public Task<IEnumerable<Project>> GetProjects(string? name, int? campaign, int? client, int? offset, int? size);
        
    }
}
