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
  public  class AnalyticsService
    {
        public AnalyticsService()
        {

        }

      //Shilpa Work
        public async Task<GetTrafficReportResponse> getAnalyticsService(string filter, string dimension, string metric, string sort)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.ANALYTICS_URL + filter + dimension + metric);
            var response = await helper.Get();
            GetTrafficReportResponse getAnalyticsResponse = JsonConvert.DeserializeObject<GetTrafficReportResponse>(response);
            return getAnalyticsResponse;
            }


        public async Task<FindSellerStandardsProfilesResponse> findSellerStandardsProfilesResponseAnalyticsService()
        {
            RestHelper helper = new RestHelper(ApplicationConstants.SELLER_STANDARDS_URL);
            var response = await helper.Get();
            FindSellerStandardsProfilesResponse findSellerStandardsProfilesAnalyticsResponse = JsonConvert.DeserializeObject<FindSellerStandardsProfilesResponse>(response);
            return findSellerStandardsProfilesAnalyticsResponse;
        }

      //LodhiSir
        public async Task<getSellerStandardsProfileResponse> getSellerStandards(getSellerStandardsProfileResponse getSellerStandards, string cycle)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.SELLER_ANALYTICS_URL + "/" + getSellerStandards.cycle + "/" + cycle);
            var response = await helper.Get();
            getSellerStandardsProfileResponse getSellerStandardsResponse = JsonConvert.DeserializeObject<getSellerStandardsProfileResponse>(response);
            return getSellerStandardsResponse;
            }
    }
}
