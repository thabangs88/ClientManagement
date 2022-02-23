using ClientManagement.Model.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement.Helper
{
    public class RequestHelper
    {

        public static async Task<(RequestResponse RequestResponse, string json)> GetUsingToken(string requestEndpoint, string token, string headerName, object obj)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestEndpoint);

                request.Headers.Add("Authorization", $"Bearer {token}");
                request.ContentType = "application/json";
                request.Method = "GET";

                if (obj != null)
                {
                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(JsonConvert.SerializeObject(obj));
                        streamWriter.Flush();
                        streamWriter.Close();
                    }
                }
                else
                {
                    request.ContentLength = 0;
                }

                WebResponse response = request.GetResponse();
                var streamReader = new StreamReader(response.GetResponseStream());

                using (var result = (HttpWebResponse)response)
                {
                    if (result.StatusCode == HttpStatusCode.OK)
                    {
                        return await Task.FromResult((new RequestResponse() { Success = true }, streamReader.ReadToEnd()));
                    }
                    else
                    {
                        return await Task.FromResult((new RequestResponse() { Success = false, ErrorMessage = result.ToString() }, ""));
                    }
                }
            }
            catch (WebException ex)
            {

                using (var errorResponse = (HttpWebResponse)ex.Response)
                {
                    if (errorResponse.StatusCode == HttpStatusCode.Unauthorized)
                        return (new RequestResponse() { Success = false, ErrorMessage = "User is not authorized" }, "");

                    using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                        return (new RequestResponse() { Success = false, ErrorMessage = reader.ReadToEnd() }, "");
                }
            }

        }

        public static async Task<(RequestResponse RequestResponse, string json)> PostUsingToken(string requestEndpoint, string token, string headerName, object obj)
        {

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestEndpoint);

                request.Headers.Add("Authorization", $"Bearer {token}");
                request.ContentType = "application/json";
                request.Method = "POST";

                if (obj != null)
                {
                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(JsonConvert.SerializeObject(obj));
                        streamWriter.Flush();
                        streamWriter.Close();
                    }
                }
                else
                {
                    request.ContentLength = 0;
                }

                WebResponse response = request.GetResponse();
                var streamReader = new StreamReader(response.GetResponseStream());

                using (var result = (HttpWebResponse)response)
                {
                    if (result.StatusCode == HttpStatusCode.OK)
                    {
                        return await Task.FromResult((new RequestResponse() { Success = true }, streamReader.ReadToEnd()));
                    }
                    else
                    {
                        return await Task.FromResult((new RequestResponse() { Success = false, ErrorMessage = result.ToString() }, ""));
                    }
                }
            }
            catch (WebException ex)
            {

                using (var errorResponse = (HttpWebResponse)ex.Response)
                {
                    using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                    {
                        return (new RequestResponse() { Success = false, ErrorMessage = reader.ReadToEnd() }, "");
                    }
                }
            }

        }

        public static async Task<(RequestResponse response, string json)> Post(string requestEndpoint, object obj)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestEndpoint);

                request.Method = "POST";
                request.ContentType = "application/json";

                if (obj != null)
                {
                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(JsonConvert.SerializeObject(obj));
                        streamWriter.Flush();
                        streamWriter.Close();
                    }
                }
                else
                {
                    request.ContentLength = 0;
                }

                WebResponse response = request.GetResponse();
                var streamReader = new StreamReader(response.GetResponseStream());

                using (var result = (HttpWebResponse)response)
                {
                    if (result.StatusCode == HttpStatusCode.OK)
                    {
                        return (new RequestResponse() { Success = true }, streamReader.ReadToEnd());
                    }
                    else
                    {
                        return await Task.FromResult((new RequestResponse() 
                        { 
                            Success = false, ErrorMessage = result.ToString() 
                        }, ""));
                    }
                }
            }
            catch (WebException ex)
            {

                using (var errorResponse = (HttpWebResponse)ex.Response)
                {
                    using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                    {

                        return (new RequestResponse() { Success = false, ErrorMessage = reader.ReadToEnd() }, "");
                    }
                }
            }

        }

    }

}
