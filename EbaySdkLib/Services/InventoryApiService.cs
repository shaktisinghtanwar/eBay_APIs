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

        public async Task<GetInventryLocationResponse> CreateInventoryLocationService(CreateInventoryLocationRequest createInventoryLocationRequest, string merchantLocationKey)
            {
            var body = JsonConvert.SerializeObject(createInventoryLocationRequest);
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTORYLOCATION_URL + merchantLocationKey);
            var response = await helper.Post(body);
            GetInventryLocationResponse getInventryLocationResponse =  JsonConvert.DeserializeObject<GetInventryLocationResponse>(response);
            return getInventryLocationResponse;
            }

        public async Task<string> UpdateInventoryLocationService(UpdateInventoryLocationRequest updateInventoryLocationRequest, string merchantLocationKey)
            {
            var body = JsonConvert.SerializeObject(updateInventoryLocationRequest);
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTORYLOCATION_URL + merchantLocationKey);
            var response = await helper.Post(body);
            return response;
            }


        public async Task<GetInventryLocationResponse> getInventoryLocationService(string merchantLocationKey)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTORYLOCATION_URL  + merchantLocationKey );
            var response = await helper.Get();
            GetInventryLocationResponse getInventryLocationResponse = JsonConvert.DeserializeObject<GetInventryLocationResponse>(response);
            return getInventryLocationResponse;
            }

        public async Task<GetInventoryLocationsResponce> getInventoryLocationsService(int limit = 2, int offset = 2)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTORYLOCATION_URL + "?limit= {" + limit + "}&offset={" + offset + "}");
            var response = await helper.Get();
            GetInventoryLocationsResponce getReturnPoliciesResponse = JsonConvert.DeserializeObject<GetInventoryLocationsResponce>(response);
            return getReturnPoliciesResponse;
            }
        //request invalid for enable and disable
        public async Task<string> enableInventoryLocationService(string Id)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTORYLOCATION_URL +  Id + "/enable");
            var response = await helper.Get();
            return response;
            }

        public async Task<string> disableInventoryLocationService(string Id)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTORYLOCATION_URL +  Id + "/disable");
            var response = await helper.Get();
            return response;
            }

        public async Task<string> deleteInventoryLocationService(string Id)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTORYLOCATION_URL + Id );
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
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTORYOFFER_URL);
            var response = await helper.Post(body);
            CreateOffersResponse createOffersresponse = JsonConvert.DeserializeObject<CreateOffersResponse>(response);
            return createOffersresponse;
            }
        public async Task<UpdateInventoryOffersResponse> updateOffersService(UpdateInventoryOfferRequest updateInventoryOfferRequest,string Id)
            {
            var body = JsonConvert.SerializeObject(updateInventoryOfferRequest);
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTORYOFFER_URL+Id);
            var response = await helper.Post(body);
            UpdateInventoryOffersResponse updateinventoryOffersResponse = JsonConvert.DeserializeObject<UpdateInventoryOffersResponse>(response);
            return updateinventoryOffersResponse;
            }

        public async Task<GetOffersResponse> getOffersService(string Id)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTORYOFFER_URL+"?sku=" + Id);
            var response = await helper.Get();
            GetOffersResponse getOffersResponse = JsonConvert.DeserializeObject<GetOffersResponse>(response);
            return getOffersResponse;
            }

        public async Task<GetofferResponse> getOfferService(string Id)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTORYOFFER_URL + Id);
            var response = await helper.Get();
            GetofferResponse getofferResponse = JsonConvert.DeserializeObject<GetofferResponse>(response);
            return getofferResponse;
            }
        public async Task<string> deleteOffersService(string Id)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTORYOFFER_URL + Id);
            var response = await helper.Get();
            return response;
            }
        public async Task<PublichoffersResponse> publishOfferService(string Id)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTORYOFFER_URL + Id+"/publish");
            var response = await helper.Get();
            PublichoffersResponse publichoffersResponse = JsonConvert.DeserializeObject<PublichoffersResponse>(response);
            return publichoffersResponse;
          
            }
      
        public async Task<GetListingFeesResponse> getListingFeesService(string Id)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTORYOFFER_URL +Id);
            var response = await helper.Get();
            GetListingFeesResponse getListingFeesResponse = JsonConvert.DeserializeObject<GetListingFeesResponse>(response);
            return getListingFeesResponse;

            }
        public async Task<GetListingFeesResponse> publishOfferByInventoryItemGroupService(string Id)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTORYOFFER_URL + Id);
            var response = await helper.Get();
            GetListingFeesResponse publishOffer = JsonConvert.DeserializeObject<GetListingFeesResponse>(response);
            return publishOffer;

            }
        public async Task<WithdrawOfferResponse> WithdrawOfferService(string Id)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTORYOFFER_URL + Id+"/withdraw");
            var response = await helper.Get();
            WithdrawOfferResponse WithdrawOffer = JsonConvert.DeserializeObject<WithdrawOfferResponse>(response);
            return WithdrawOffer;

            }
        #endregion
        #region InventoryItems
        public async Task<GetInventoryitemResponse> getInventoryItemService(string Id)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTORY_URL + Id);
            var response = await helper.Get();
            GetInventoryitemResponse getInventoryItems = JsonConvert.DeserializeObject<GetInventoryitemResponse>(response);
            return getInventoryItems;
            }
        public async Task<GetInventoryItemsResponse> getInventoryItemsService()
            {
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTORY_URL + "inventory_item?limit=2&offset=0");
            var response = await helper.Get();
            GetInventoryItemsResponse getInventoryItemsResponse = JsonConvert.DeserializeObject<GetInventoryItemsResponse>(response);
            return getInventoryItemsResponse;
            }
        public async Task<string> deleteInventoryItemService(string sku)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTORY_URL  + sku);
            var response = await helper.Get();
            return response;
            }
        public async Task<BulkUpdatePriceQualityResponse> bulkUpdatePriceQualityService(BulkUpdatePriceQualityRequest bulkUpdatePriceQualityRequest)
            {
            var body = JsonConvert.SerializeObject(bulkUpdatePriceQualityRequest);
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTORY_URL+"bulk_update_price_quantity");
            var response = await helper.Post(body);
            BulkUpdatePriceQualityResponse bnulkUpdatePriceQualityResponse = JsonConvert.DeserializeObject<BulkUpdatePriceQualityResponse>(response);
            return bnulkUpdatePriceQualityResponse;
            }

        public async Task<CreateorReplaceItemResponse> CreateorReplaceItemService(CreateorReplaceInventoryItemrequest createorReplaceInventoryItemrequest, string sku)
            {
            var body = JsonConvert.SerializeObject(createorReplaceInventoryItemrequest);
            RestHelper helper = new RestHelper(ApplicationConstants.PRODCOMPATIBILITY_URL + sku);
            var response = await helper.Post(body);
            CreateorReplaceItemResponse createorReplaceItemResponse = JsonConvert.DeserializeObject<CreateorReplaceItemResponse>(response);
            return createorReplaceItemResponse;
            }

        #endregion
        #region inventoryGrp

        public async Task<GetinventoryItemGroupResponse> getInventoryItemGroupService(string val)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTRYITEMGROUP_URL + val);
            var response = await helper.Get();
            GetinventoryItemGroupResponse getinventoryItemGroupResponse = JsonConvert.DeserializeObject<GetinventoryItemGroupResponse>(response);
            return getinventoryItemGroupResponse;
            }
        public async Task<string> deleteInventoryItemgrpService(string val)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTRYITEMGROUP_URL + val);
            var response = await helper.Get();
            return response;
            }

        public async Task<CreateorReplaceItemResponse> CreateorReplaceItemgrpProdService(CreateOrReplaceinventoryItemGrpRequest createorReplaceItemRequest, string val)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTRYITEMGROUP_URL + val);
            var body = JsonConvert.SerializeObject(createorReplaceItemRequest);
            var response = await helper.Post(body);
            CreateorReplaceItemResponse createorReplaceItemResponse = JsonConvert.DeserializeObject<CreateorReplaceItemResponse>(response);
            return createorReplaceItemResponse;
            }

        #endregion
        #region Listing
        public async Task<BulkMigratelistingresponse> bulkMigrateListingService(BulkMigrateListingRequest bulkMigrateListingRequest)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTORY_URL + "bulk_migrate_listing");
            var body = JsonConvert.SerializeObject(bulkMigrateListingRequest);
            var response = await helper.Post(body);
            BulkMigratelistingresponse bulkMigratelistingresponse = JsonConvert.DeserializeObject<BulkMigratelistingresponse>(response);
            return bulkMigratelistingresponse;
            }

        #endregion

        #region ProdCompatibility
        public async Task<CreateOrReplaceProductComaptibilityResponse> CreateOrReplaceProductCompatibilityService(CreateOrReplaceProductCompatibilityRequest createOrReplaceProductCompatibilityRequest, string sku)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.PRODCOMPATIBILITY_URL + sku+"/product_compatibility");
          
         
            var body = JsonConvert.SerializeObject(createOrReplaceProductCompatibilityRequest);
            var response = await helper.Post(body);
            
            CreateOrReplaceProductComaptibilityResponse comaptibilityResponse = JsonConvert.DeserializeObject<CreateOrReplaceProductComaptibilityResponse>(response);
            return comaptibilityResponse;
            }

        public async Task<GetProductCompatibilityResponse> getProductCompatibilityService(string val)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTRYITEMGROUP_URL + val+"/product_compatibility");
            var response = await helper.Get();
            GetProductCompatibilityResponse getProductCompatibilityResponse = JsonConvert.DeserializeObject<GetProductCompatibilityResponse>(response);
            return getProductCompatibilityResponse;
            }
        public async Task<string> deleteProductCompatibilityService(string val)
            {
            RestHelper helper = new RestHelper(ApplicationConstants.INVENTRYITEMGROUP_URL + val);
            var response = await helper.Get();
            return response;
            }

       
        #endregion
        }
    }
