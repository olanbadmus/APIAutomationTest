using APIAutomationDemo.RestHelper;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace APIAutomationDemo.Steps
{
    [Binding]
    public sealed class GetResponseListUsersStep
    {

        RestApiHelper _restHelper;

        [Given(@"I am on reqres url and on ""(.*)"" endpoint")]
        public void GivenIAmOnReqresUrlAndOnEndpoint(string endpoint)
        {
            _restHelper = new RestApiHelper();
            _restHelper.SetUrl(endpoint);
        }

        [When(@"I make a GET request on resource page ""(.*)""")]
        public void WhenIMakeAGETRequestOnResourcePage(int pageNumber)
        {
            _restHelper.CreateGetRequestForListUsers(pageNumber);
        }

        [Then(@"status code should be ""(.*)""")]
        public void ThenStatusCodeShouldBe(string statusCode)
        {
            var response = _restHelper.GetResponse();
            StringAssert.AreEqualIgnoringCase(statusCode, response.StatusCode.ToString());
        }


        [Then(@"response status should be ""(.*)""")]
        public void ThenResponseStatusShouldBe(string responseStatus)
        {
            var response = _restHelper.GetResponse();
            StringAssert.AreEqualIgnoringCase(responseStatus, response.ResponseStatus.ToString());
        }

        [Then(@"status description should be ""(.*)""")]
        public void ThenstatusdescriptionShouldBe(string statusDesc)
        {
            var response = _restHelper.GetResponse();
            StringAssert.AreEqualIgnoringCase(statusDesc, response.StatusCode.ToString());
        }

        [Then(@"response Uri should be ""(.*)""")]
        public void ThenResponseUriShouldBe(string responseUri)
        {
            var response = _restHelper.GetResponse();
            StringAssert.AreEqualIgnoringCase(responseUri, response.ResponseUri.ToString());
        }

    }
}
