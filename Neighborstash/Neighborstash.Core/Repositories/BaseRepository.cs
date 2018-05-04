using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Neighborstash.Core.Contracts
{
    public class BaseRepository
    {

        private HttpClient CreateHttpClient()
        {
            var httpclient = new HttpClient();
            httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application"));
            return httpclient;

        }

        protected async Task<T> GetAsync<T>(string url)
            where T : new()
        {
            HttpClient httpClient = CreateHttpClient();
            T result;

            try
            {
                var response = await httpClient.GetStringAsync(url);
                result = await Task.Run(()=>JsonConvert.DeserializeObject<T>(response));
            }
            catch (System.Exception)
            {

                result = new T();
            }

            return result;
        }
    }
}