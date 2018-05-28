using EbaySdkLib.Constants;
using EbaySdkLib.Messages;
using EbaySdkLib.Services;
using Newtonsoft.Json;
using System.Threading.Tasks;


namespace EbaySdkLib.Services
{
   public  class MarketingAPIService
    {
     
       public MarketingAPIService()
       {
          
       }
       
       public async Task<string>CloneMarketing(CloneCampaignRequest cloneCampaignRequest,string campaign_id)
       {
           var body = JsonConvert.SerializeObject(cloneCampaignRequest);
           RestHelper helper = new RestHelper(ApplicationConstants._URLCOMPAIGN + campaign_id + "/" + "clone");
           var response = await helper.Post(body);    // response is not match with ebay response
           return response;
       }
       public async Task<CreateCampaignResponse> CreateMarketing(CreateCampaignRequest createCampaignRequest)
       {
           var body = JsonConvert.SerializeObject(createCampaignRequest);
           RestHelper helper = new RestHelper(ApplicationConstants._URLCOMPAIGN);
           var response = await helper.Post(body);   
           CreateCampaignResponse createCampaignResponse = JsonConvert.DeserializeObject<CreateCampaignResponse>(response);
           return createCampaignResponse;
       }
       public async Task<DeleteCampaignResponse> DeleteMarketing(string campaign_id )
       {

           RestHelper helper = new RestHelper(ApplicationConstants._URLCOMPAIGN + campaign_id);
           var response = await helper.Delete(campaign_id);   
           DeleteCampaignResponse deleteCampaignResponse = JsonConvert.DeserializeObject<DeleteCampaignResponse>(response);
           return deleteCampaignResponse;
       }
       public async Task<EndCampaignResponse> EndCampaign(string campaign_id) 
       {

           RestHelper helper = new RestHelper(ApplicationConstants._URLCOMPAIGN + campaign_id + "/" + "end");
           var response = await helper.Post(campaign_id);    
           EndCampaignResponse endCampaignResponse = JsonConvert.DeserializeObject<EndCampaignResponse>(response);
           return endCampaignResponse;
       }
       public async Task<GetCampaignResponse> GetCampaign(string campaign_id)
       {

           RestHelper helper = new RestHelper(ApplicationConstants._URLCOMPAIGN + campaign_id);
           var response = await helper.Get();
           GetCampaignResponse getCampaignResponse = JsonConvert.DeserializeObject<GetCampaignResponse>(response);
           return getCampaignResponse;
       }
       public async Task<GetCampaignByNameResponse> GetCampaignByNameRequest(string campaignName)
       {

           RestHelper helper = new RestHelper(ApplicationConstants._URLCOMPAIGN + "get_campaign_by_name" + "?campaign_name=" + campaignName);
           var response = await helper.Get();
           GetCampaignByNameResponse  getCampaignByNameResponse  = JsonConvert.DeserializeObject<GetCampaignByNameResponse>(response);
           return getCampaignByNameResponse  ;
       }
        public async Task<GetCampaignsResponse> GetCampaigns(string campaignName, string campaignStatus , string startDate, string endDate, string limit,string offset)
        {

            RestHelper helper = new RestHelper(ApplicationConstants._URLCOMPAIGN + "?campaign_status=" + campaignStatus + "&start_date_range=" + startDate + "&end_date_range=" + endDate + "&campaign_name=" + campaignName + "&limit=" + limit + "&offset=" + offset);
            var response = await helper.Get();
            GetCampaignsResponse getCampaignsResponse = JsonConvert.DeserializeObject<GetCampaignsResponse>(response);
            return getCampaignsResponse;
        }
        public async Task<PauseCampaignResponse> PauseCampaign(string campaign_id)
        {
            //without request payload how can  i send a body within a post method
            var body = JsonConvert.SerializeObject(campaign_id);
            RestHelper helper = new RestHelper(ApplicationConstants._URLCOMPAIGN + campaign_id + "/" + "pause");
            var response = await helper.Post(body);
            PauseCampaignResponse pauseCampaignResponse = JsonConvert.DeserializeObject<PauseCampaignResponse>(response);
            return pauseCampaignResponse;
        }
        public async Task<ResumeCampaignResponse> ResumeCampaign(string campaign_id)
        {   //without request payload how can  i send a body within a post method
            var body = JsonConvert.SerializeObject(campaign_id);
            RestHelper helper = new RestHelper(ApplicationConstants._URLCOMPAIGN + campaign_id + "/" + "resume");
            var response = await helper.Post(body);
            ResumeCampaignResponse resumeCampaignResponse = JsonConvert.DeserializeObject<ResumeCampaignResponse>(response);
            return resumeCampaignResponse;
        }
        public async Task<UpdateCampaignIdentificationResponse> UpdateCampaignIdentification(UpdateCampaignIdentificationRequest updateCampaignIdentificationRequest, string campaign_id)
        {  
            var body = JsonConvert.SerializeObject(updateCampaignIdentificationRequest);
            RestHelper helper = new RestHelper(ApplicationConstants._URLCOMPAIGN + campaign_id + "/" + "update_campaign_identification");
            var response = await helper.Post(body);
            UpdateCampaignIdentificationResponse updateCampaignIdentificationResponse = JsonConvert.DeserializeObject<UpdateCampaignIdentificationResponse>(response);
            return updateCampaignIdentificationResponse;
        }

        public async Task<CreateItemPromotionResponse> CreateItemPromotion(CreateItemPromotionRequest createItemPromotionRequest)
        {
            var body = JsonConvert.SerializeObject(createItemPromotionRequest);
            RestHelper helper = new RestHelper(ApplicationConstants._URLPROMOTION);
            var response = await helper.Post(body);
            CreateItemPromotionResponse createItemPromotionResponse = JsonConvert.DeserializeObject<CreateItemPromotionResponse>(response);
            return createItemPromotionResponse;
        }
        public async Task<string> DeleteItemPromotion(string campaign_id)
        {

            RestHelper helper = new RestHelper(ApplicationConstants._URLPROMOTION + campaign_id);
            var response = await helper.Delete(campaign_id);
            return response;
        }




    }
   

}
