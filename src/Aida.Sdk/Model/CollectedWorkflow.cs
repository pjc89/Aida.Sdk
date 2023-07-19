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
    /// CollectedWorkflow
    /// </summary>
    [DataContract(Name = "CollectedWorkflow")]
    public partial class CollectedWorkflow : IEquatable<CollectedWorkflow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectedWorkflow" /> class.
        /// </summary>
        /// <param name="workflowInstanceId">workflowInstanceId.</param>
        /// <param name="activityId">activityId.</param>
        public CollectedWorkflow(string workflowInstanceId = default(string), string activityId = default(string))
        {
            this.WorkflowInstanceId = workflowInstanceId;
            this.ActivityId = activityId;
        }

        /// <summary>
        /// Gets or Sets WorkflowInstanceId
        /// </summary>
        [DataMember(Name = "workflowInstanceId", EmitDefaultValue = true)]
        public string WorkflowInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets ActivityId
        /// </summary>
        [DataMember(Name = "activityId", EmitDefaultValue = true)]
        public string ActivityId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CollectedWorkflow {\n");
            sb.Append("  WorkflowInstanceId: ").Append(WorkflowInstanceId).Append("\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
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
            return this.Equals(input as CollectedWorkflow);
        }

        /// <summary>
        /// Returns true if CollectedWorkflow instances are equal
        /// </summary>
        /// <param name="input">Instance of CollectedWorkflow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CollectedWorkflow input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WorkflowInstanceId == input.WorkflowInstanceId ||
                    (this.WorkflowInstanceId != null &&
                    this.WorkflowInstanceId.Equals(input.WorkflowInstanceId))
                ) && 
                (
                    this.ActivityId == input.ActivityId ||
                    (this.ActivityId != null &&
                    this.ActivityId.Equals(input.ActivityId))
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
                if (this.WorkflowInstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkflowInstanceId.GetHashCode();
                }
                if (this.ActivityId != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityId.GetHashCode();
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