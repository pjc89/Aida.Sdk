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
    /// Translation
    /// </summary>
    [DataContract(Name = "Translation")]
    public partial class Translation : IEquatable<Translation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Translation" /> class.
        /// </summary>
        /// <param name="selection">selection.</param>
        /// <param name="offset">offset.</param>
        public Translation(string selection = default(string), Vector3d offset = default(Vector3d))
        {
            this.Selection = selection;
            this.Offset = offset;
        }

        /// <summary>
        /// Gets or Sets Selection
        /// </summary>
        [DataMember(Name = "selection", EmitDefaultValue = true)]
        public string Selection { get; set; }

        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [DataMember(Name = "offset", EmitDefaultValue = false)]
        public Vector3d Offset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Translation {\n");
            sb.Append("  Selection: ").Append(Selection).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
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
            return this.Equals(input as Translation);
        }

        /// <summary>
        /// Returns true if Translation instances are equal
        /// </summary>
        /// <param name="input">Instance of Translation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Translation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Selection == input.Selection ||
                    (this.Selection != null &&
                    this.Selection.Equals(input.Selection))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
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
                if (this.Selection != null)
                {
                    hashCode = (hashCode * 59) + this.Selection.GetHashCode();
                }
                if (this.Offset != null)
                {
                    hashCode = (hashCode * 59) + this.Offset.GetHashCode();
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