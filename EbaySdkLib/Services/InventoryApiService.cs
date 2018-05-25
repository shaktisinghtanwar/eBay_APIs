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
    public class InventoryApiService
        {
        public InventoryApiService()
            {

            }
        #region InventoryLocations
        public async Task<GetInventryLocationResponse> getInventoryLocationService(string merchantLocationKey)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.InventoryLocation_Url + "{" + merchantLocationKey + "}");
            var response = await helper.Get();
            GetInventryLocationResponse getInventryLocationResponse = JsonConvert.DeserializeObject<GetInventryLocationResponse>(response);
            return getInventryLocationResponse;
            }

        public async Task<GetInventoryLocationsResponce> getInventoryLocationsService(int limit = 2, int offset = 2)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.InventoryLocation_Url + "?limit= {" + limit + "}&offset={" + offset + "}");
            var response = await helper.Get();
            GetInventoryLocationsResponce getReturnPoliciesResponse = JsonConvert.DeserializeObject<GetInventoryLocationsResponce>(response);
            return getReturnPoliciesResponse;
            }
        //request invalid for enable and disable
        public async Task<string> enableInventoryLocationService(string Id)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.InventoryLocation_Url + "{" + Id + "}/enable");
            var response = await helper.Get();
            return response;
            }

        public async Task<string> disableInventoryLocationService(string Id)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.InventoryLocation_Url +  Id + "/disable");
            var response = await helper.Get();
            return response;
            }

        public async Task<string> deleteInventoryLocationService(string Id)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.InventoryLocation_Url + "{"+Id +"}");
            var response = await helper.Delete(Id);
            return response;
            }

        #endregion 
        #region Inventory offers
        /// <summary>
        /// Invalid response
        /// </summary>
        /// <param name="createOffersRequest"></param>
        /// <returns></returns>
        public async Task<CreateOffersResponse> createOffersService(CreateOffersRequest createOffersRequest)
            {
            var body = JsonConvert.SerializeObject(createOffersRequest);
            RestHelper helper = new RestHelper(ApplicationConstants.InventoryOffer_Url);
            var response = await helper.Post(body);
            CreateOffersResponse createOffersresponse = JsonConvert.DeserializeObject<CreateOffersResponse>(response);
            return createOffersresponse;
            }
        public async Task<UpdateInventoryOffersResponse> updateOffersService(UpdateInventoryOfferRequest updateInventoryOfferRequest,string Id)
            {
            var body = JsonConvert.SerializeObject(updateInventoryOfferRequest);
            RestHelper helper = new RestHelper(ApplicationConstants.InventoryOffer_Url+Id);
            var response = await helper.Post(body);
            UpdateInventoryOffersResponse updateinventoryOffersResponse = JsonConvert.DeserializeObject<UpdateInventoryOffersResponse>(response);
            return updateinventoryOffersResponse;
            }

        public async Task<GetOffersResponse> getOffersService(string Id)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.InventoryOffer_Url+"?sku=" + Id);
            var response = await helper.Get();
            GetOffersResponse getOffersResponse = JsonConvert.DeserializeObject<GetOffersResponse>(response);
            return getOffersResponse;
            }

        public async Task<GetofferResponse> getOfferService(string Id)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.InventoryOffer_Url + Id);
            var response = await helper.Get();
            GetofferResponse getofferResponse = JsonConvert.DeserializeObject<GetofferResponse>(response);
            return getofferResponse;
            }
        public async Task<string> deleteOffersService(string Id)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.InventoryOffer_Url + Id);
            var response = await helper.Get();
            return response;
            }
        public async Task<PublichoffersResponse> publishOfferService(string Id)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.InventoryOffer_Url + Id+"/publish");
            var response = await helper.Get();
            PublichoffersResponse publichoffersResponse = JsonConvert.DeserializeObject<PublichoffersResponse>(response);
            return publichoffersResponse;
          
            }
       

        #endregion

        }
    }
