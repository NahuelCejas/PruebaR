
namespace Domain.Entities
{
    public class CampaignType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Project> ListProjects { get; set; }
    }
}
