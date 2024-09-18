using Application.Response;

namespace Application.Interfaces.IServices.ICampaignTypeServices
{
    public interface ICampaignTypeGetServices
    {
        public Task<List<GenericResponse>> GetAll();
    }
}
