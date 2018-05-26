using EbaySdkLib.Services;
namespace EbaySdkLib
{
   public  class  FulFillmentApiService
   {
       public  FulFillmentApiService()
       {
           OrderService = new OrderService();

       }
       public OrderService OrderService { get; set; }
   }

}
