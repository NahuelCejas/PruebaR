using Application.Request;
using Application.Response;

namespace Application.Interfaces.IServices.IProjectServices
{
    public interface IProjectPostServices
    {
        public Task<ProjectDetails> CreateProject(ProjectRequest request);
    }


}
