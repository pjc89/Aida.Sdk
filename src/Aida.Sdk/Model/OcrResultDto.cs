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
    /// OcrResultDto
    /// </summary>
    [DataContract(Name = "OcrResultDto")]
    public partial class OcrResultDto : IEquatable<OcrResultDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OcrResultDto" /> class.
        /// </summary>
        /// <param name="text">text.</param>
        /// <param name="meanConfidence">meanConfidence.</param>
        /// <param name="durationMs">durationMs.</param>
        public OcrResultDto(string text = default(string), float meanConfidence = default(float), long durationMs = default(long))
        {
            this.Text = text;
            this.MeanConfidence = meanConfidence;
            this.DurationMs = durationMs;
        }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets MeanConfidence
        /// </summary>
        [DataMember(Name = "meanConfidence", EmitDefaultValue = false)]
        public float MeanConfidence { get; set; }

        /// <summary>
        /// Gets or Sets DurationMs
        /// </summary>
        [DataMember(Name = "durationMs", EmitDefaultValue = false)]
        public long DurationMs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OcrResultDto {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  MeanConfidence: ").Append(MeanConfidence).Append("\n");
            sb.Append("  DurationMs: ").Append(DurationMs).Append("\n");
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
            return this.Equals(input as OcrResultDto);
        }

        /// <summary>
        /// Returns true if OcrResultDto instances are equal
        /// </summary>
        /// <param name="input">Instance of OcrResultDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OcrResultDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.MeanConfidence == input.MeanConfidence ||
                    this.MeanConfidence.Equals(input.MeanConfidence)
                ) && 
                (
                    this.DurationMs == input.DurationMs ||
                    this.DurationMs.Equals(input.DurationMs)
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
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MeanConfidence.GetHashCode();
                hashCode = (hashCode * 59) + this.DurationMs.GetHashCode();
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
