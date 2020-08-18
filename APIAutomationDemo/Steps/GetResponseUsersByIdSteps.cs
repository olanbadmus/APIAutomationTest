using APIAutomationDemo.RestHelper;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace APIAutomationDemo.Steps
{
    [Binding]
    class GetResponseUsersByIdSteps
    {
        RestApiHelper _restHelper;

        [When(@"I make a GET request on resource id ""(.*)""")]
        public void WhenIMakeAGETRequestOnResourceId(int userId)
        {
            _restHelper = new RestApiHelper();
            _restHelper.CreateGetRequestForSingleUser(userId);
        }

        [Then(@"I should get the following response for user id 1")]
        public void ThenIShouldGetTheFollowingResponseForUserId1(Table table)
        {
            _restHelper = new RestApiHelper();
            dynamic response = _restHelper.GetResponseContentForUsers();
            var expResult1 = table.CreateInstance<RestHelper.Data>();

            Assert.That(Convert.ToInt16(response.data.id), Is.EqualTo(expResult1.id));
            Assert.That(response.data.email.ToString(), Is.EqualTo(expResult1.email));
            Assert.That(response.data.first_name.ToString(), Is.EqualTo(expResult1.first_name));
            Assert.That(response.data.last_name.ToString(), Is.EqualTo(expResult1.last_name));
            Assert.That(response.ad.company.ToString(), Is.EqualTo(expResult1.company));
            Assert.That(response.ad.url.ToString(), Is.EqualTo(expResult1.url));
            Assert.IsTrue(response.ad.text.ToString().Contains(expResult1.text));
        }

        [Then(@"I should get the following response for user id 2")]
        public void ThenIShouldGetTheFollowingResponseForUserId2(Table table)
        {
            ThenIShouldGetTheFollowingResponseForUserId1(table);
        }

        [Then(@"I should get the following response for user id 3")]
        public void ThenIShouldGetTheFollowingResponseForUserId3(Table table)
        {
            ThenIShouldGetTheFollowingResponseForUserId1(table);
        }

        [Then(@"I should get the following response for user id 4")]
        public void ThenIShouldGetTheFollowingResponseForUserId4(Table table)
        {
            ThenIShouldGetTheFollowingResponseForUserId1(table);
        }

        [Then(@"I should get the following response for user id 5")]
        public void ThenIShouldGetTheFollowingResponseForUserId5(Table table)
        {
            ThenIShouldGetTheFollowingResponseForUserId1(table);
        }

    }
}
