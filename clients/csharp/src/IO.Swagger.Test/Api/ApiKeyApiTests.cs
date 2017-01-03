/* 
 * BitMEX API
 *
 * REST API for the BitMEX.com trading platform.<br><br><a href=\"/app/restAPI\">REST Documentation</a><br><a href=\"/app/wsAPI\">Websocket Documentation</a>
 *
 * OpenAPI spec version: 1.2.0
 * Contact: support@bitmex.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ApiKeyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ApiKeyApiTests
    {
        private ApiKeyApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ApiKeyApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ApiKeyApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' ApiKeyApi
            Assert.IsInstanceOfType(typeof(ApiKeyApi), instance, "instance is a ApiKeyApi");
        }

        
        /// <summary>
        /// Test ApiKeyDisable
        /// </summary>
        [Test]
        public void ApiKeyDisableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiKeyID = null;
            //var response = instance.ApiKeyDisable(apiKeyID);
            //Assert.IsInstanceOf<ApiKey> (response, "response is ApiKey");
        }
        
        /// <summary>
        /// Test ApiKeyEnable
        /// </summary>
        [Test]
        public void ApiKeyEnableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiKeyID = null;
            //var response = instance.ApiKeyEnable(apiKeyID);
            //Assert.IsInstanceOf<ApiKey> (response, "response is ApiKey");
        }
        
        /// <summary>
        /// Test ApiKeyGet
        /// </summary>
        [Test]
        public void ApiKeyGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? reverse = null;
            //var response = instance.ApiKeyGet(reverse);
            //Assert.IsInstanceOf<List<ApiKey>> (response, "response is List<ApiKey>");
        }
        
        /// <summary>
        /// Test ApiKeyNew
        /// </summary>
        [Test]
        public void ApiKeyNewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string cidr = null;
            //string permissions = null;
            //bool? enabled = null;
            //string token = null;
            //var response = instance.ApiKeyNew(name, cidr, permissions, enabled, token);
            //Assert.IsInstanceOf<ApiKey> (response, "response is ApiKey");
        }
        
        /// <summary>
        /// Test ApiKeyRemove
        /// </summary>
        [Test]
        public void ApiKeyRemoveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apiKeyID = null;
            //var response = instance.ApiKeyRemove(apiKeyID);
            //Assert.IsInstanceOf<InlineResponse200> (response, "response is InlineResponse200");
        }
        
    }

}