using EbaySdkLib.Constants;
using EbaySdkLib.Messages;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;
namespace EbaySdkLib
{
   public  class PrivilegeService
    {
      
     public async Task<Tuple<GetPrivilegesResponse,HttpStatusCode>>  GetPrivilage(GetPrivilegesRequest getPrivilegesRequest)
     {


     RestHelper helper = new RestHelper(ApplicationConstants.PRIVILAGE_URL + "/");
         var response = await helper.Get();

         GetPrivilegesResponse getPrivilegesResponse = JsonConvert.DeserializeObject<GetPrivilegesResponse>(response.Item1);
         return new Tuple<GetPrivilegesResponse, HttpStatusCode>(getPrivilegesResponse, response.Item2);

     }

    }
}
