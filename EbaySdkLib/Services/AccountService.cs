using EbaySdkLib.Services;
namespace EbaySdkLib
{
    public class AccountService
    {
        public AccountService()
        {
            FulfilmentPolicyService = new FulfilmentPolicyService();
            PaymentpolicyService = new PaymentpolicyService();
            ReturnPolicyService = new ReturnPolicyService();
            InventoryApiService = new InventoryApiService();
        }
        public FulfilmentPolicyService FulfilmentPolicyService { get; set; }
        public PaymentpolicyService PaymentpolicyService { get; set; }
        public ReturnPolicyService ReturnPolicyService { get; set; }
        public InventoryApiService InventoryApiService { get; set; }
    }
}
