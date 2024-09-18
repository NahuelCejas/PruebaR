
namespace Domain.Entities
{
    public class Task
    {
        public Guid TaskID { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public Guid ProjectID { get; set; }
        public int AssignedTo { get; set; }
        public int Status { get; set; }

        public Project? Projects { get; set; }
        public User? Users { get; set; }
        public TaskStatus? TaskStatus { get; set; }

    }
}
