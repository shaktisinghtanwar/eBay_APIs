﻿using EbaySdkLib.Constants;
using EbaySdkLib.Messages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        public async Task<Tuple<string, HttpStatusCode>> Get()
            {
            string resultContent = null;
            HttpStatusCode statusCode;
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(ApplicationConstants.BASE_URL);
            httpClient.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", ApplicationConstants.TOKEN));
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header
            var response = await httpClient.GetAsync(url);
            statusCode = response.StatusCode;
            resultContent = await response.Content.ReadAsStringAsync();
            return new Tuple<String, HttpStatusCode>(resultContent, statusCode);
            }

        public async Task<Tuple<string, HttpStatusCode>> Post(string body)
            {
            string resultContent = null;
            HttpStatusCode statusCode;
            try
                {
                using (var client = new HttpClient())
                    {

                    client.BaseAddress = new Uri(ApplicationConstants.BASE_URL);
                    client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", ApplicationConstants.TOKEN));
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(ApplicationConstants.CONTENT_TYPE));
                    var stringContent = new StringContent(body, UnicodeEncoding.UTF8, "application/json");

                    var result = client.PostAsync(url, stringContent).Result;
                    statusCode = result.StatusCode;
                    resultContent = await result.Content.ReadAsStringAsync();
                    Console.WriteLine(resultContent);
                    }
                }
            catch (Exception ex)
                {

                throw;
                }

            return new Tuple<string, HttpStatusCode>(resultContent, statusCode);
            }


        public async Task<Tuple<String, HttpStatusCode>> Delete(string ID)
            {

            string resultContent = null;
            HttpStatusCode statusCode;
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
                    statusCode = result.StatusCode;
                    resultContent = await result.Content.ReadAsStringAsync();

                    }
                }
            catch (Exception ex)
                {

                throw;
                }

            return new Tuple<string, HttpStatusCode>(resultContent, statusCode);

            }


        public async Task<Tuple<String, HttpStatusCode>> Put(string body)
            {
            string resultContent = null;
            System.Net.HttpStatusCode statusCode;
            try
                {
                using (var client = new HttpClient())
                    {

                    client.BaseAddress = new Uri(ApplicationConstants.BASE_URL);
                    client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", ApplicationConstants.TOKEN));
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(ApplicationConstants.CONTENT_TYPE));


                    var stringContent = new StringContent(body, UnicodeEncoding.UTF8, "application/json");
                    var result = client.PutAsync(url, stringContent).Result;
                    statusCode = result.StatusCode;
                    resultContent = result.Content.ReadAsStringAsync().Result;
                    }
                }
            catch (Exception ex)
                {

                throw;
                }

            return new Tuple<string, HttpStatusCode>(resultContent, statusCode);
            }


        }
    }
