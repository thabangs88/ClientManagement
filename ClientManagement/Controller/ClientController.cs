using ClientManagement.Helper;
using ClientManagement.Model.Request;
using ClientManagement.Model.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement
{
    public class ClientController
    {
        private readonly string BaseURL = "";
        private readonly string Token;

        public ClientController(string baseURL)
        {
            BaseURL = $"{baseURL}/client";
            Token = UserStatus.Token;
        }


        public async Task<( RequestResponse request, ResultResponse response)> CreateClient(ClientInfo client)
        {

            var url = $"{BaseURL}/create";

            var (requestResponse, json)= RequestHelper.PostUsingToken(url, Token, "Bearer", client).Result;

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

        public async Task<(RequestResponse request, ResultResponse response)> UpdateClient(ClientInfo client)
        {
            var url = $"{BaseURL}/update";

            var (requestResponse, json)= RequestHelper.PostUsingToken(url, Token, "Bearer", client).Result;

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

        public async Task<(RequestResponse request, ClientInfo response)> GetClientInfoById(int? clientId)
        {
            var url = $"{BaseURL}/getClientInfoById?clientId={clientId}";

            var (requestResponse, json)= RequestHelper.GetUsingToken(url, Token, "Bearer", null).Result;

            if (!requestResponse.Success)
            {
                return (new RequestResponse() { Success = false, ErrorMessage = requestResponse.ErrorMessage }, null);
            }
            else
            {
                var result = JsonConvert.DeserializeObject<ClientInfo>(json);
                return await Task.FromResult((new RequestResponse() { Success = true }, result));
            }
        }

        public async Task<(RequestResponse request, ClientInfo response)> GetClientInfoByName(string keyword)
        {
            var url = $"{BaseURL}/GetClientInfoByName? keyword={keyword}";

            var (requestResponse, json)= RequestHelper.GetUsingToken(url, Token, "Bearer", null).Result;

            if (!requestResponse.Success)
            {
                return (new RequestResponse() { Success = false, ErrorMessage = requestResponse.ErrorMessage }, null);
            }
            else
            {
                var result = JsonConvert.DeserializeObject<ClientInfo>(json);
                return await Task.FromResult((new RequestResponse() { Success = true }, result));
            }
        }

        public async Task<(RequestResponse request, List<ClientAddressResponse> response)> SmartSearch(string keyword)
        {
            var url = $"{BaseURL}/SmartSearch?keyword={keyword}";

            var (requestResponse, json)= RequestHelper.GetUsingToken(url, Token, "Bearer", null).Result;

            if (!requestResponse.Success)
            {
                return (new RequestResponse() { Success = false, ErrorMessage = requestResponse.ErrorMessage }, null);
            }
            else
            {
                var result = JsonConvert.DeserializeObject<List<ClientAddressResponse>>(json);
                return await Task.FromResult((new RequestResponse() { Success = true }, result));
            }
        }

        public async Task<(RequestResponse request, List<ClientAddressResponse> response)> GetAllClientsWithAddress()
        {
            var url = $"{BaseURL}/GetAllClientsWithAddress";

            var (requestResponse, json)= RequestHelper.GetUsingToken(url, Token, "Bearer", null).Result;

            if (!requestResponse.Success)
            {
                return (new RequestResponse() { Success = false, ErrorMessage = requestResponse.ErrorMessage }, null);
            }
            else
            {
                var result = JsonConvert.DeserializeObject<List<ClientAddressResponse>>(json);
                return await Task.FromResult((new RequestResponse() { Success = true }, result));
            }
        }

        public async Task<(RequestResponse request, ResultResponse response)> DeleteClientAddress(int? clientId, int? clientAddressId)
        {
            var url = $"{BaseURL}/DeleteClientAddress?clientId={clientId}&clientAddressId={clientAddressId}";

            var (requestResponse, json)= RequestHelper.PostUsingToken(url, Token, "Bearer", null).Result;

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
        public async Task<(RequestResponse request, ResultResponse response)> DeleteClientContact(int? clientId, int? clientAddressId)
        {
            var url = $"{BaseURL}/DeleteClientContact?clientId={clientId}&clientContactId={clientAddressId}";

            var (requestResponse, json)= RequestHelper.PostUsingToken(url, Token, "Bearer", null).Result;

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
