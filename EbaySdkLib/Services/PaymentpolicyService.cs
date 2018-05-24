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
   public class PaymentpolicyService
    {
       public PaymentpolicyService()
           {

           }

       public async Task<GetPaymentpolicyresponse> getPaymentpolicyService(string policyId)
           {
           RestHelper helper = new RestHelper(ApplicationConstants.PaymentPolicy_Url + policyId);
           var response = await helper.Get();
           GetPaymentpolicyresponse getPaymentpolicyResponse = JsonConvert.DeserializeObject<GetPaymentpolicyresponse>(response);
           return getPaymentpolicyResponse;
           }

       public async Task<GetPaymentpoliciesResponse> getPaymentpoliciesService(string marketplaceId)
           {
           RestHelper helper = new RestHelper("sell/account/v1/payment_policy?marketplace_id={"+ marketplaceId+"}");
           var response = await helper.Get();
           GetPaymentpoliciesResponse getPaymentpoliciesResponse = JsonConvert.DeserializeObject<GetPaymentpoliciesResponse>(response);
           return getPaymentpoliciesResponse;
           }

       public async Task<GetPaymentpolicyByNameresponse> getPaymentPolicyByNameService(string name,string marketplaceId)
           {
           RestHelper helper = new RestHelper(ApplicationConstants.PaymentPolicy_Url+ "get_by_policy_name?name="+name+"&marketplace_id=" + marketplaceId);
           var response = await helper.Get();
           GetPaymentpolicyByNameresponse getPaymentpolicyByNameresponse = JsonConvert.DeserializeObject<GetPaymentpolicyByNameresponse>(response);
           return getPaymentpolicyByNameresponse;
           }
       
    }
}
