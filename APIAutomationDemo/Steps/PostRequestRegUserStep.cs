using APIAutomationDemo.RestHelper;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace APIAutomationDemo.Steps
{
    [Binding]
    class PostRequestRegUserStep
    {
        RestApiHelper _restHelper;
        

        [When(@"I register a user by making a GET request on the endpoint with ""(.*)"" and ""(.*)""")]
        public void WhenIRegisterAUserByMakingAGETRequestOnTheEndpointWithAnd(string name, string job)
        {
            _restHelper = new RestApiHelper();
            _restHelper.CreatePostRegUser(name, job);
        }

        [When(@"I register a user by making a GET request on the endpoint with fake and random name and job")]
        public void WhenIRegisterAUserByMakingAGETRequestOnTheEndpointWithFakeAndRandomNameAndJob()
        {
            _restHelper = new RestApiHelper();
            _restHelper.CreatePostRegUserFakerData();

        }
        
    }
}
