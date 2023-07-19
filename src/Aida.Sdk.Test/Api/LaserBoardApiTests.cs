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
    ///  Class for testing LaserBoardApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LaserBoardApiTests : IDisposable
    {
        private LaserBoardApi instance;

        public LaserBoardApiTests()
        {
            instance = new LaserBoardApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LaserBoardApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' LaserBoardApi
            //Assert.IsType<LaserBoardApi>(instance);
        }

        /// <summary>
        /// Test GetProperties
        /// </summary>
        [Fact]
        public void GetPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetProperties();
            //Assert.IsType<List<PropertyDto>>(response);
        }

        /// <summary>
        /// Test SetProperties
        /// </summary>
        [Fact]
        public void SetPropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string scannerId = null;
            //List<PropertyDto> propertyDto = null;
            //var response = instance.SetProperties(scannerId, propertyDto);
            //Assert.IsType<List<PropertyDto>>(response);
        }
    }
}
