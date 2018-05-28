using EbaySdkLib.Constants;
using EbaySdkLib.Messages;
using EbaySdkLib.Services;
using Newtonsoft.Json;
using System.Threading.Tasks;


namespace EbaySdkLib.Services
{
   public  class MarketingAPIService
    {

        string _urlGetReportid;
        string _urlGetReportMetadata;
        string _urlgetReportMetadataForReport;
        string _urlCreateReportTask;
        string _urldeleteReportTask;
        string _urlgetReportTask;
        public MarketingAPIService()
            {

            _urlGetReportid = string.Format("sell/marketing/v1/ad_report/");
            _urlGetReportMetadata = string.Format("sell/marketing/v1/ad_report_metadata/");
            _urlgetReportMetadataForReport = string.Format("sell/marketing/v1/ad_report_metadata/ACCOUNT_PERFORMANCE_REPORT/");
            _urlCreateReportTask = string.Format("sell/marketing/v1/ad_report_task");
            _urldeleteReportTask = string.Format("sell/marketing/v1/ad_report_task/");
            _urlgetReportTask = string.Format("sell/marketing/v1/ad_report_task/");
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

    #region lodhisir
        public async Task<bulkCreateAdsByInventoryReferenceRequest> bulkCreateAdsByInventory(bulkCreateAdsByInventoryReferenceRequest bulkCreateAdsByInventory,string campaign_id, string bulk_create_ads)
        {
            var body = JsonConvert.SerializeObject(bulkCreateAdsByInventory);
            RestHelper helper = new RestHelper(ApplicationConstants.BULKCREATEADSBYINVENTORY_URL+ campaign_id+"/"+ bulk_create_ads);
            var response = await helper.Post(body);
            bulkCreateAdsByInventoryReferenceRequest bulkCreateAdsResponse = JsonConvert.DeserializeObject<bulkCreateAdsByInventoryReferenceRequest>(response);

            return bulkCreateAdsResponse;
        }
        public async Task<bulkCreateAdsByInventoryReferenceRequest> bulkCreateAdsByListingId(bulkCreateAdsByInventoryReferenceRequest bulkCreateAdsByInventory,string campaign_id,string bulk_create_ads_by_listing)
        {
            var body = JsonConvert.SerializeObject(bulkCreateAdsByInventory);
            RestHelper helper = new RestHelper(ApplicationConstants.BULKCREATEADSBYINVENTORY_URL + campaign_id+"/"+ bulk_create_ads_by_listing);
            var response = await helper.Post(body);
            bulkCreateAdsByInventoryReferenceRequest bulkCreateAds = JsonConvert.DeserializeObject<bulkCreateAdsByInventoryReferenceRequest>(response);
            return bulkCreateAds;
        }

        
        public async Task<bulkCreateAdsByInventoryReferenceRequest> bulkDeleteAdsByInventoryReference(bulkCreateAdsByInventoryReferenceRequest bulkDeleteAdsByInventory,string campaign_id,string bulk_delete_ads_by_inventory)
        {
            var body = JsonConvert.SerializeObject(bulkDeleteAdsByInventory);
            RestHelper helper = new RestHelper(ApplicationConstants.BULKCREATEADSBYINVENTORY_URL+ campaign_id + "/" + bulk_delete_ads_by_inventory);
            var response = await helper.Post(body);
            bulkCreateAdsByInventoryReferenceRequest bulkDeleteAdsByInventoryResponse = JsonConvert.DeserializeObject<bulkCreateAdsByInventoryReferenceRequest>(response);
            return bulkDeleteAdsByInventoryResponse;
        }
        public async Task<bulkCreateAdsByInventoryReferenceRequest> bulkDeleteAdsByListingId(bulkCreateAdsByInventoryReferenceRequest bulkDeleteAdsByListingId,string campaign_id,string bulkDeleteAdsByListing)
        {
            var body = JsonConvert.SerializeObject(bulkDeleteAdsByListingId);
            RestHelper helper = new RestHelper(ApplicationConstants.BULKCREATEADSBYINVENTORY_URL + campaign_id + "/" + bulkDeleteAdsByListing);
            var response = await helper.Post(body);
            bulkCreateAdsByInventoryReferenceRequest bulkDeleteAdsByListingIdResponse = JsonConvert.DeserializeObject<bulkCreateAdsByInventoryReferenceRequest>(response);
            return bulkDeleteAdsByListingIdResponse;
        }
        public async Task<bulkCreateAdsByInventoryReferenceRequest>bulkUpdateAdsBidByInventoryReference(bulkCreateAdsByInventoryReferenceRequest bulkUpdateAdsBidByInventory,string campaign_id,string bulk_update_ads)
        {
            var body = JsonConvert.SerializeObject(bulkUpdateAdsBidByInventory);
            RestHelper helper = new RestHelper(ApplicationConstants.BULKCREATEADSBYINVENTORY_URL + campaign_id + "/" + bulk_update_ads);
            var response = await helper.Post(body);
            bulkCreateAdsByInventoryReferenceRequest bulkUpdateAdsBidByInventoryResponse = JsonConvert.DeserializeObject<bulkCreateAdsByInventoryReferenceRequest>(response);
            return bulkUpdateAdsBidByInventoryResponse;
        }
        public async Task<bulkCreateAdsByInventoryReferenceRequest> bulkUpdateAdsBidByListingId(bulkCreateAdsByInventoryReferenceRequest bulkUpdateAdsBidByListingId,string campaign_id, string bulk_update_ads_by_listing)
        {
            var body = JsonConvert.SerializeObject(bulkUpdateAdsBidByListingId);
            RestHelper helper = new RestHelper(ApplicationConstants.BULKCREATEADSBYINVENTORY_URL + campaign_id + "/" + bulk_update_ads_by_listing);
            var response = await helper.Post(body);
            bulkCreateAdsByInventoryReferenceRequest bulkUpdateAdsBidByListingResponse = JsonConvert.DeserializeObject<bulkCreateAdsByInventoryReferenceRequest>(response);
            return bulkUpdateAdsBidByListingResponse;
        }
        public async Task<bulkCreateAdsByInventoryReferenceRequest> createAdByListingId(bulkCreateAdsByInventoryReferenceRequest createAdByListingId,string campaign_id,string createAd)
        {
            var body = JsonConvert.SerializeObject(createAdByListingId);
            RestHelper helper = new RestHelper(ApplicationConstants.BULKCREATEADSBYINVENTORY_URL + campaign_id + "/" + createAd);
            var response = await helper.Post(body);
            bulkCreateAdsByInventoryReferenceRequest createAdByListingResponse = JsonConvert.DeserializeObject<bulkCreateAdsByInventoryReferenceRequest>(response);
            return createAdByListingResponse;
        }
        public async Task<bulkCreateAdsByInventoryReferenceRequest> createAdsByInventoryReference(bulkCreateAdsByInventoryReferenceRequest createAdsByInventoryReference,string campaign_id, string create_ads_by_inventory)
        {
            var body = JsonConvert.SerializeObject(createAdsByInventoryReference);
            RestHelper helper = new RestHelper(ApplicationConstants.BULKCREATEADSBYINVENTORY_URL + campaign_id + "/" + create_ads_by_inventory);
            var response = await helper.Post(body);
            bulkCreateAdsByInventoryReferenceRequest createAdsByInventoryReferenceResponse = JsonConvert.DeserializeObject<bulkCreateAdsByInventoryReferenceRequest>(response);
            return createAdsByInventoryReferenceResponse;
        }

        public async Task<bulkCreateAdsByInventoryReferenceRequest> deleteAd(bulkCreateAdsByInventoryReferenceRequest deleteAd,string campaign_id,string deletead,string addid)
        {
            var body = JsonConvert.SerializeObject(deleteAd);
            RestHelper helper = new RestHelper(ApplicationConstants.BULKCREATEADSBYINVENTORY_URL + campaign_id + "/" + deletead+"/"+ addid);
            var response = await helper.Delete(body);
            bulkCreateAdsByInventoryReferenceRequest deleteAdResponse = JsonConvert.DeserializeObject<bulkCreateAdsByInventoryReferenceRequest>(response);
            return deleteAdResponse;
        }
        public async Task<bulkCreateAdsByInventoryReferenceRequest> deleteAdsByInventoryReference(bulkCreateAdsByInventoryReferenceRequest deleteAdsByInventoryReference, string campaign_id,string delete_ads)
        {
            var body = JsonConvert.SerializeObject(deleteAdsByInventoryReference);
            RestHelper helper = new RestHelper(ApplicationConstants.BULKCREATEADSBYINVENTORY_URL + campaign_id + "/" + delete_ads);
            var response = await helper.Post(body);
            bulkCreateAdsByInventoryReferenceRequest deleteAdsByInventoryReferenceResponse = JsonConvert.DeserializeObject<bulkCreateAdsByInventoryReferenceRequest>(response);
            return deleteAdsByInventoryReferenceResponse;
        }
        public async Task<bulkCreateAdsByInventoryReferenceRequest> getAd(bulkCreateAdsByInventoryReferenceRequest getAd,string campaign_id,string ad ,string adId)
        {
           // var body = JsonConvert.SerializeObject(getAd);
            RestHelper helper = new RestHelper(ApplicationConstants.BULKCREATEADSBYINVENTORY_URL + campaign_id + "/" + ad+"/"+ adId);
            var response = await helper.Get();
            bulkCreateAdsByInventoryReferenceRequest getAdResponse = JsonConvert.DeserializeObject<bulkCreateAdsByInventoryReferenceRequest>(response);
            return getAdResponse;
        }
        public async Task<GetAdsResponse> getAds(string campaign_id,string ad)
        {
            // var body = JsonConvert.SerializeObject(getAd);
            RestHelper helper = new RestHelper(ApplicationConstants.BULKCREATEADSBYINVENTORY_URL + campaign_id + "/" + ad );
            var response = await helper.Get();
            GetAdsResponse getAdsResponse = JsonConvert.DeserializeObject<GetAdsResponse>(response);
            return getAdsResponse;
        }
        public async Task<bulkCreateAdsByInventoryReferenceRequest> getAdsByInventoryReference(bulkCreateAdsByInventoryReferenceRequest getAdsByInventoryReference,string campaign_id,string getads)
        {     
            RestHelper helper = new RestHelper(ApplicationConstants.BULKCREATEADSBYINVENTORY_URL + campaign_id + "/" + getads + "inventory_reference_id=" + getAdsByInventoryReference.inventoryReferenceId + "&inventory_reference_type=" + getAdsByInventoryReference.inventoryReferenceType);
            var response = await helper.Get();
            bulkCreateAdsByInventoryReferenceRequest getAdsByInventoryReferenceResponse = JsonConvert.DeserializeObject<bulkCreateAdsByInventoryReferenceRequest>(response);
            return getAdsByInventoryReferenceResponse;
        }
        public async Task<bulkCreateAdsByInventoryReferenceRequest> updateBid(bulkCreateAdsByInventoryReferenceRequest updateBid,string campaign_id,string updatead,string adId,string update_bid)
        {
            var body = JsonConvert.SerializeObject(updateBid);
            RestHelper helper = new RestHelper(ApplicationConstants.BULKCREATEADSBYINVENTORY_URL + campaign_id + "/" + updatead +"/"+ adId+"/"+ update_bid);
            var response = await helper.Post(body);
            bulkCreateAdsByInventoryReferenceRequest updateBidResponse = JsonConvert.DeserializeObject<bulkCreateAdsByInventoryReferenceRequest>(response);
            return updateBidResponse;
        }
        public async Task<string> getReport(string reportid)
        {      
            RestHelper helper = new RestHelper(ApplicationConstants.GETREPORT_URL + reportid);
            var response = await helper.Get();
            var getReportResponse = JsonConvert.DeserializeObject<string>(response);
            return getReportResponse;
        }
        public async Task<GetReportMetadataResponse> getReportMetadata() 
        {
            RestHelper helper = new RestHelper(ApplicationConstants.GETREPORTMETADATA_URL);
            var response = await helper.Get();
            GetReportMetadataResponse getReportMetadataResponse = JsonConvert.DeserializeObject<GetReportMetadataResponse>(response);
            return getReportMetadataResponse;
        }
        public async Task<GetReportMetadataResponse> getReportMetadataForReportType(GetReportMetadataResponse reportmetadata) 
        {
            RestHelper helper = new RestHelper(ApplicationConstants.GETREPORTMETADATA_URL+ reportmetadata);
            var response = await helper.Get();
            GetReportMetadataResponse getReportMetadataResponse = JsonConvert.DeserializeObject<GetReportMetadataResponse>(response);
            return getReportMetadataResponse;
        }
        public async Task<CreateReportTaskRequest> createReportTask(CreateReportTaskRequest createReportTask) 
        {
            var body = JsonConvert.SerializeObject(createReportTask);
            RestHelper helper = new RestHelper(ApplicationConstants.ADDREPORTTASK_URL);
            var response = await helper.Post(body);
            CreateReportTaskRequest createReportTaskResponse = JsonConvert.DeserializeObject<CreateReportTaskRequest>(response);
            return createReportTaskResponse;
        }
        public async Task<CreateReportTaskRequest> deleteReportTask(string reportTaskId)
        {
            var body = JsonConvert.SerializeObject(reportTaskId);
            RestHelper helper = new RestHelper(ApplicationConstants.ADDREPORTTASK_URL+"/" + reportTaskId);
            var response = await helper.Delete(body);
            CreateReportTaskRequest deleteReportTaskResponse = JsonConvert.DeserializeObject<CreateReportTaskRequest>(response);
            return deleteReportTaskResponse;
        }
        public async Task<CreateReportTaskRequest> getReportTask(string reportTaskId) 
        {
            RestHelper helper = new RestHelper(ApplicationConstants.ADDREPORTTASK_URL +"/"+ reportTaskId);
            var response = await helper.Get();
            CreateReportTaskRequest getReportTaskResponse = JsonConvert.DeserializeObject<CreateReportTaskRequest>(response);
            return getReportTaskResponse;
        }
        public async Task<CreateReportTaskRequest> getReportTasks(string reportTaskstatus,string limit )
        {
            RestHelper helper = new RestHelper(ApplicationConstants.ADDREPORTTASK_URL + "?report_task_statuses="+ reportTaskstatus + "&limit=" + limit);
            var response = await helper.Get();
            CreateReportTaskRequest getReportTasksResponse = JsonConvert.DeserializeObject<CreateReportTaskRequest>(response);
            if (getReportTasksResponse != null)
            {
                
            }
            return getReportTasksResponse;
        }

    #endregion


    }
   

}
