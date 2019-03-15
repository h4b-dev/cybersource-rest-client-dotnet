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
    ///  Class for testing ReportDefinitionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ReportDefinitionsApiTests
    {
        private ReportDefinitionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ReportDefinitionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ReportDefinitionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ReportDefinitionsApi
            //Assert.IsInstanceOfType(typeof(ReportDefinitionsApi), instance, "instance is a ReportDefinitionsApi");
        }

        
        /// <summary>
        /// Test GetResourceInfoByReportDefinition
        /// </summary>
        [Test]
        public void GetResourceInfoByReportDefinitionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string reportDefinitionName = null;
            //string organizationId = null;
            //var response = instance.GetResourceInfoByReportDefinition(reportDefinitionName, organizationId);
            //Assert.IsInstanceOf<ReportingV3ReportDefinitionsNameGet200Response> (response, "response is ReportingV3ReportDefinitionsNameGet200Response");
        }
        
        /// <summary>
        /// Test GetResourceV2Info
        /// </summary>
        [Test]
        public void GetResourceV2InfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //var response = instance.GetResourceV2Info(organizationId);
            //Assert.IsInstanceOf<ReportingV3ReportDefinitionsGet200Response> (response, "response is ReportingV3ReportDefinitionsGet200Response");
        }
        
    }

}
