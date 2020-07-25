using APIAutomationDemo.RestHelper;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace APIAutomationDemo.Steps
{
    [Binding]
    class GetResponseSingleUserStep
    {
        RestApiHelper _restHelper;

        [When(@"I make a GET request on the endpoint with resource ""(.*)""")]
        public void WhenIMakeAGETRequestOnTheEndpointWithResource(int userNumber)
        {
            _restHelper = new RestApiHelper();
            _restHelper.CreateGetRequestForSingleUser(userNumber);
        }

    }

}
    

