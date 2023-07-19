/*
 * aida
 *
 * 1.0.366
 *
 * The version of the OpenAPI document: 1.0.366
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using Aida.Sdk.Client;
using Aida.Sdk.Api;
// uncomment below to import models
//using Aida.Sdk.Model;

namespace Aida.Sdk.Test.Api
{
    /// <summary>
    ///  Class for testing ChipEncoderApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ChipEncoderApiTests : IDisposable
    {
        private ChipEncoderApi instance;

        public ChipEncoderApiTests()
        {
            instance = new ChipEncoderApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ChipEncoderApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ChipEncoderApi
            //Assert.IsType<ChipEncoderApi>(instance);
        }

        /// <summary>
        /// Test GetChipConfiguration
        /// </summary>
        [Fact]
        public void GetChipConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int jobTemplateId = null;
            //var response = instance.GetChipConfiguration(jobTemplateId);
            //Assert.IsType<ChipEncodingConfigurationDto>(response);
        }

        /// <summary>
        /// Test RemoveChipEncodingConfiguration
        /// </summary>
        [Fact]
        public void RemoveChipEncodingConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int jobTemplateId = null;
            //var response = instance.RemoveChipEncodingConfiguration(jobTemplateId);
            //Assert.IsType<ChipEncodingConfigurationDto>(response);
        }

        /// <summary>
        /// Test UpdateChipConfiguration
        /// </summary>
        [Fact]
        public void UpdateChipConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int jobTemplateId = null;
            //ChipEncodingConfigurationDto chipEncodingConfigurationDto = null;
            //instance.UpdateChipConfiguration(jobTemplateId, chipEncodingConfigurationDto);
        }
    }
}
