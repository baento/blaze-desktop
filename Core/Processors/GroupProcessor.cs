using Group = Core.Model.Group;
using Flurl;
using Flurl.Http;

namespace Core
{
    public class GroupProcessor
    {
        public static Task<Group> GetGroup(uint id)
        {
            return API.ApiUrl
                .AppendPathSegment("groups")
                .AppendPathSegment(id)
                .GetJsonAsync<Group>();
        }

        public static Task<Group[]> GetGroups()
        {
            return API.ApiUrl
                .AppendPathSegment("groups")
                .GetJsonAsync<Group[]>();
        }
    }
}
