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
    ///  Class for testing MagneticEncoderApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MagneticEncoderApiTests : IDisposable
    {
        private MagneticEncoderApi instance;

        public MagneticEncoderApiTests()
        {
            instance = new MagneticEncoderApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MagneticEncoderApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MagneticEncoderApi
            //Assert.IsType<MagneticEncoderApi>(instance);
        }

        /// <summary>
        /// Test GetMagneticConfiguration
        /// </summary>
        [Fact]
        public void GetMagneticConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int jobTemplateId = null;
            //var response = instance.GetMagneticConfiguration(jobTemplateId);
            //Assert.IsType<MagneticStripeConfigurationDto>(response);
        }

        /// <summary>
        /// Test ReadData
        /// </summary>
        [Fact]
        public void ReadDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ReadData();
            //Assert.IsType<MagStripeDataDto>(response);
        }

        /// <summary>
        /// Test UpdateMagneticConfiguration
        /// </summary>
        [Fact]
        public void UpdateMagneticConfigurationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int jobTemplateId = null;
            //MagneticStripeConfigurationDto magneticStripeConfigurationDto = null;
            //instance.UpdateMagneticConfiguration(jobTemplateId, magneticStripeConfigurationDto);
        }

        /// <summary>
        /// Test WriteData
        /// </summary>
        [Fact]
        public void WriteDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? useHiCoercivity = null;
            //MagStripeDataDto magStripeDataDto = null;
            //instance.WriteData(useHiCoercivity, magStripeDataDto);
        }
    }
}