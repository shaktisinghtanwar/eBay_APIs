using EbaySdkLib.Messages;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;
namespace EbaySdkLib.Services
{
   public  class OrderService
    {
       string _urlOrder;
       string _urlOrders;
       public OrderService()
       {
           _urlOrder = string.Format("sell/fulfillment/v1/order/");
           _urlOrders = string.Format("sell/fulfillment/v1/order/");
       }
       public async Task<Tuple<GetOrderResponse,HttpStatusCode>>GetOrder(string orderId) 
       {
           RestHelper helper = new RestHelper(_urlOrder + orderId);
           var response =await  helper.Get();

           GetOrderResponse getOrderResponse = JsonConvert.DeserializeObject<GetOrderResponse>(response.Item1);
           return new Tuple<GetOrderResponse, HttpStatusCode>(getOrderResponse, response.Item2);


       }
       public async Task<Tuple<GetOrdersResponse,HttpStatusCode>>  GetOrders(string filter, string limit, string offset, string orderIds)
       {
           RestHelper helper = new RestHelper(_urlOrders + "?filter=creationdate:" + filter + "&limit=" + limit + "&offset=" + offset);
            var response=await helper.Get();
           GetOrdersResponse  getOrdersResponse= JsonConvert.DeserializeObject<GetOrdersResponse>(response.Item1);
           return new Tuple<GetOrdersResponse, HttpStatusCode>(getOrdersResponse, response.Item2);

       }
    }
}
