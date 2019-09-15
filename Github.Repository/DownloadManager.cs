using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Github.Repository
{
    public class DownloadManager
    {
        public async Task<string> DownloadNewsFeedDataAsync(string url)
        {
            try
            {
                using(var wc=new WebClient())
                {
                    return await wc.DownloadStringTaskAsync(url);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public async Task<string> DownloadDataAsync(string url)
        {
            try
            {
                using (var client = new HttpClient())
                {
                
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("Github.Repository", "1.0"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", ApiManager.Instance.Token);
                   
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                   var res= await client.GetStringAsync(url);
                    return res;
                }
            }
            catch (Exception ex)
            {

                return null;
            }

        }
    }
}
