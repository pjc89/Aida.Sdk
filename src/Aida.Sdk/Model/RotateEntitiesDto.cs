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
    /// RotateEntitiesDto
    /// </summary>
    [DataContract(Name = "RotateEntitiesDto")]
    public partial class RotateEntitiesDto : IEquatable<RotateEntitiesDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RotateEntitiesDto" /> class.
        /// </summary>
        /// <param name="deg">deg.</param>
        /// <param name="entities">entities.</param>
        public RotateEntitiesDto(double deg = default(double), List<string> entities = default(List<string>))
        {
            this.Deg = deg;
            this.Entities = entities;
        }

        /// <summary>
        /// Gets or Sets Deg
        /// </summary>
        [DataMember(Name = "deg", EmitDefaultValue = false)]
        public double Deg { get; set; }

        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name = "entities", EmitDefaultValue = true)]
        public List<string> Entities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RotateEntitiesDto {\n");
            sb.Append("  Deg: ").Append(Deg).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
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
            return this.Equals(input as RotateEntitiesDto);
        }

        /// <summary>
        /// Returns true if RotateEntitiesDto instances are equal
        /// </summary>
        /// <param name="input">Instance of RotateEntitiesDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RotateEntitiesDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Deg == input.Deg ||
                    this.Deg.Equals(input.Deg)
                ) && 
                (
                    this.Entities == input.Entities ||
                    this.Entities != null &&
                    input.Entities != null &&
                    this.Entities.SequenceEqual(input.Entities)
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
                hashCode = (hashCode * 59) + this.Deg.GetHashCode();
                if (this.Entities != null)
                {
                    hashCode = (hashCode * 59) + this.Entities.GetHashCode();
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
