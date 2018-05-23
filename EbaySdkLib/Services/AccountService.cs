namespace EbaySdkLib
{
    public class AccountService
    {
        public AccountService()
        {
            FulfilmentPolicyService = new FulfilmentPolicyService();
        }
        public FulfilmentPolicyService FulfilmentPolicyService { get; set; }
    }
}
