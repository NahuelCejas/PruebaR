using Domain.Entities;

namespace Application.Interfaces.IQuery
{
    public interface ICampaignTypeQuery
    {
        public Task<List<CampaignType>> GetListCampaignTypes();


    }
}
