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
    public class LookupController
    {
        private readonly string BaseURL = "";
        private readonly string Token;

        public LookupController(string baseURL)
        {
            BaseURL = $"{baseURL}/lookup";
            Token = UserStatus.Token;
        }

        public async Task<(RequestResponse request, List<string> response)> GetClientEmailsAddresses()
        {

            var url = $"{BaseURL}/emails";

            var (requestResponse, json) = RequestHelper.GetUsingToken(url, Token, "Bearer",null).Result;

            if (!requestResponse.Success)
            {
                return (new RequestResponse() { Success = false, ErrorMessage = requestResponse.ErrorMessage }, null);
            }
            else
            {
                var result = JsonConvert.DeserializeObject<List<string>>(json);
                return await Task.FromResult((new RequestResponse() { Success = true }, result));
            }

        }

        public async Task<(RequestResponse request, List<string> response)> GetContactNumbers()
        {
            var url = $"{BaseURL}/contactNumbers";

            var (requestResponse, json) = RequestHelper.GetUsingToken(url, Token, "Bearer",null).Result;

            if (!requestResponse.Success)
            {
                return (new RequestResponse() { Success = false, ErrorMessage = requestResponse.ErrorMessage }, null);
            }
            else
            {
                var result = JsonConvert.DeserializeObject<List<string>>(json);
                return await Task.FromResult((new RequestResponse() { Success = true }, result));
            }
        }

        public async Task<(RequestResponse request, List<string> response)> GetAddresses()
        {
            var url = $"{BaseURL}/addresses";

            var (requestResponse, json) = RequestHelper.GetUsingToken(url, Token, "Bearer",null).Result;

            if (!requestResponse.Success)
            {
                return (new RequestResponse() { Success = false, ErrorMessage = requestResponse.ErrorMessage }, null);
            }
            else
            {
                var result = JsonConvert.DeserializeObject<List<string>>(json);
                return await Task.FromResult((new RequestResponse() { Success = true }, result));
            }
        }
    }
}
