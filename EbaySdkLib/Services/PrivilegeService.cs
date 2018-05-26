using EbaySdkLib.Messages;
using Newtonsoft.Json;
using System.Threading.Tasks;
namespace EbaySdkLib
{
   public  class PrivilegeService
    {
       string _UrlPrivilage;
     public   PrivilegeService()
       {
           _UrlPrivilage = string.Format("sell/account/v1/privilege");
       }
     public async Task<GetPrivilegesResponse> GetPrivilage(GetPrivilegesRequest getPrivilegesRequest)
     {


         RestHelper helper = new RestHelper(_UrlPrivilage+"/");
         var response = await helper.Get();

         GetPrivilegesResponse getPrivilegesResponse = JsonConvert.DeserializeObject<GetPrivilegesResponse>(response);
         return getPrivilegesResponse;
     }

    }
}
