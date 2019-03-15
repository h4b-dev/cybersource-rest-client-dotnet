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
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CyberSource.Model
{
    /// <summary>
    /// TmsV1InstrumentidentifiersDelete409Response
    /// </summary>
    [DataContract]
    public partial class TmsV1InstrumentidentifiersDelete409Response :  IEquatable<TmsV1InstrumentidentifiersDelete409Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TmsV1InstrumentidentifiersDelete409Response" /> class.
        /// </summary>
        /// <param name="Links">Links.</param>
        public TmsV1InstrumentidentifiersDelete409Response(TmsV1InstrumentidentifiersDelete409ResponseLinks Links = default(TmsV1InstrumentidentifiersDelete409ResponseLinks))
        {
            this.Links = Links;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public TmsV1InstrumentidentifiersDelete409ResponseLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TmsV1InstrumentidentifiersDelete409Response {\n");
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
            return this.Equals(obj as TmsV1InstrumentidentifiersDelete409Response);
        }

        /// <summary>
        /// Returns true if TmsV1InstrumentidentifiersDelete409Response instances are equal
        /// </summary>
        /// <param name="other">Instance of TmsV1InstrumentidentifiersDelete409Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TmsV1InstrumentidentifiersDelete409Response other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
