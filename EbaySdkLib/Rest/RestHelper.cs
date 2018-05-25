using EbaySdkLib.Constants;
using EbaySdkLib.Messages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EbaySdkLib
    {
    class RestHelper
        {
        private readonly string url;

        public RestHelper(string url)
            {
            this.url = url;// string.Format("{0}{1}", _baseUrl, url);
            }
        public async Task<string> Get()
            {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(ApplicationConstants.BASE_URL);
            httpClient.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", ApplicationConstants.TOKEN));
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header
            // httpClient.DefaultRequestHeaders.Add("Content-Type","application/json");

            var response = await httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
            }


        public async Task<string> Post(string body)
            {
            string resultContent = null;
            try
                {
                using (var client = new HttpClient())
                    {
                    if (url.ToString().Contains(ApplicationConstants.InventoryOffer_Url))
                        {
                        client.DefaultRequestHeaders.Add("Content-Language", ApplicationConstants.CONTENT_LANGUAGE);
                        }
                    client.BaseAddress = new Uri(ApplicationConstants.BASE_URL);
                    client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", ApplicationConstants.TOKEN));
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(ApplicationConstants.CONTENT_TYPE));
                    var stringContent = new StringContent(body, UnicodeEncoding.UTF8, "application/json");

                    var result = client.PostAsync(url, stringContent).Result;
                    resultContent = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(resultContent);
                    }
                }
            catch (Exception ex)
                {

                throw;
                }

            return resultContent;
            }


        public async Task<string> Delete(string ID)
            {
            string resultContent = null;
            try
                {
                using (var client = new HttpClient())
                    {
                    client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", ApplicationConstants.TOKEN));
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(ApplicationConstants.CONTENT_TYPE));
                    client.BaseAddress = new Uri(ApplicationConstants.BASE_URL);
                    var content = new FormUrlEncodedContent(new[]
                    {
                new KeyValuePair<string, string>("", ID)
                });
                    var result = await client.DeleteAsync(url);
                    resultContent = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(resultContent);
                    }
                }
            catch (Exception ex)
                {

                throw;
                }

            return resultContent;

            }


        public async Task<String> Put(string body)
            {
            string resultContent = null;
            try
                {
                using (var client = new HttpClient())
                    {

                    client.BaseAddress = new Uri(ApplicationConstants.BASE_URL);
                    client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", ApplicationConstants.TOKEN));
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(ApplicationConstants.CONTENT_TYPE));


                    var stringContent = new StringContent(body, UnicodeEncoding.UTF8, "application/json");
                    var result = client.PutAsync(url, stringContent).Result;
                    resultContent = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(resultContent);
                    }
                }
            catch (Exception ex)
                {

                throw;
                }

            return resultContent;
            }

        }
    }
