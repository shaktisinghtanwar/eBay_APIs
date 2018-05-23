using EbaySdkLib.Messages;
using EbaySdkLib.Models;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace EbaySdkLib
{
    public class FulfilmentPolicyService
    {

        string _url ;
        string _deletionurlbyId;
        public FulfilmentPolicyService()
        {
           // _url = string.Format("sell/account/v1/fulfillment_policy");
        _url = string.Format("sell/account/v1/fulfillment_policy");
            _deletionurlbyId = string.Format("sell/account/v1/fulfillment_policy/");
        }

        public async Task<CreateFulfillmentResponse> CreateFulfillmentPolicy(CreateFulfillmentRequest createFulfillmentRequest)
        {
            var body = JsonConvert.SerializeObject(createFulfillmentRequest);

            RestHelper helper = new RestHelper(_url);
            var response = await helper.Post( body);

            CreateFulfillmentResponse createFulfillmentResponse = JsonConvert.DeserializeObject<CreateFulfillmentResponse>(response);
            return createFulfillmentResponse;
        }

        public async Task<CreateFulfillmentResponse> DeleteFulfillmentPolicy(CreateFulfillmentRequest createFulfillmentRequest)
        {
            var body = JsonConvert.SerializeObject(createFulfillmentRequest.marketplaceId);

            RestHelper helper = new RestHelper(_deletionurlbyId);
            var response = await helper.Delete(body);

            CreateFulfillmentResponse createFulfillmentResponse = JsonConvert.DeserializeObject<CreateFulfillmentResponse>(response);
            return createFulfillmentResponse;
        }
        public async Task<GetFulfilmentPoliciesResponse> GetFulfilmentPolicies(string marketplaceId)
        {
            var body = JsonConvert.SerializeObject(marketplaceId);

            RestHelper helper = new RestHelper("sell/account/v1/fulfillment_policy?marketplace_id=" + marketplaceId);
            var response = await helper.Get();

            GetFulfilmentPoliciesResponse getFulfillmentResponse = JsonConvert.DeserializeObject<GetFulfilmentPoliciesResponse>(response);
            return getFulfillmentResponse;
        }
    }
}
