using Application.Interfaces.ICommand;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Command
{
    public class ProjectCommand : IProjectCommand
    {
        private readonly AppDBContext _context;

        public ProjectCommand(AppDBContext context)
        {
            _context = context;
        }

        public async System.Threading.Tasks.Task InsertProject(Project project)
        {
           _context.Add(project);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task UpdateProject(Project project)
        {
            _context.Update(project);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task AddProjectInteractions(Domain.Entities.Interaction interaction)
        {
           _context.Add(interaction);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task AddProjectTasks(Domain.Entities.Task task)
        {
            _context.Add(task);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task UpdateProjectTasks(Domain.Entities.Task task)
        {
            _context.Update(task);
            await _context.SaveChangesAsync();
        }

       
    }
}
