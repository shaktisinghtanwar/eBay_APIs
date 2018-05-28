using EbaySdkLib.Constants;
using EbaySdkLib.Messages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbaySdkLib.Services
{
   public  class CatalogService
    {
       

        public CatalogService()
        {

        }
        public async Task<GetProductResponse> getProductResponse(string epid)
        {
            RestHelper helper = new RestHelper(Constants.ApplicationConstants.CATALOG_URL + epid);
            var response = await helper.Get();
            GetProductResponse getProductResponse = JsonConvert.DeserializeObject<GetProductResponse>(response);
            return getProductResponse;
        }

        public async Task<ProductSummarySearchResponse> productSummarySearchResponse(string q)
        {
            RestHelper helper = new RestHelper(Constants.ApplicationConstants.CATALOG_URL + q);
            var response = await helper.Get();
            ProductSummarySearchResponse ProductSummarySearchResponse = JsonConvert.DeserializeObject<ProductSummarySearchResponse>(response);
            return ProductSummarySearchResponse;
        }

        public async Task<GetProductMetadataResponse> getProductMetadataResponse(string epid)
        {
            RestHelper helper = new RestHelper(Constants.ApplicationConstants.PRODUCTMETADATA_URL + " ?epid = " + epid);
            var response = await helper.Get();
            GetProductMetadataResponse getProductMetadataResponse = JsonConvert.DeserializeObject<GetProductMetadataResponse>(response);
            return getProductMetadataResponse;
        }

        public async Task<GetProductMetadataForCategoriesResponse> getProductMetadataForCategoriesResponse(string primary_category_id)
        {
            RestHelper helper = new RestHelper(Constants.ApplicationConstants.PRODUCTMETADATAFORCATEGORIES_URL + " ?primary_category_id = " + primary_category_id);
            var response = await helper.Get();
            GetProductMetadataForCategoriesResponse getProductMetadataForCategoriesResponse = JsonConvert.DeserializeObject<GetProductMetadataForCategoriesResponse>(response);
            return getProductMetadataForCategoriesResponse;
        }

        public async Task<GetChangeRequestResponse> getChangeRequestResponse(string change_request_id)
        {
            RestHelper helper = new RestHelper(Constants.ApplicationConstants.GETCHANGEREQUEST_URL + " ?change_request_id = " + change_request_id);
            var response = await helper.Get();
            GetChangeRequestResponse getChangeRequestResponse = JsonConvert.DeserializeObject<GetChangeRequestResponse>(response);
            return getChangeRequestResponse;
        }


        public async Task<GetChangeRequestsResponse> getChangeRequestsResponse()
        {
            RestHelper helper = new RestHelper(Constants.ApplicationConstants.GETCHANGEREQUEST_URL);
            var response = await helper.Get();
            GetChangeRequestsResponse getChangeRequestsResponse = JsonConvert.DeserializeObject<GetChangeRequestsResponse>(response);
            return getChangeRequestsResponse;
        }


        public async Task<string> createChangeRequestService(CreateChangeRequest createChangeRequest)
        {
            var body = JsonConvert.SerializeObject(createChangeRequest);

            RestHelper helper = new RestHelper(ApplicationConstants.GETCHANGEREQUEST_URL);
            var response = await helper.Post(body);

            return response;
        }
    }
}
