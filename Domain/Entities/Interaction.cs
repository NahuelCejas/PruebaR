
namespace Domain.Entities
{
    public class Interaction
    {
        public Guid InteractionID { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }

        public Guid ProjectID { get; set; }
        public int InteractionType { get; set; }

        public Project? Projects { get; set; }
        public InteractionType? InteractionTypes { get; set; }
    }
}
