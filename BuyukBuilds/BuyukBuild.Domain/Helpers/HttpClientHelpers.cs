using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Helpers
{
    public static class HttpClientHelpers 
    {
        public static HttpClient GetInstance(string? baseAddres = null)
        {
            var httpClient = new HttpClient(new CustomHttpClientHandler())
            {
                BaseAddress = new Uri(baseAddres)
            };
            return httpClient;
        }

        public static HttpClient GetInstanceWithBaseAuth(string username , string password, string? baseAddres = null)
        {
            var httpClient = HttpClientHelpers.GetInstance(baseAddres);

            httpClient.DefaultRequestHeaders.Add("Authorization",
                                                 "Base"+
                                                 Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{password}")));
            return httpClient;
        }


        public static HttpClient GetInstanceWithJwtAuth(string token, string? baseAddress = null)
        {
            var httpClient = HttpClientHelpers.GetInstance(baseAddress);

            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer : {token}");

            return httpClient;
        }

        public static async Task<IResult> PostJsonAsync<TIn , IResult>(this HttpClient client , string url , TIn date)
        {
            HttpContent content = new StringContent(SerializerHelper.ToJsonString(date));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/JSON");

            var result = await client.PostAsync(url, content);
            result.EnsureSuccessStatusCode();

            return await result.Content.ReadFromJsonAsync<IResult>();
        }

        public static async Task<TResult?> GetJsonAsync<TResult>(this HttpClient client , string url ,
            params KeyValuePair<string , object>[] queryParams)
        {
            string queryString = "";
            if(queryParams is not null && queryParams.Length != 0)
            {
                queryString = "?" + string.Join("&", queryParams.Select(x => $"{x.Key} = {x.Value}"));
            }

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/JSON"));

            var result = await client.GetAsync(url + queryString);
            
            result.EnsureSuccessStatusCode();

            return await result.Content.ReadFromJsonAsync<TResult>();
        }

    }
}
