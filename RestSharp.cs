using System;
using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using RestSharpTest.DTO;


namespace RestSharpTest
{
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("API Test")]
    [AllureDisplayIgnored]

    public class Tests
    {

        [OneTimeSetUp]
        public void SetUp()
        {

            AllureLifecycle.Instance.CleanupResultDirectory();

        }


        [Test(Description = "Verify Users")]
        [AllureTag("GetAPI")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Hitesh")]
        [AllureSubSuite("GetUser")]




        public void VerifyUsers()
        {

            var test = new APIEndPoints<ListOfUsersDTO>();
            var user = test.GetUser("api/users?page=2");

            Assert.AreEqual(2, user.Page);
            Assert.AreEqual("Michael", user.Data[0].first_name);

        }


        [Test(Description = "Create Users")]
        [AllureTag("PostAPI")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Hitesh")]
        [AllureSubSuite("CreateUser")]

     
   
        


        public void CreateNewUsers() 
        {
            string payload = @"{
                                ""name"": ""Rahul"",
                                 ""job"": ""Member"" 
                               }";
            var api = new APIEndPoints<CreateUserDTO>();
            var user = api.CreateUser("api/users", payload);

            Assert.AreEqual("Rahul",user.Name);
            Assert.AreEqual("Member", user.Job);
     
        }


        [Test(Description = "Update Users")]
        [AllureTag("PutAPI")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Hitesh")]
        [AllureSubSuite("update User")]
        public void UpdateUser()
        {
            string payload = @"{
                                ""name"": ""Kane"",
                                 ""job"": ""Sr Member"" 
                               }";
            var api = new APIEndPoints<UpdateUserDTO>();
            var user = api.CreateUser("api/users/2", payload);

            Assert.AreEqual("Kane", user.Name);
            Assert.AreEqual("Sr Member", user.Job);

        }

    }
}