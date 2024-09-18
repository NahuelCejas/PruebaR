using Application.Exceptions;
using Application.Interfaces.IQuery;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Query
{
    public class TaskQuery : ITaskQuery
    {
        private readonly AppDBContext _context;

        public TaskQuery(AppDBContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.Task> GetTaskById(Guid TaskId)
        {
            var result = await _context.Tasks
                .Include(t => t.Users)
                .Include(t => t.TaskStatus)
                .FirstOrDefaultAsync(t => t.TaskID == TaskId);

            if (result == null)
            {
                throw new NotFoundException("Task not found");
            }

            return result;
        }

       

    }
}
