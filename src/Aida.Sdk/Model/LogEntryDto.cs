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
    /// LogEntryDto
    /// </summary>
    [DataContract(Name = "LogEntryDto")]
    public partial class LogEntryDto : IEquatable<LogEntryDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogEntryDto" /> class.
        /// </summary>
        /// <param name="clusterName">clusterName.</param>
        /// <param name="exception">exception.</param>
        /// <param name="exceptionType">exceptionType.</param>
        /// <param name="level">level.</param>
        /// <param name="machineName">machineName.</param>
        /// <param name="message">message.</param>
        /// <param name="messageTemplate">messageTemplate.</param>
        /// <param name="nodeId">nodeId.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="serverVersion">serverVersion.</param>
        /// <param name="threadId">threadId.</param>
        /// <param name="moduleName">moduleName.</param>
        /// <param name="eventType">eventType.</param>
        /// <param name="workflowInstanceId">workflowInstanceId.</param>
        /// <param name="correlationId">correlationId.</param>
        /// <param name="properties">properties.</param>
        public LogEntryDto(string clusterName = default(string), string exception = default(string), string exceptionType = default(string), string level = default(string), string machineName = default(string), string message = default(string), string messageTemplate = default(string), string nodeId = default(string), DateTime timestamp = default(DateTime), string serverVersion = default(string), int threadId = default(int), string moduleName = default(string), string eventType = default(string), string workflowInstanceId = default(string), string correlationId = default(string), string properties = default(string))
        {
            this.ClusterName = clusterName;
            this.Exception = exception;
            this.ExceptionType = exceptionType;
            this.Level = level;
            this.MachineName = machineName;
            this.Message = message;
            this.MessageTemplate = messageTemplate;
            this.NodeId = nodeId;
            this.Timestamp = timestamp;
            this.ServerVersion = serverVersion;
            this.ThreadId = threadId;
            this.ModuleName = moduleName;
            this.EventType = eventType;
            this.WorkflowInstanceId = workflowInstanceId;
            this.CorrelationId = correlationId;
            this.Properties = properties;
        }

        /// <summary>
        /// Gets or Sets ClusterName
        /// </summary>
        [DataMember(Name = "clusterName", EmitDefaultValue = true)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Gets or Sets Exception
        /// </summary>
        [DataMember(Name = "exception", EmitDefaultValue = true)]
        public string Exception { get; set; }

        /// <summary>
        /// Gets or Sets ExceptionType
        /// </summary>
        [DataMember(Name = "exceptionType", EmitDefaultValue = true)]
        public string ExceptionType { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", EmitDefaultValue = true)]
        public string Level { get; set; }

        /// <summary>
        /// Gets or Sets MachineName
        /// </summary>
        [DataMember(Name = "machineName", EmitDefaultValue = true)]
        public string MachineName { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets MessageTemplate
        /// </summary>
        [DataMember(Name = "messageTemplate", EmitDefaultValue = true)]
        public string MessageTemplate { get; set; }

        /// <summary>
        /// Gets or Sets NodeId
        /// </summary>
        [DataMember(Name = "nodeId", EmitDefaultValue = true)]
        public string NodeId { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets ServerVersion
        /// </summary>
        [DataMember(Name = "serverVersion", EmitDefaultValue = true)]
        public string ServerVersion { get; set; }

        /// <summary>
        /// Gets or Sets ThreadId
        /// </summary>
        [DataMember(Name = "threadId", EmitDefaultValue = false)]
        public int ThreadId { get; set; }

        /// <summary>
        /// Gets or Sets ModuleName
        /// </summary>
        [DataMember(Name = "moduleName", EmitDefaultValue = true)]
        public string ModuleName { get; set; }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", EmitDefaultValue = true)]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or Sets WorkflowInstanceId
        /// </summary>
        [DataMember(Name = "workflowInstanceId", EmitDefaultValue = true)]
        public string WorkflowInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets CorrelationId
        /// </summary>
        [DataMember(Name = "correlationId", EmitDefaultValue = true)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public string Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogEntryDto {\n");
            sb.Append("  ClusterName: ").Append(ClusterName).Append("\n");
            sb.Append("  Exception: ").Append(Exception).Append("\n");
            sb.Append("  ExceptionType: ").Append(ExceptionType).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  MachineName: ").Append(MachineName).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  MessageTemplate: ").Append(MessageTemplate).Append("\n");
            sb.Append("  NodeId: ").Append(NodeId).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  ServerVersion: ").Append(ServerVersion).Append("\n");
            sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
            sb.Append("  ModuleName: ").Append(ModuleName).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  WorkflowInstanceId: ").Append(WorkflowInstanceId).Append("\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogEntryDto);
        }

        /// <summary>
        /// Returns true if LogEntryDto instances are equal
        /// </summary>
        /// <param name="input">Instance of LogEntryDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogEntryDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClusterName == input.ClusterName ||
                    (this.ClusterName != null &&
                    this.ClusterName.Equals(input.ClusterName))
                ) && 
                (
                    this.Exception == input.Exception ||
                    (this.Exception != null &&
                    this.Exception.Equals(input.Exception))
                ) && 
                (
                    this.ExceptionType == input.ExceptionType ||
                    (this.ExceptionType != null &&
                    this.ExceptionType.Equals(input.ExceptionType))
                ) && 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.MachineName == input.MachineName ||
                    (this.MachineName != null &&
                    this.MachineName.Equals(input.MachineName))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.MessageTemplate == input.MessageTemplate ||
                    (this.MessageTemplate != null &&
                    this.MessageTemplate.Equals(input.MessageTemplate))
                ) && 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.ServerVersion == input.ServerVersion ||
                    (this.ServerVersion != null &&
                    this.ServerVersion.Equals(input.ServerVersion))
                ) && 
                (
                    this.ThreadId == input.ThreadId ||
                    this.ThreadId.Equals(input.ThreadId)
                ) && 
                (
                    this.ModuleName == input.ModuleName ||
                    (this.ModuleName != null &&
                    this.ModuleName.Equals(input.ModuleName))
                ) && 
                (
                    this.EventType == input.EventType ||
                    (this.EventType != null &&
                    this.EventType.Equals(input.EventType))
                ) && 
                (
                    this.WorkflowInstanceId == input.WorkflowInstanceId ||
                    (this.WorkflowInstanceId != null &&
                    this.WorkflowInstanceId.Equals(input.WorkflowInstanceId))
                ) && 
                (
                    this.CorrelationId == input.CorrelationId ||
                    (this.CorrelationId != null &&
                    this.CorrelationId.Equals(input.CorrelationId))
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ClusterName != null)
                {
                    hashCode = (hashCode * 59) + this.ClusterName.GetHashCode();
                }
                if (this.Exception != null)
                {
                    hashCode = (hashCode * 59) + this.Exception.GetHashCode();
                }
                if (this.ExceptionType != null)
                {
                    hashCode = (hashCode * 59) + this.ExceptionType.GetHashCode();
                }
                if (this.Level != null)
                {
                    hashCode = (hashCode * 59) + this.Level.GetHashCode();
                }
                if (this.MachineName != null)
                {
                    hashCode = (hashCode * 59) + this.MachineName.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.MessageTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.MessageTemplate.GetHashCode();
                }
                if (this.NodeId != null)
                {
                    hashCode = (hashCode * 59) + this.NodeId.GetHashCode();
                }
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                if (this.ServerVersion != null)
                {
                    hashCode = (hashCode * 59) + this.ServerVersion.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ThreadId.GetHashCode();
                if (this.ModuleName != null)
                {
                    hashCode = (hashCode * 59) + this.ModuleName.GetHashCode();
                }
                if (this.EventType != null)
                {
                    hashCode = (hashCode * 59) + this.EventType.GetHashCode();
                }
                if (this.WorkflowInstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkflowInstanceId.GetHashCode();
                }
                if (this.CorrelationId != null)
                {
                    hashCode = (hashCode * 59) + this.CorrelationId.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
