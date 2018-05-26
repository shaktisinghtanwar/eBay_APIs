using EbaySdkLib.Services;
namespace EbaySdkLib
    {
    public class AccountService
        {
        public AccountService()
            {
            FulfilmentPolicyService = new FulfilmentPolicyService();
            ProgramService = new ProgramService();
            PrivilegeService = new PrivilegeService();
            SalesTaxService = new SalesTaxService();
            PaymentpolicyService = new PaymentpolicyService();
            ReturnPolicyService = new ReturnPolicyService();
            InventoryApiService = new InventoryApiService();
            }
        public FulfilmentPolicyService FulfilmentPolicyService { get; set; }
        public ProgramService ProgramService { get; set; }
        public PrivilegeService PrivilegeService { get; set; }
        public SalesTaxService SalesTaxService { get; set; }

        public PaymentpolicyService PaymentpolicyService { get; set; }
        public ReturnPolicyService ReturnPolicyService { get; set; }
        public InventoryApiService InventoryApiService { get; set; }
        }
    }
