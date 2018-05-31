using EbaySdkLib.Services;
namespace EbaySdkLib
{
   public  class  FulFillmentApiService
   {
        public string Token { get;private set; }
        public FulFillmentApiService(string token)
            {
        OrderService = new OrderService(Token);
            }

       
       public OrderService OrderService { get; set; }
   }

}
