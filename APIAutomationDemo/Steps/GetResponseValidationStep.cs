using APIAutomationDemo.RestHelper;
using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace APIAutomationDemo.Steps
{
    [Binding]
    class GetResponseValidationStep
    {
        RestApiHelper _helper;

        [Then(@"I should get the following response contents for id 7")]
        public void ThenIShouldGetTheFollowingResponseContentsForId7(Table table)
        {
            _helper = new RestApiHelper();
            dynamic response = _helper.GetResponseContent();
            var expResult = table.CreateInstance<RestHelper.Data>();

            Assert.That(response.Data[0].id, Is.EqualTo(expResult.id));
            Assert.That(response.Data[0].email, Is.EqualTo(expResult.email));
            Assert.That(response.Data[0].first_name, Is.EqualTo(expResult.first_name));
            Assert.That(response.Data[0].last_name, Is.EqualTo(expResult.last_name));
        }

        [Then(@"I should get the following response contents for id 8")]
        public void ThenIShouldGetTheFollowingResponseContentsForId8(Table table)
        {
            _helper = new RestApiHelper();
            dynamic response = _helper.GetResponseContent();
            var expResult = table.CreateInstance<RestHelper.Data>();

            Assert.That(response.Data[1].id, Is.EqualTo(expResult.id));
            Assert.That(response.Data[1].email, Is.EqualTo(expResult.email));
            Assert.That(response.Data[1].first_name, Is.EqualTo(expResult.first_name));
            Assert.That(response.Data[1].last_name, Is.EqualTo(expResult.last_name));
        }

        [Then(@"I should get the following response contents for id 9")]
        public void ThenIShouldGetTheFollowingResponseContentsForId9(Table table)
        {
            _helper = new RestApiHelper();
            dynamic response = _helper.GetResponseContent();
            var expResult = table.CreateInstance<RestHelper.Data>();

            Assert.That(response.Data[2].id, Is.EqualTo(expResult.id));
            Assert.That(response.Data[2].email, Is.EqualTo(expResult.email));
            Assert.That(response.Data[2].first_name, Is.EqualTo(expResult.first_name));
            Assert.That(response.Data[2].last_name, Is.EqualTo(expResult.last_name));
        }

        [Then(@"I should get the following response contents for id 10")]
        public void ThenIShouldGetTheFollowingResponseContentsForId10(Table table)
        {
            _helper = new RestApiHelper();
            dynamic response = _helper.GetResponseContent();
            var expResult = table.CreateInstance<RestHelper.Data>();

            Assert.That(response.Data[3].id, Is.EqualTo(expResult.id));
            Assert.That(response.Data[3].email, Is.EqualTo(expResult.email));
            Assert.That(response.Data[3].first_name, Is.EqualTo(expResult.first_name));
            Assert.That(response.Data[3].last_name, Is.EqualTo(expResult.last_name));
        }

        [Then(@"I should get the following response contents for id 11")]
        public void ThenIShouldGetTheFollowingResponseContentsForId11(Table table)
        {
            _helper = new RestApiHelper();
            dynamic response = _helper.GetResponseContent();
            var expResult = table.CreateInstance<RestHelper.Data>();

            Assert.That(response.Data[4].id, Is.EqualTo(expResult.id));
            Assert.That(response.Data[4].email, Is.EqualTo(expResult.email));
            Assert.That(response.Data[4].first_name, Is.EqualTo(expResult.first_name));
            Assert.That(response.Data[4].last_name, Is.EqualTo(expResult.last_name));
        }

        [Then(@"I should get the following response contents for id 12")]
        public void ThenIShouldGetTheFollowingResponseContentsForId12(Table table)
        {
            _helper = new RestApiHelper();
            dynamic response = _helper.GetResponseContent();
            var expResult = table.CreateInstance<RestHelper.Data>();

            Assert.That(response.Data[5].id, Is.EqualTo(expResult.id));
            Assert.That(response.Data[5].email, Is.EqualTo(expResult.email));
            Assert.That(response.Data[5].first_name, Is.EqualTo(expResult.first_name));
            Assert.That(response.Data[5].last_name, Is.EqualTo(expResult.last_name));
        }
    }
}
