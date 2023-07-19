/*
 * aida
 *
 * 1.0.366
 *
 * The version of the OpenAPI document: 1.0.366
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Aida.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Aida.Sdk.Client.OpenAPIDateConverter;

namespace Aida.Sdk.Model
{
    /// <summary>
    /// Defines MachineModel
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MachineModel
    {
        /// <summary>
        /// Enum VirtualDevice for value: VirtualDevice
        /// </summary>
        [EnumMember(Value = "VirtualDevice")]
        VirtualDevice = 1,

        /// <summary>
        /// Enum ID5 for value: ID5
        /// </summary>
        [EnumMember(Value = "ID5")]
        ID5 = 2,

        /// <summary>
        /// Enum ID6 for value: ID6
        /// </summary>
        [EnumMember(Value = "ID6")]
        ID6 = 3,

        /// <summary>
        /// Enum ID7 for value: ID7
        /// </summary>
        [EnumMember(Value = "ID7")]
        ID7 = 4,

        /// <summary>
        /// Enum IDX for value: IDX
        /// </summary>
        [EnumMember(Value = "IDX")]
        IDX = 5,

        /// <summary>
        /// Enum XP24 for value: XP24
        /// </summary>
        [EnumMember(Value = "XP24")]
        XP24 = 6,

        /// <summary>
        /// Enum XP24J for value: XP24J
        /// </summary>
        [EnumMember(Value = "XP24J")]
        XP24J = 7,

        /// <summary>
        /// Enum BOX for value: BOX
        /// </summary>
        [EnumMember(Value = "BOX")]
        BOX = 8

    }

}
