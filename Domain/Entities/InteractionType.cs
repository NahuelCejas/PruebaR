
namespace Domain.Entities
{
    public class InteractionType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Interaction> ListInteractions { get; set; }
    }
}
