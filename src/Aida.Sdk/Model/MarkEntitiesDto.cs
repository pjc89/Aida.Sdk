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
    /// MarkEntitiesDto
    /// </summary>
    [DataContract(Name = "MarkEntitiesDto")]
    public partial class MarkEntitiesDto : IEquatable<MarkEntitiesDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkEntitiesDto" /> class.
        /// </summary>
        /// <param name="entities">entities.</param>
        public MarkEntitiesDto(List<string> entities = default(List<string>))
        {
            this.Entities = entities;
        }

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
            sb.Append("class MarkEntitiesDto {\n");
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
            return this.Equals(input as MarkEntitiesDto);
        }

        /// <summary>
        /// Returns true if MarkEntitiesDto instances are equal
        /// </summary>
        /// <param name="input">Instance of MarkEntitiesDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarkEntitiesDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
