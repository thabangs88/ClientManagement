using ClientManagement.Helper;
using ClientManagement.Model.Request;
using ClientManagement.Model.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Controller
{
    public class AuthenticationController
    {
        private readonly string BaseURL;

        public AuthenticationController(string baseURL)
        {
            BaseURL = $"{baseURL}/authentication";
        }

        public async Task<(RequestResponse request, TokenResponse response)> AuthorizeUser(UserInfo user)
        {
            var url = $"{BaseURL}/Token";

            var (RequestResponse, json) = RequestHelper.Post(url,user).Result;

            if (!RequestResponse.Success)
            {
                var errMessae = JsonConvert.DeserializeObject<string>(RequestResponse.ErrorMessage);
                return (new RequestResponse() { Success = false, ErrorMessage = errMessae }, null);
            }
            else
            {
                var result = JsonConvert.DeserializeObject<TokenResponse>(json);
                return await Task.FromResult((new RequestResponse() { Success = true }, result));
            }
        }
    }
}
