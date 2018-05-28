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
            RestHelper helper = new RestHelper("sell/account/v1/payment_policy?marketplace_id={" + marketplaceId + "}");
            var response = await helper.Get();
            GetPaymentpoliciesResponse getPaymentpoliciesResponse = JsonConvert.DeserializeObject<GetPaymentpoliciesResponse>(response);
            return getPaymentpoliciesResponse;
            }

        public async Task<GetPaymentpolicyByNameresponse> getPaymentPolicyByNameService(string name, string marketplaceId)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.PaymentPolicy_Url + "get_by_policy_name?name=" + name + "&marketplace_id=" + marketplaceId);
            var response = await helper.Get();
            GetPaymentpolicyByNameresponse getPaymentpolicyByNameresponse = JsonConvert.DeserializeObject<GetPaymentpolicyByNameresponse>(response);
            return getPaymentpolicyByNameresponse;
            }

        public async Task<Createpaymentpolicyresponse> createPaymentPolicyService(CreatePaymerntPolicyRequest createPaymerntPolicyRequest)
            {
            var body = JsonConvert.SerializeObject(createPaymerntPolicyRequest);
            RestHelper helper = new RestHelper(ApplicationConstants.PaymentPolicy_Url);
            var response = await helper.Post(body);
            Createpaymentpolicyresponse createpaymentpolicyresponse = JsonConvert.DeserializeObject<Createpaymentpolicyresponse>(response);
            return createpaymentpolicyresponse;
            }


        public async Task<updatePaymentPolicyResponse> updatePaymentPolicyService(updatePaymentPolicyRequest updatePaymentPolicyrequest, string Id)
            {
            var body = JsonConvert.SerializeObject(updatePaymentPolicyrequest);
            RestHelper helper = new RestHelper(ApplicationConstants.PaymentPolicy_Url  + Id );
            var response = await helper.Put(body);
            updatePaymentPolicyResponse updatePaymentPolicyresponse = JsonConvert.DeserializeObject<updatePaymentPolicyResponse>(response);
            return updatePaymentPolicyresponse;
            }


        public async Task<GetRateTablesResponse> getratePolicyService(RateTable ratetable)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.RATETABLE_URL + ratetable.countryCode);
            var response = await helper.Get();
            GetRateTablesResponse getRateTablesResponse = JsonConvert.DeserializeObject<GetRateTablesResponse>(response);
            return getRateTablesResponse;
            }
        public async Task<string> deleteReturnPolicyService(string Id)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.PaymentPolicy_Url + Id );
            var response = await helper.Delete(Id);
            return response;
            }
        }
    }
