using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using RestSharp;
using RestSharpTest.DTO;

namespace RestSharpTest
{
    class APIEndPoints<T>
    {

        public UpdateUserDTO UpdateUser(string endpoint, dynamic payload)
        {
            var user = new APIHelper<UpdateUserDTO>();
            var url = user.SetURL(endpoint);
            var request = user.CreatePutRequest(payload);
            var response = user.GetResponse(url, request);
            UpdateUserDTO content = user.GetContent<UpdateUserDTO>(response);
            return content;
        }

        public ListOfUsersDTO GetUser(string endpoint)
        {

            var user = new APIHelper<ListOfUsersDTO>();
            var url = user.SetURL(endpoint);
            var request = user.CreateGetRequest();
            var response = user.GetResponse(url, request);
            ListOfUsersDTO content = user.GetContent<ListOfUsersDTO>(response);
            return content;

        }



        public CreateUserDTO CreateUser(string endpoint, dynamic payload)
        {
            var user = new APIHelper<CreateUserDTO>();
            var url = user.SetURL(endpoint);
            var request = user.CreatePostRequest(payload);
            var response = user.GetResponse(url, request);
            CreateUserDTO content = user.GetContent<CreateUserDTO>(response);
            return content;
        }

        

    }
}
