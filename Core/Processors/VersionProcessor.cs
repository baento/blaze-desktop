using Core.Model;
using Flurl;
using Flurl.Http;
using Version = Core.Model.Version;

namespace Core
{
    public class VersionProcessor
    {
        public static async Task<Version> GetVersion()
        {
            return await API.ApiUrl
                .AppendPathSegment("version")
                .GetJsonAsync<Version>();
        }
    }
}
