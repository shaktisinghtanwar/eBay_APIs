using EbaySdkLib.Messages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbaySdkLib.Services
{
    public class TaxonomyApiService
    {
        public async Task<GetDefaultCategoryTreeIdResponse> GetDefaultCategoryTreeId(GetDefaultCategoryTreeIdRequest request)
        {
            string url = "commerce/taxonomy/v1_beta/get_default_category_tree_id?marketplace_id={0}";

            RestHelper helper = new RestHelper(string.Format(url, request.marketplace_id));
            var response = await helper.Get();

            GetDefaultCategoryTreeIdResponse getFulfillmentPolicyByNameResponse = JsonConvert.DeserializeObject<GetDefaultCategoryTreeIdResponse>(response);
            return getFulfillmentPolicyByNameResponse;
        }
        public async Task<GetItemAspectsForCategoryResponse> GetItemAspectsForCategory(GetItemAspectsForCategoryRequest request)
        {
            string url = "commerce/taxonomy/v1_beta/category_tree/{0}/get_item_aspects_for_category?category_id ={1}";
         
            RestHelper helper = new RestHelper(string.Format(url, request.category_tree_id,request.category_id));
            var response = await helper.Get();

            GetItemAspectsForCategoryResponse serlializedResponse = JsonConvert.DeserializeObject<GetItemAspectsForCategoryResponse>(response);
            return serlializedResponse;
        }

        public async Task<GetCategorySuggestionsResponse> GetCategorySuggestions(GetCategorySuggestionsRequest request)
        {
            string url = "commerce/taxonomy/v1_beta/category_tree/{0}/get_category_suggestions?q={1}";

            RestHelper helper = new RestHelper(string.Format(url, request.category_tree_id,request.q));
            var response = await helper.Get();

            GetCategorySuggestionsResponse serlializedResponse = JsonConvert.DeserializeObject<GetCategorySuggestionsResponse>(response);
            return serlializedResponse;
        }

        public async Task<GetCategorySubtreeResponse> GetCategorySubtree(GetCategorySubtreeRequest request)
        {
            string url = "commerce/taxonomy/v1_beta/category_tree/{0}/get_category_subtree?category_id ={1}";

            RestHelper helper = new RestHelper(string.Format(url, request.category_tree_id, request.category_id));
            var response = await helper.Get();

            GetCategorySubtreeResponse serlializedResponse = JsonConvert.DeserializeObject<GetCategorySubtreeResponse>(response);
            return serlializedResponse;
        }

        public async Task<GetCategoryTreeResponse> GetCategoryTree(GetCategoryTreeRequest request)
        {
            string url = "commerce/taxonomy/v1_beta/category_tree/{0}";

            RestHelper helper = new RestHelper(string.Format(url, request.category_tree_id));
            var response = await helper.Get();

            GetCategoryTreeResponse serlializedResponse = JsonConvert.DeserializeObject<GetCategoryTreeResponse>(response);
            return serlializedResponse;
        }
    }

   

  




}
