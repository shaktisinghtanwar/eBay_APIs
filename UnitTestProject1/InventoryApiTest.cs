using EbaySdkLib.Messages;
using EbaySdkLib.Models;
using EbaySdkLib.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
    {
    [TestClass]
  public  class InventoryApiTest
        {

        #region InventoryLocation


        [TestMethod]
        public void CreateInventoryLocation()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string merchantLocationKey = "Warehouse-1";
            CreateInventoryLocationRequest createInventoryLocationRequest = new CreateInventoryLocationRequest();
            createInventoryLocationRequest.location = new Location()
            {
                address = new Address()
                {
                    addressLine1 = "2055 Hamilton Ave",
                    addressLine2 = "Building 3",
                    city = "San Jose",
                    stateOrProvince = "CA",
                    postalCode = "95125",
                    countryCode = EbaySdkLib.Enums.CountryCodeEnum.US

                }

            };
            GetInventryLocationResponse response = inventoryApiService.CreateInventoryLocationService(createInventoryLocationRequest, merchantLocationKey).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void UpdateInventoryLocation()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string merchantLocationKey = "Warehouse-1";
            UpdateInventoryLocationRequest updateInventoryLocationRequest = new UpdateInventoryLocationRequest();
            updateInventoryLocationRequest.locationAdditionalInformation = "Available for drop-off on Mondays only.";
            updateInventoryLocationRequest.locationInstructions = "Entrance is on the backside of the building.";
            updateInventoryLocationRequest.locationWebUrl = "http://www.example.com/warehouse-1";
            updateInventoryLocationRequest.name = "Warehouse-South";
            updateInventoryLocationRequest.phone = "888-730-0000";
            updateInventoryLocationRequest.operatingHours = new OperatingHour[]
           {
               new OperatingHour()
               {
               dayOfWeekEnum=EbaySdkLib.Enums.DayOfWeekEnum.MONDAY
               }
           };

            var response = inventoryApiService.UpdateInventoryLocationService(updateInventoryLocationRequest, merchantLocationKey).Result;
            Assert.IsNotNull(response);
            }

        [TestMethod]
        public void getInventoryLocation()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string merchantLocationKey = "Warehouse-1";
            GetInventryLocationResponse response = inventoryApiService.getInventoryLocationService(merchantLocationKey).Result;
            Assert.IsNotNull(response);
            }

        [TestMethod]
        public void getInventoryLocations()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            int limit = 2; int offset = 2;
            GetInventoryLocationsResponce response = inventoryApiService.getInventoryLocationsService(limit, offset).Result;
            Assert.IsNotNull(response);
            }


        [TestMethod]
        public void enableInventoryLocation()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string merchantLocationKey = "warehouse-1";
            var response = inventoryApiService.enableInventoryLocationService(merchantLocationKey).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void disableInventoryLocation()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string merchantLocationKey = "warehouse-1";
            var response = inventoryApiService.disableInventoryLocationService(merchantLocationKey).Result;
            Assert.IsNotNull(response);
            }


        //[TestMethod]
        //public void createInventoryLocations()
        //    {
        //    InventoryApiService inventoryApiService = new InventoryApiService();
        //    EbaySdkLib.Messages.CreateInventoryLocationRequest createInventoryLocationRequest = new EbaySdkLib.Messages.CreateInventoryLocationRequest();
        //    createInventoryLocationRequest.location = new EbaySdkLib.Models.Location()
        //    {
        //        address = new Address()
        //        {
        //            addressLine1 = "2055 Hamilton Ave",
        //            addressLine2 = "Building 3",
        //            city = "San Jose",
        //            country = CountryCodeEnum.US,
        //            postalCode = "12",
        //            stateOrProvince = "12"
        //        },
        //        geoCoordinates = new GeoCoordinates()
        //        {
        //            latitude = "12",
        //            longitude = "a34c"
        //        },
        //        locationId = "abc"
        //    };
        //    createInventoryLocationRequest.merchantLocationStatus = EbaySdkLib.Enums.StatusEnum.ENABLED;
        //    createInventoryLocationRequest.operatingHours = new EbaySdkLib.Models.OperatingHour[] { new EbaySdkLib.Models.OperatingHour()
        //    { 
        //        DayOfWeekEnum=DayOfWeekEnum.MONDAY,

        //    };
        //    //var response = inventoryApiService.createInventoryLocationsService().Result;
        //   // Assert.IsNotNull(response);
        //    }

        [TestMethod]
        public void deleteInventoryLocation()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string merchantLocationKey = "warehouse-1";
            var response = inventoryApiService.deleteInventoryLocationService(merchantLocationKey).Result;
            Assert.IsNotNull(response);
            }
        #endregion
        #region Offers
        /// <summary>
        /// header issue
        /// </summary>
        [TestMethod]
        public void createOffers()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            EbaySdkLib.Messages.CreateOffersRequest createOffersRequest = new EbaySdkLib.Messages.CreateOffersRequest();
            createOffersRequest.marketplaceId = EbaySdkLib.Models.MarketplaceIdEnum.EBAY_US;
            createOffersRequest.format = EbaySdkLib.Enums.FormatTypeEnum.FIXED_PRICE;
            createOffersRequest.sku = "ddtest1";
            createOffersRequest.availableQuantity = 75;
            createOffersRequest.listingPolicies = new ListingPolicies()
            {
                paymentPolicyId = "37967344010",
                returnPolicyId = "61019560011"
            };
            createOffersRequest.pricingSummary = new PricingSummary()
            {
                price = new Amount()
                {
                    currency = EbaySdkLib.Models.CurrencyCodeEnum.USD,
                    value = "260.00"

                }
            };
            CreateOffersResponse response = inventoryApiService.createOffersService(createOffersRequest).Result;
            Assert.IsNotNull(response);
            Assert.Fail();
            }
        [TestMethod]
        public void UpdateOffers()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string OfferId = "36445435465";
            EbaySdkLib.Messages.UpdateInventoryOfferRequest updateInventoryOfferRequest = new EbaySdkLib.Messages.UpdateInventoryOfferRequest();
            updateInventoryOfferRequest.categoryId = "30120";
            updateInventoryOfferRequest.availableQuantity = 75;
            updateInventoryOfferRequest.listingPolicies = new ListingPolicies()
            {
                paymentPolicyId = "37967344010",
                returnPolicyId = "37967343010"
            };
            updateInventoryOfferRequest.pricingSummary = new PricingSummary()
            {
                price = new Amount()
                {
                    currency = EbaySdkLib.Models.CurrencyCodeEnum.USD,
                    value = "260.00"

                }

            };

            UpdateInventoryOffersResponse response = inventoryApiService.updateOffersService(updateInventoryOfferRequest, OfferId).Result;
            Assert.IsNotNull(response);
            Assert.Fail();
            }

        [TestMethod]
        public void getOffers()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string sku = "3455632452345";
            GetOffersResponse response = inventoryApiService.getOffersService(sku).Result;
            Assert.IsNotNull(response);
            Assert.Fail();
            }

        [TestMethod]
        public void getOffer()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string offerId = "36445435465";
            GetofferResponse response = inventoryApiService.getOfferService(offerId).Result;
            Assert.IsNotNull(response);
            Assert.Fail();
            }
        [TestMethod]
        public void deleteOffer()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string offerId = "3455632452345";
            var response = inventoryApiService.deleteOffersService(offerId).Result;
            Assert.IsNotNull(response);
            Assert.Fail();
            }
        [TestMethod]
        public void publishOffer()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string offerId = "36445435465";
            var response = inventoryApiService.publishOfferService(offerId).Result;
            Assert.IsNotNull(response);
            Assert.Fail();
            }
        [TestMethod]
        public void getListingFees()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string get_listing_fees = "get_listing_fees";
            var response = inventoryApiService.getListingFeesService(get_listing_fees).Result;
            Assert.IsNotNull(response);
            Assert.Fail();
            }
        [TestMethod]
        public void publishOfferByInventoryItemGroup()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string get_listing_fees = "get_listing_fees";
            var response = inventoryApiService.publishOfferByInventoryItemGroupService(get_listing_fees).Result;
            Assert.IsNotNull(response);
            Assert.Fail();
            }


        [TestMethod]
        public void WithdrawOrder()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string Listing_Id = "3455632452346";
            var response = inventoryApiService.WithdrawOfferService(Listing_Id).Result;
            Assert.IsNotNull(response);
            Assert.Fail();
            }

        #endregion
        #region InventoryItems
        [TestMethod]
        public void getInventoryItem()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string sku = "GP-Cam-01";
            var response = inventoryApiService.getInventoryItemService(sku);
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void getInventoryItems()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();

            GetInventoryItemsResponse response = inventoryApiService.getInventoryItemsService().Result;
            Assert.IsNotNull(response);
            }

        [TestMethod]
        public void deleteInventoryItem()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string sku = "GP-Cam-01";
            var response = inventoryApiService.deleteInventoryItemService(sku).Result;
            Assert.IsNotNull(response);
            }

        [TestMethod]
        public void bulkUpdatePriceQuality()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            EbaySdkLib.Messages.BulkUpdatePriceQualityRequest bulkUpdatePriceQualityRequest = new EbaySdkLib.Messages.BulkUpdatePriceQualityRequest();
            bulkUpdatePriceQualityRequest.requests = new PriceQuality[]{
                          new PriceQuality ()
                          {
                          sku="GP-Cam-01",
                          shipToLocationAvailability=new ShipToLocationAvailability (){ quantity= "25"},
                         offers=new Offer[]{new Offer(){availableQuantity= 10,offerId= "3455632452395", pricingSummary=new PricingSummary { price=new Amount(){currency=EbaySdkLib.Models.CurrencyCodeEnum.GBP,value="182.0"} }
                           }
                             }
                          }
                        };

            var response = inventoryApiService.bulkUpdatePriceQualityService(bulkUpdatePriceQualityRequest).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void CreateorReplaceItem()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            CreateorReplaceInventoryItemrequest createorReplaceInventoryItemrequest = new CreateorReplaceInventoryItemrequest();
            string sku = "GP-Cam-01";
            createorReplaceInventoryItemrequest.availability = new Availability
            {
                shipToLocationAvailability = new ShipToLocationAvailability()
                {
                    quantity = "50"
                }

            };
            createorReplaceInventoryItemrequest.condition = EbaySdkLib.Enums.ConditionEnum.NEW;
            createorReplaceInventoryItemrequest.product = new Product()
            {
                title = "GoPro Hero4 Helmet Cam",
                description = "New GoPro Hero4 Helmet Cam. Unopened box."
            };

            var response = inventoryApiService.CreateorReplaceItemService(createorReplaceInventoryItemrequest,sku).Result;
            Assert.IsNotNull(response);
            }
        #endregion
        #region InventoryItemGrp

        [TestMethod]
        public void createorReplceItemGroup()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            CreateOrReplaceinventoryItemGrpRequest createorReplaceInventoryItemrequest = new CreateOrReplaceinventoryItemGrpRequest();
            string inventoryItemGroupKey = "Mens_Solid_Polo_Shirts";
            createorReplaceInventoryItemrequest.variantSKUs = new string[]
            {
                "MSPS-GrS",
        "MSPS-GrM",
        "MSPS-GrL",
        "MSPS-GrXL",
        "MSPS-BlS",
        "MSPS-BlM",
        "MSPS-BlL",
        "MSPS-BlXL",
        "MSPS-RdS",
        "MSPS-RdM",
        "MSPS-RdL",
        "MSPS-RdXL",
        "MSPS-BkS",
        "MSPS-BkM",
        "MSPS-BkL"
            };
            CreateorReplaceItemResponse response = inventoryApiService.CreateorReplaceItemgrpProdService(createorReplaceInventoryItemrequest, inventoryItemGroupKey).Result;
            Assert.IsNotNull(response);
            }

        [TestMethod]
        public void getInventoryItemGroup()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string inventoryItemGroupKey = "Mens_Solid_Polo_Shirts";
            GetinventoryItemGroupResponse response = inventoryApiService.getInventoryItemGroupService(inventoryItemGroupKey).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void deleteInventoryItemGroup()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string inventoryItemGroupKey = "Mens_Solid_Polo_Shirts";
            var response = inventoryApiService.deleteInventoryItemgrpService(inventoryItemGroupKey).Result;
            Assert.IsNotNull(response);
            }
        #endregion
        #region Listing

        [TestMethod]
        public void bulkMigrateListing()
            {

            InventoryApiService inventoryApiService = new InventoryApiService();
            BulkMigrateListingRequest bulkMigrateListingRequest = new BulkMigrateListingRequest();
            bulkMigrateListingRequest.requests = new MigrateListRequest[]
            {
                new MigrateListRequest()
                {
                    listingId="160009220563"
                },
                new MigrateListRequest()
                {
                    listingId="160009220564"
                },
                new MigrateListRequest()
                {
                    listingId="160009220565"
                }

            };
            BulkMigratelistingresponse response = inventoryApiService.bulkMigrateListingService(bulkMigrateListingRequest).Result;
            Assert.IsNotNull(response);
            }



        #endregion

        #region ProdCompatibility
        [TestMethod]
        public void CreateOrReplaceProductCompatibilityService()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            CreateOrReplaceProductCompatibilityRequest createOrReplaceProductCompatibilityRequest = new CreateOrReplaceProductCompatibilityRequest();
            string sku = "Al-8730";
            createOrReplaceProductCompatibilityRequest.compatibleProducts = new CompatibleProduct[]{
                new CompatibleProduct(){
                productFamilyProperties=new ProductFamilyProperties()
                {
                make="Subaru",
                model ="DL",
                year="1982",
                trim="Base Wagon 4-Door",
                engine= "1.8L 1781CC H4 GAS SOHC Naturally Aspirated"
                },
                notes="Equivalent to AC Delco Alternator"
                }

            };
            var response = inventoryApiService.CreateOrReplaceProductCompatibilityService(createOrReplaceProductCompatibilityRequest, sku).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void getProdCompatibility()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string sku = "Al-8730";
            GetProductCompatibilityResponse response = inventoryApiService.getProductCompatibilityService(sku).Result;
            Assert.IsNotNull(response);
            }
        [TestMethod]
        public void deleteProdCompatibility()
            {
            InventoryApiService inventoryApiService = new InventoryApiService();
            string sku = "Al-8730";
            var response = inventoryApiService.deleteProductCompatibilityService(sku).Result;
            Assert.IsNotNull(response);
            }
      
        #endregion 
        }
    }
