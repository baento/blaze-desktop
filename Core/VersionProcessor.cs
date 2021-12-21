using Version = Core.Model.Version;

namespace Core
{
    public class VersionProcessor
    {
        public static async Task<Version> GetVersion()
        {
            using (HttpResponseMessage response = await API.APIClient.GetAsync("version"))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<Version>();
                }
                else
                {
                    throw new Exception(response.StatusCode.ToString());
                }
            }
        }
    }
}
