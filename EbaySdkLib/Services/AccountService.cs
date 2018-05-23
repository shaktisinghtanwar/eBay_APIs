using EbaySdkLib.Services;
namespace EbaySdkLib
{
    public class AccountService
    {
        public AccountService()
        {
            FulfilmentPolicyService = new FulfilmentPolicyService();
            PaymentpolicyService = new PaymentpolicyService();
        }
        public FulfilmentPolicyService FulfilmentPolicyService { get; set; }
        public PaymentpolicyService PaymentpolicyService { get; set; }
    }
}
