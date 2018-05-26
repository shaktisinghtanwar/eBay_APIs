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
        string _getUrlByname;
        string _updateUrl;


        public FulfilmentPolicyService()
        {
           // _url = string.Format("sell/account/v1/fulfillment_policy");
        _url = string.Format("sell/account/v1/fulfillment_policy");
        _deletionurlbyId = string.Format("sell/account/v1/fulfillment_policy");
     
        
        }

        public async Task<CreateFulfillmentResponse> CreateFulfillmentPolicy(CreateFulfillmentRequest createFulfillmentRequest)
        {
            var body = JsonConvert.SerializeObject(createFulfillmentRequest);

            RestHelper helper = new RestHelper(_url);
            var response = await helper.Post( body);

            CreateFulfillmentResponse createFulfillmentResponse = JsonConvert.DeserializeObject<CreateFulfillmentResponse>(response);
            return createFulfillmentResponse;
        }



        public async Task<DeleteFulfillmentPolicyResponse> DeleteFulfillmentPolicy(string fulfillmentPolicyId)
        {
            //  var body = JsonConvert.SerializeObject(fulfillmentPolicyId);

            RestHelper helper = new RestHelper(_deletionurlbyId + fulfillmentPolicyId);
            var response = await helper.Delete(fulfillmentPolicyId);

            DeleteFulfillmentPolicyResponse deleteFulfillmentPolicyResponse = JsonConvert.DeserializeObject<DeleteFulfillmentPolicyResponse>(response);
            return deleteFulfillmentPolicyResponse;
        }



        public async Task<GetFulfilmentPoliciesResponse> GetFulfilmentPolicies(string marketplaceId)
        {
            

            RestHelper helper = new RestHelper("sell/account/v1/fulfillment_policy?marketplace_id=" + marketplaceId);
            var response = await helper.Get();

            GetFulfilmentPoliciesResponse getFulfillmentResponse = JsonConvert.DeserializeObject<GetFulfilmentPoliciesResponse>(response);
            return getFulfillmentResponse;
        }



        public async Task<GetFulfillmentpolicyByNameResponse> GetFulfillmentPolicyByName(string name, string marketplaceId)
        {
           // var body = JsonConvert.SerializeObject(name);

            RestHelper helper = new RestHelper("sell/account/v1/fulfillment_policy/?name="+name  + "marketplace_id="+  marketplaceId);
            var response = await helper.Get();

         GetFulfillmentpolicyByNameResponse getFulfillmentPolicyByNameResponse = JsonConvert.DeserializeObject<GetFulfillmentpolicyByNameResponse>(response);
            return getFulfillmentPolicyByNameResponse;
        }

        public async Task<UpdateFulfillmentPolicyResponse> UpdateFulfillmentPolicy(string fulfillmentPolicyId)
        {
            
           // var body = JsonConvert.SerializeObject(fulfillmentPolicyId);

            RestHelper helper = new RestHelper("sell/account/v1/fulfillment_policy/Fulfillpolicyid=" + fulfillmentPolicyId);
            var response = await helper.Put(fulfillmentPolicyId);

            UpdateFulfillmentPolicyResponse updateFulfillmentPolicyResponse = JsonConvert.DeserializeObject<UpdateFulfillmentPolicyResponse>(response);
            return updateFulfillmentPolicyResponse;
        }

        public async Task<GetFulfillmentPolicyResponse> GetFulfillmentPolicy(string fulfillmentPolicyId)
        {

            RestHelper helper = new RestHelper("sell/account/v1/fulfillment_policy/Fulfillpolicyid=" + fulfillmentPolicyId);
            var response = await helper.Get();

            GetFulfillmentPolicyResponse getFulfillmentPolicyResponse = JsonConvert.DeserializeObject<GetFulfillmentPolicyResponse>(response);
            return getFulfillmentPolicyResponse;
        }

    }
}
