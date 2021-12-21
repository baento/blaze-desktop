using System.Net.Http.Headers;

namespace Core
{
    public class API
    {
        public static HttpClient APIClient { get; set; }

        public static void Initialize()
        {
            APIClient = new HttpClient();
            APIClient.BaseAddress = new Uri(Properties.Settings.Default.ApiBaseUri);
            APIClient.DefaultRequestHeaders.Accept.Clear();
            APIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
