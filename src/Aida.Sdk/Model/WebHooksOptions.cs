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
    /// WebHooksOptions
    /// </summary>
    [DataContract(Name = "WebHooksOptions")]
    public partial class WebHooksOptions : IEquatable<WebHooksOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebHooksOptions" /> class.
        /// </summary>
        /// <param name="ackTimeout">ackTimeout.</param>
        /// <param name="executionTimeout">executionTimeout.</param>
        /// <param name="maxConnectionRetries">maxConnectionRetries.</param>
        /// <param name="useSystemWideWebhooks">useSystemWideWebhooks.</param>
        /// <param name="systemWideWebhookTarget">systemWideWebhookTarget.</param>
        public WebHooksOptions(TimeSpan ackTimeout = default(TimeSpan), TimeSpan executionTimeout = default(TimeSpan), int? maxConnectionRetries = default(int?), bool useSystemWideWebhooks = default(bool), string systemWideWebhookTarget = default(string))
        {
            this.AckTimeout = ackTimeout;
            this.ExecutionTimeout = executionTimeout;
            this.MaxConnectionRetries = maxConnectionRetries;
            this.UseSystemWideWebhooks = useSystemWideWebhooks;
            this.SystemWideWebhookTarget = systemWideWebhookTarget;
        }

        /// <summary>
        /// Gets or Sets AckTimeout
        /// </summary>
        [DataMember(Name = "ackTimeout", EmitDefaultValue = false)]
        public TimeSpan AckTimeout { get; set; }

        /// <summary>
        /// Gets or Sets ExecutionTimeout
        /// </summary>
        [DataMember(Name = "executionTimeout", EmitDefaultValue = false)]
        public TimeSpan ExecutionTimeout { get; set; }

        /// <summary>
        /// Gets or Sets MaxConnectionRetries
        /// </summary>
        [DataMember(Name = "maxConnectionRetries", EmitDefaultValue = true)]
        public int? MaxConnectionRetries { get; set; }

        /// <summary>
        /// Gets or Sets UseSystemWideWebhooks
        /// </summary>
        [DataMember(Name = "useSystemWideWebhooks", EmitDefaultValue = true)]
        public bool UseSystemWideWebhooks { get; set; }

        /// <summary>
        /// Gets or Sets SystemWideWebhookTarget
        /// </summary>
        [DataMember(Name = "systemWideWebhookTarget", EmitDefaultValue = true)]
        public string SystemWideWebhookTarget { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebHooksOptions {\n");
            sb.Append("  AckTimeout: ").Append(AckTimeout).Append("\n");
            sb.Append("  ExecutionTimeout: ").Append(ExecutionTimeout).Append("\n");
            sb.Append("  MaxConnectionRetries: ").Append(MaxConnectionRetries).Append("\n");
            sb.Append("  UseSystemWideWebhooks: ").Append(UseSystemWideWebhooks).Append("\n");
            sb.Append("  SystemWideWebhookTarget: ").Append(SystemWideWebhookTarget).Append("\n");
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
            return this.Equals(input as WebHooksOptions);
        }

        /// <summary>
        /// Returns true if WebHooksOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of WebHooksOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebHooksOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AckTimeout == input.AckTimeout ||
                    (this.AckTimeout != null &&
                    this.AckTimeout.Equals(input.AckTimeout))
                ) && 
                (
                    this.ExecutionTimeout == input.ExecutionTimeout ||
                    (this.ExecutionTimeout != null &&
                    this.ExecutionTimeout.Equals(input.ExecutionTimeout))
                ) && 
                (
                    this.MaxConnectionRetries == input.MaxConnectionRetries ||
                    (this.MaxConnectionRetries != null &&
                    this.MaxConnectionRetries.Equals(input.MaxConnectionRetries))
                ) && 
                (
                    this.UseSystemWideWebhooks == input.UseSystemWideWebhooks ||
                    this.UseSystemWideWebhooks.Equals(input.UseSystemWideWebhooks)
                ) && 
                (
                    this.SystemWideWebhookTarget == input.SystemWideWebhookTarget ||
                    (this.SystemWideWebhookTarget != null &&
                    this.SystemWideWebhookTarget.Equals(input.SystemWideWebhookTarget))
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
                if (this.AckTimeout != null)
                {
                    hashCode = (hashCode * 59) + this.AckTimeout.GetHashCode();
                }
                if (this.ExecutionTimeout != null)
                {
                    hashCode = (hashCode * 59) + this.ExecutionTimeout.GetHashCode();
                }
                if (this.MaxConnectionRetries != null)
                {
                    hashCode = (hashCode * 59) + this.MaxConnectionRetries.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UseSystemWideWebhooks.GetHashCode();
                if (this.SystemWideWebhookTarget != null)
                {
                    hashCode = (hashCode * 59) + this.SystemWideWebhookTarget.GetHashCode();
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
