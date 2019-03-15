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
    /// TmsV1InstrumentidentifiersPaymentinstrumentsGet200ResponseLinksFirst
    /// </summary>
    [DataContract]
    public partial class TmsV1InstrumentidentifiersPaymentinstrumentsGet200ResponseLinksFirst :  IEquatable<TmsV1InstrumentidentifiersPaymentinstrumentsGet200ResponseLinksFirst>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TmsV1InstrumentidentifiersPaymentinstrumentsGet200ResponseLinksFirst" /> class.
        /// </summary>
        /// <param name="Href">A link to the collection starting at offset zero for the supplied limit..</param>
        public TmsV1InstrumentidentifiersPaymentinstrumentsGet200ResponseLinksFirst(string Href = default(string))
        {
            this.Href = Href;
        }
        
        /// <summary>
        /// A link to the collection starting at offset zero for the supplied limit.
        /// </summary>
        /// <value>A link to the collection starting at offset zero for the supplied limit.</value>
        [DataMember(Name="href", EmitDefaultValue=false)]
        public string Href { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TmsV1InstrumentidentifiersPaymentinstrumentsGet200ResponseLinksFirst {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
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
            return this.Equals(obj as TmsV1InstrumentidentifiersPaymentinstrumentsGet200ResponseLinksFirst);
        }

        /// <summary>
        /// Returns true if TmsV1InstrumentidentifiersPaymentinstrumentsGet200ResponseLinksFirst instances are equal
        /// </summary>
        /// <param name="other">Instance of TmsV1InstrumentidentifiersPaymentinstrumentsGet200ResponseLinksFirst to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TmsV1InstrumentidentifiersPaymentinstrumentsGet200ResponseLinksFirst other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Href == other.Href ||
                    this.Href != null &&
                    this.Href.Equals(other.Href)
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
                if (this.Href != null)
                    hash = hash * 59 + this.Href.GetHashCode();
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
