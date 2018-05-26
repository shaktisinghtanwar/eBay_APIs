using EbaySdkLib.Messages;
using Newtonsoft.Json;
using System.Threading.Tasks;
using EbaySdkLib.Models;

namespace EbaySdkLib 
{
  public  class   ProgramService
    {

      string _urlGetOptln;
      string _urlOptln;
      string _urlOutPut;
      public ProgramService()
        {
            _urlGetOptln = string.Format("sell/account/v1/program");
            _urlOptln = string.Format("sell/account/v1/program");
            _urlOutPut = string.Format("sell/account/v1/program");
      }

      public async Task<GetOptedInProgramsResponse> GetOptedprogram(GetOptedInProgramsRequest getOptedInProgramsRequest)
      {


          RestHelper helper = new RestHelper(_urlGetOptln + "/" + "get_opted_in_programs");
          var response = await helper.Get();

          GetOptedInProgramsResponse getOptedInProgramsResponse = JsonConvert.DeserializeObject<GetOptedInProgramsResponse>(response);
          return getOptedInProgramsResponse;
      }


     // //Not match this response  with ebay response due to bad filed in taken from programtypeEnum
     // Error not match with ebay
      public async Task<OptInToProgramResponse> OplnToprogram(OptInToProgramRequest optInToProgramRequest)
      {
          var body = JsonConvert.SerializeObject(optInToProgramRequest);

          RestHelper helper = new RestHelper(_urlOptln + "/" + "opt_in");
          var response = await helper.Post(body);

          OptInToProgramResponse optInToProgramResponse = JsonConvert.DeserializeObject<OptInToProgramResponse>(response);
          return optInToProgramResponse;
      }

   
      
      ////Not match this response  with ebay response due to bad filed in taken from programtypeEnum
      //Not success 
      public async Task<OptOutOfProgramResponse> OutPutOfProgram(OptOutOfProgramRequest optOutOfProgramRequest)
      {
          var body = JsonConvert.SerializeObject(optOutOfProgramRequest);

          RestHelper helper = new RestHelper(_urlOutPut + "/" + "opt_out");
          var response = await helper.Post(body);

          OptOutOfProgramResponse optOutOfProgramResponse = JsonConvert.DeserializeObject<OptOutOfProgramResponse>(response);
          return optOutOfProgramResponse;
      }


    }
}
