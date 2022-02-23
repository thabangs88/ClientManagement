
using UserInfo = ClientManagement.Model.Request;
using ClientManagement.Model.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientManagement.Helper;

namespace ClientManagement.Controller
{
    public class UserController
    {
        private readonly string BaseURL = "";
        private readonly string Token;

        public UserController(string baseURL)
        {
            BaseURL = $"{baseURL}/user";
            Token = UserStatus.Token;
        }

        public async Task<(RequestResponse request, ResultResponse response)> CreateUser(UserInfo.User model)
        {
            var url = $"{BaseURL}/create";

            var (requestResponse, json) = RequestHelper.PostUsingToken(url, Token, "Bearer", model).Result;

            if (!requestResponse.Success)
            {
                return (new RequestResponse() { Success = false, ErrorMessage = requestResponse.ErrorMessage }, null);
            }
            else
            {
                var result = JsonConvert.DeserializeObject<ResultResponse>(json);
                return await Task.FromResult((new RequestResponse() { Success = true }, result));
            }
        }
    }
}
