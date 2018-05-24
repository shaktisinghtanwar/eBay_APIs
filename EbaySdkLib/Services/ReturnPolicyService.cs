using EbaySdkLib.Constants;
using EbaySdkLib.Messages;
using EbaySdkLib.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbaySdkLib.Services
    {
  public  class ReturnPolicyService
        {
      public ReturnPolicyService()
           {

           }

      public async Task<GetReturnPolicyResponse> getReturnPolicy(string return_policy_id)
           {
           RestHelper helper = new RestHelper(ApplicationConstants.RateTable_Url + return_policy_id);
           var response = await helper.Get();
           GetReturnPolicyResponse getReturnPolicyResponse = JsonConvert.DeserializeObject<GetReturnPolicyResponse>(response);
           return getReturnPolicyResponse;
           }

      public async Task<GetReturnPoliciesResponse> getReturnPolicies(string marketplaceId)
          {
          RestHelper helper = new RestHelper(ApplicationConstants.ReturnPolicy_Url + "?marketplace_id= " + marketplaceId );
          var response = await helper.Get();
          GetReturnPoliciesResponse getReturnPoliciesResponse = JsonConvert.DeserializeObject<GetReturnPoliciesResponse>(response);
          return getReturnPoliciesResponse;
          }

      public async Task<GetReturnPolicyByNameResponse> getReturnPoliciesByName(string marketplaceId,string name  )
          {
          RestHelper helper = new RestHelper(ApplicationConstants.PaymentPolicy_Url + "get_by_policy_name?marketplace_id=" + marketplaceId + "&name=" +name);
          var response = await helper.Get();
          GetReturnPolicyByNameResponse getReturnPolicyByNameResponse = JsonConvert.DeserializeObject<GetReturnPolicyByNameResponse>(response);
          return getReturnPolicyByNameResponse;
          }

      public async Task<CreateReturnPolicyResponse> createReturnPolicyService(CreateReturnPolicyrequest createReturnPolicyrequest)
          {
          var body = JsonConvert.SerializeObject(createReturnPolicyrequest);
          RestHelper helper = new RestHelper(ApplicationConstants.ReturnPolicy_Url);
          var response = await helper.Post(body);
          CreateReturnPolicyResponse createReturnpolicyResponse = JsonConvert.DeserializeObject<CreateReturnPolicyResponse>(response);
          return createReturnpolicyResponse;
          }

      public async Task<string> deleteReturnPolicyService(string Id)
          {
          RestHelper helper = new RestHelper(ApplicationConstants.ReturnPolicy_Url+"{"+Id+"}");
          var response = await helper.Delete(Id);
          return response;
          }
      public async Task<UpdatereturnPolicyresponse> updateReturnPolicyService(UpdateReturnPolicyRequest updateReturnPolicyRequest, string Id)
          {
          var body = JsonConvert.SerializeObject(updateReturnPolicyRequest);
          RestHelper helper = new RestHelper(ApplicationConstants.ReturnPolicy_Url + "{" + Id + "}");
          var response = await helper.Put(body);
          UpdatereturnPolicyresponse updatereturnPolicyresponse = JsonConvert.DeserializeObject<UpdatereturnPolicyresponse>(response);
          return updatereturnPolicyresponse;
          }

        }
    }
