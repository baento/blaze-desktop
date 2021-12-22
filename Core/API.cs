using Core.Properties;
using Flurl;
using Flurl.Http;

namespace Core
{
    public class API
    {
        public static string BaseUrl { get; set; }

        public static string ApiKey { get; set; }

        public static string ApiUrl
        {
            get { return BaseUrl.AppendPathSegment("api"); }
        }

        public static void Initialize()
        {
            BaseUrl = Settings.Default.ApiBaseUri;
            ApiKey = Settings.Default.ApiKey;
        }
    }
}
