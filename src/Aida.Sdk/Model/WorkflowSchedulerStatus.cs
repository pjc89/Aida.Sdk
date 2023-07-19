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
    /// Defines WorkflowSchedulerStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkflowSchedulerStatus
    {
        /// <summary>
        /// Enum Starting for value: Starting
        /// </summary>
        [EnumMember(Value = "Starting")]
        Starting = 1,

        /// <summary>
        /// Enum Running for value: Running
        /// </summary>
        [EnumMember(Value = "Running")]
        Running = 2,

        /// <summary>
        /// Enum Waiting for value: Waiting
        /// </summary>
        [EnumMember(Value = "Waiting")]
        Waiting = 3,

        /// <summary>
        /// Enum Error for value: Error
        /// </summary>
        [EnumMember(Value = "Error")]
        Error = 4,

        /// <summary>
        /// Enum Stopping for value: Stopping
        /// </summary>
        [EnumMember(Value = "Stopping")]
        Stopping = 5,

        /// <summary>
        /// Enum Stopped for value: Stopped
        /// </summary>
        [EnumMember(Value = "Stopped")]
        Stopped = 6,

        /// <summary>
        /// Enum FeederEmpty for value: FeederEmpty
        /// </summary>
        [EnumMember(Value = "FeederEmpty")]
        FeederEmpty = 7,

        /// <summary>
        /// Enum JobQueueEmpty for value: JobQueueEmpty
        /// </summary>
        [EnumMember(Value = "JobQueueEmpty")]
        JobQueueEmpty = 8

    }

}