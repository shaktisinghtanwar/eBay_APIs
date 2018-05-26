using EbaySdkLib.Messages;
using Newtonsoft.Json;
using System.Threading.Tasks;
namespace EbaySdkLib
{
    public class SalesTaxService
    {
        string _urlSalesTax;
        public SalesTaxService()
        {
            _urlSalesTax = string.Format("sell/account/v1/sales_tax/");
        }
        public async Task<CreateOrReplaceSalesTaxResponse> CreateorReplaceSalesTax(CreateOrReplaceSalesTaxRequest createOrReplaceSalesTaxRequest, string countryCode, string jurisdictionId)
        {
            var body = JsonConvert.SerializeObject(createOrReplaceSalesTaxRequest);

            RestHelper helper = new RestHelper(_urlSalesTax + countryCode + "/" + jurisdictionId);
            var response = await helper.Put(body);

            CreateOrReplaceSalesTaxResponse createOrReplaceSalesTaxResponse = JsonConvert.DeserializeObject<CreateOrReplaceSalesTaxResponse>(response);
            return createOrReplaceSalesTaxResponse;
        }
        public async Task<DeleteSalesTaxResponse>DeleteSalesTax(string countryCode,string jurisdictionId )
        {
            RestHelper helper = new RestHelper(_urlSalesTax + countryCode + "/" + jurisdictionId);
            var response = await helper.Delete(countryCode);
            DeleteSalesTaxResponse deleteSalesTaxResponse = JsonConvert.DeserializeObject<DeleteSalesTaxResponse>(response);
            return deleteSalesTaxResponse;
        }
        public async Task<GetSalesTaxResponse> GetSalesTax(string countryCode, string jurisdictionId)
        {
            RestHelper helper = new RestHelper(_urlSalesTax + countryCode + "/" + jurisdictionId);
            var response = await helper.Get();
            GetSalesTaxResponse getSalesTaxResponse = JsonConvert.DeserializeObject<GetSalesTaxResponse>(response);
            return getSalesTaxResponse;
        }
        public async Task<GetSalesTaxesResponse> GetSalesTaxes(string countryCode)
        {
            RestHelper helper = new RestHelper(_urlSalesTax + "?country_code=" + countryCode );
            var response = await helper.Get();
            GetSalesTaxesResponse getSalesTaxesResponse = JsonConvert.DeserializeObject<GetSalesTaxesResponse>(response);
            return getSalesTaxesResponse;
        }
    }
}
