using Google.Protobuf;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mime;
using System.Text;
using System.Web.Helpers;

namespace APIAutomationDemo.RestHelper
{
    public class RestApiHelper
    {
        public static RestClient _restClient;
        public static RestRequest _restRequest;
        public static IRestResponse _restResponse;
        public static string _baseUrl = "https://reqres.in";

        public RestClient SetUrl(string endpoint)
        {
            var url = _baseUrl + endpoint;
            return _restClient = new RestClient(url);
        }

        public RestRequest CreatePostRegUser(string name, string job)
        {
            var userInfo = new CreatUserInfo();
            userInfo.name = name;
            userInfo.job = job;
            //userInfo.date = new DateTime(1981, 1, 1);  //To pass date in
            _restRequest = new RestRequest(Method.POST);
            _restRequest.AddHeader("Accept", "application/json");
            _restRequest.AddJsonBody(userInfo);
            return _restRequest;
        }

        public RestRequest CreatePostRegUserFakerData()
        {
            var userInfo = new CreatUserInfo();
            var name = Faker.Name.FullName();
            var job = Faker.Lorem.GetFirstWord();
            Console.WriteLine(name);
            Console.WriteLine(job);

            userInfo.name = name;
            userInfo.job = job;
            _restRequest = new RestRequest(Method.POST);
            _restRequest.AddHeader("Accept", "application/json");
            _restRequest.AddJsonBody(userInfo);
            return _restRequest;
        }

        public static RestRequest CreatePutResquest()
        {
            _restRequest = new RestRequest(Method.PUT);
            _restRequest.AddHeader("Accept", "application/json");
            _restRequest.AddParameter("application/json", ParameterType.RequestBody);
            return _restRequest;
        }

        public static RestRequest CreateGetRequest()
        {
            _restRequest = new RestRequest(Method.GET);
            _restRequest.AddHeader("Accept", "application/json");
            return _restRequest;
        }

        public RestRequest CreateGetRequestForListUsers(int pageNumber)
        {
            var resource = "?page=" + pageNumber;
            _restRequest = new RestRequest(resource, Method.GET);
            _restRequest.AddParameter("pageNumber", pageNumber, ParameterType.UrlSegment);
            _restRequest.AddHeader("Accept", "application/json");
            return _restRequest;
        }

        public RestRequest CreateGetRequestForSingleUser(int userNumber)
        {
            var resource = "/" + userNumber;
            _restRequest = new RestRequest(resource, Method.GET);
            _restRequest.AddParameter("userNumber", userNumber, ParameterType.UrlSegment);
            _restRequest.AddHeader("Accept", "application/json");
            return _restRequest;
        }

        public RestRequest CreateDeleteRequest()
        {
            _restRequest = new RestRequest(Method.DELETE);
            _restRequest.AddHeader("Accept", "application/json");
            return _restRequest;
        }

        public IRestResponse GetResponse()
        {
            return _restClient.Execute(_restRequest);          
        }

        public ListOfUsersDTO GetResponseContent()
        {
            IRestResponse _restResponse = _restClient.Execute<List<ListOfUsersDTO>>(_restRequest);
            _restRequest.RequestFormat = DataFormat.Json;
            var contents = _restResponse.Content;
            dynamic  users = JsonConvert.DeserializeObject<ListOfUsersDTO>(contents);
            return users;
        }

        public dynamic GetResponseContentForUsers()
        {
            IRestResponse _restResponse = _restClient.Execute(_restRequest);
            //_restRequest.RequestFormat = DataFormat.Json;
            var contents = _restResponse.Content;
            dynamic users = JsonConvert.DeserializeObject(contents);
            return users;
        }

    }
}
