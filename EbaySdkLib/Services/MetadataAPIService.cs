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
  public  class MetadataAPIService
        {
      public async Task<GetSalesTaxJurisdictions> getSalesTaxJurisdictionsService( string countrycode)
      {
      RestHelper helper = new RestHelper(ApplicationConstants.JURISDICTION_URL +countrycode+"/sales_tax_jurisdiction");
      var response = await helper.Get();
      GetSalesTaxJurisdictions getSalesTaxJurisdictions = JsonConvert.DeserializeObject<GetSalesTaxJurisdictions>(response);
      return getSalesTaxJurisdictions;
      }
      public async Task<GetAutomotivePartsCompatibilityPolicies> getAutomotivePartsCompatibilityService(string marketPlaceId, string filter)
          {
          RestHelper helper = new RestHelper(ApplicationConstants.JURISDICTION_URL + marketPlaceId + "/get_automotive_parts_compatibility_policies?filter=categoryIds:" + filter);
          var response = await helper.Get();
          GetAutomotivePartsCompatibilityPolicies getAutomotivePartsCompatibilityPolicies = JsonConvert.DeserializeObject<GetAutomotivePartsCompatibilityPolicies>(response);
          return getAutomotivePartsCompatibilityPolicies;
          }
      public async Task<GetItemConditionPoliciesResponse> getItemConditionPoliciesService(string marketPlaceId, string filter)
          {
          RestHelper helper = new RestHelper(ApplicationConstants.JURISDICTION_URL + marketPlaceId + "/get_automotive_parts_compatibility_policies?filter=categoryIds:" + filter);
          var response = await helper.Get();
          GetItemConditionPoliciesResponse getItemConditionPoliciesResponse = JsonConvert.DeserializeObject<GetItemConditionPoliciesResponse>(response);
          return getItemConditionPoliciesResponse;
          }
      public async Task<GetListingStructurePoliciesResponse> GetListingStructurePoliciesService(string marketPlaceId, string filter)
          {
          RestHelper helper = new RestHelper(ApplicationConstants.MARKETPLACE_URL + marketPlaceId + "/get_listing_structure_policies?filter=categoryIds" + filter);
          var response = await helper.Get();
          GetListingStructurePoliciesResponse getListingStructurePoliciesResponse = JsonConvert.DeserializeObject<GetListingStructurePoliciesResponse>(response);
          return getListingStructurePoliciesResponse;
          }

      public async Task<GetNegotiatedPricePoliciesResponse> getNegotiatedPricePoliciesService(string marketPlaceId, string filter)
          {
          RestHelper helper = new RestHelper(ApplicationConstants.MARKETPLACE_URL + marketPlaceId + "/get_negotiated_price_policies?filter=" + filter);
          var response = await helper.Get();
          GetNegotiatedPricePoliciesResponse getNegotiatedPricePoliciesResponse = JsonConvert.DeserializeObject<GetNegotiatedPricePoliciesResponse>(response);
          return getNegotiatedPricePoliciesResponse;
          }
      public async Task<GetProductAdoptionPolicies> getProductAdoptionPoliciesService(string marketPlaceId, string filter)
          {
          RestHelper helper = new RestHelper(ApplicationConstants.MARKETPLACE_URL + marketPlaceId + "get_product_adoption_policies?filter=categoryIds" + filter);
          var response = await helper.Get();
          GetProductAdoptionPolicies getProductAdoptionPolicies = JsonConvert.DeserializeObject<GetProductAdoptionPolicies>(response);
          return getProductAdoptionPolicies;
          }
      
      public async Task<MetadataGetreturnPolicyresponse> metadataGetreturnPolicyService(string marketPlaceId, string filter)
          {
          RestHelper helper = new RestHelper(ApplicationConstants.MARKETPLACE_URL + marketPlaceId + "get_return_policies?filter=categoryIds" + filter);
          var response = await helper.Get();
          MetadataGetreturnPolicyresponse metadataGetreturnPolicyresponse = JsonConvert.DeserializeObject<MetadataGetreturnPolicyresponse>(response);
          return metadataGetreturnPolicyresponse;
          }

     
        }
    }
