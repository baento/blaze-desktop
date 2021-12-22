using User = Core.Model.User;
using Flurl;
using Flurl.Http;

namespace Core
{
    public class UserProcessor
    {
        public static Task<User> GetUser(uint id)
        {
            return API.ApiUrl
                .AppendPathSegment("users")
                .AppendPathSegment(id)
                .GetJsonAsync<User>();
        }

        public static Task<User[]> GetUsers()
        {
            return API.ApiUrl
                .AppendPathSegment("users")
                .GetJsonAsync<User[]>();
        }
    }
}
