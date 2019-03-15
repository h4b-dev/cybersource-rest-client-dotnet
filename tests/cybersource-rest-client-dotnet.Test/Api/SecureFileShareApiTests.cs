/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;
using CyberSource.Api;

namespace CyberSource.Test
{
    /// <summary>
    ///  Class for testing SecureFileShareApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SecureFileShareApiTests
    {
        private SecureFileShareApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SecureFileShareApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SecureFileShareApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SecureFileShareApi
            //Assert.IsInstanceOfType(typeof(SecureFileShareApi), instance, "instance is a SecureFileShareApi");
        }

        
        /// <summary>
        /// Test GetFile
        /// </summary>
        [Test]
        public void GetFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fileId = null;
            //string organizationId = null;
            //instance.GetFile(fileId, organizationId);
            
        }
        
        /// <summary>
        /// Test GetFileDetails
        /// </summary>
        [Test]
        public void GetFileDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? startDate = null;
            //DateTime? endDate = null;
            //string organizationId = null;
            //var response = instance.GetFileDetails(startDate, endDate, organizationId);
            //Assert.IsInstanceOf<V1FileDetailsGet200Response> (response, "response is V1FileDetailsGet200Response");
        }
        
    }

}
