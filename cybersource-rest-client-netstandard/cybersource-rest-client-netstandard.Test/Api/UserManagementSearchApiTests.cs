/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using CyberSource.Client;
using CyberSource.Api;
using CyberSource.Model;

namespace CyberSource.Test
{
    /// <summary>
    ///  Class for testing UserManagementSearchApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserManagementSearchApiTests
    {
        private UserManagementSearchApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserManagementSearchApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserManagementSearchApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserManagementSearchApi
            //Assert.IsInstanceOfType(typeof(UserManagementSearchApi), instance, "instance is a UserManagementSearchApi");
        }

        
        /// <summary>
        /// Test SearchUsers
        /// </summary>
        [Test]
        public void SearchUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SearchRequest searchRequest = null;
            //var response = instance.SearchUsers(searchRequest);
            //Assert.IsInstanceOf<UmsV1UsersGet200Response> (response, "response is UmsV1UsersGet200Response");
        }
        
    }

}
