/*
 * Tusk Logistics API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Contact: devsupport@tusklogistics.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using Xunit;

using Tusk.Client;
using Tusk.Api;
using Tusk.Model;

// uncomment below to import models
//using Tusk.Model;

namespace Tusk.Test.Api
{
    /// <summary>
    ///  Class for testing ShipmentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ShipmentsApiTests : IDisposable
    {
        private ShipmentsApi instance;

        public ShipmentsApiTests()
        {
            ReadableConfiguration config = new ReadableConfiguration();
            config.BasePath = "https://apisandbox.tusklogistics.com";
            // Configure API key authorization: ApiKeyAuth
            config.ApiKey.Add("x-api-key", "X_API_KEY");
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            instance = new ShipmentsApi(httpClient, config, httpClientHandler);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShipmentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ShipmentsApi
            //Assert.IsType<ShipmentsApi>(instance);
        }

        /// <summary>
        /// Test GetaShipmentbyID
        /// </summary>
        [Fact(Skip = "Example test case, replace with proper test case")]
        public void GetaShipmentbyIDTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            int shipmentId = 5225;
            var response = instance.GetaShipmentbyID(shipmentId);
            Assert.IsType<Shipment>(response);
        }
    }
}
