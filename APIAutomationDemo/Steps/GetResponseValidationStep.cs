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
        public static IRestResponse _restResponse;
        RestApiHelper _helper;

        [Then(@"I should get the following response contents")]
        public void ThenIShouldGetTheFollowingResponseContents(Table table)
        {
            _helper = new RestApiHelper();
            dynamic response = _helper.GetResponseContents();
            var expResult = table.CreateInstance<RestHelper.Data>();

            //var deserialize = new JsonDeserializer();
            //var output = deserialize.Deserialize<Dictionary<string, string>>(_restResponse);

            Assert.That(response[0], Is.EqualTo(expResult.id));
            Assert.That(response[1], Is.EqualTo(expResult.email));
            Assert.That(response[2], Is.EqualTo(expResult.first_name));
            Assert.That(response[3], Is.EqualTo(expResult.last_name));
        }

    }
}
