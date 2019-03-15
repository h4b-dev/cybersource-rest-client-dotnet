/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CyberSource.Model
{
    /// <summary>
    /// V1FileDetailsGet200Response
    /// </summary>
    [DataContract]
    public partial class V1FileDetailsGet200Response :  IEquatable<V1FileDetailsGet200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1FileDetailsGet200Response" /> class.
        /// </summary>
        /// <param name="FileDetails">FileDetails.</param>
        /// <param name="Links">Links.</param>
        public V1FileDetailsGet200Response(List<V1FileDetailsGet200ResponseFileDetails> FileDetails = default(List<V1FileDetailsGet200ResponseFileDetails>), V1FileDetailsGet200ResponseLinks Links = default(V1FileDetailsGet200ResponseLinks))
        {
            this.FileDetails = FileDetails;
            this.Links = Links;
        }
        
        /// <summary>
        /// Gets or Sets FileDetails
        /// </summary>
        [DataMember(Name="fileDetails", EmitDefaultValue=false)]
        public List<V1FileDetailsGet200ResponseFileDetails> FileDetails { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public V1FileDetailsGet200ResponseLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1FileDetailsGet200Response {\n");
            sb.Append("  FileDetails: ").Append(FileDetails).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as V1FileDetailsGet200Response);
        }

        /// <summary>
        /// Returns true if V1FileDetailsGet200Response instances are equal
        /// </summary>
        /// <param name="other">Instance of V1FileDetailsGet200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1FileDetailsGet200Response other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FileDetails == other.FileDetails ||
                    this.FileDetails != null &&
                    this.FileDetails.SequenceEqual(other.FileDetails)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.FileDetails != null)
                    hash = hash * 59 + this.FileDetails.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                return hash;
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
