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
    /// TssV2TransactionsGet200ResponseMerchantInformation
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponseMerchantInformation :  IEquatable<TssV2TransactionsGet200ResponseMerchantInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponseMerchantInformation" /> class.
        /// </summary>
        /// <param name="MerchantDescriptor">MerchantDescriptor.</param>
        public TssV2TransactionsGet200ResponseMerchantInformation(TssV2TransactionsGet200ResponseMerchantInformationMerchantDescriptor MerchantDescriptor = default(TssV2TransactionsGet200ResponseMerchantInformationMerchantDescriptor))
        {
            this.MerchantDescriptor = MerchantDescriptor;
        }
        
        /// <summary>
        /// Gets or Sets MerchantDescriptor
        /// </summary>
        [DataMember(Name="merchantDescriptor", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponseMerchantInformationMerchantDescriptor MerchantDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponseMerchantInformation {\n");
            sb.Append("  MerchantDescriptor: ").Append(MerchantDescriptor).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponseMerchantInformation);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponseMerchantInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponseMerchantInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponseMerchantInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MerchantDescriptor == other.MerchantDescriptor ||
                    this.MerchantDescriptor != null &&
                    this.MerchantDescriptor.Equals(other.MerchantDescriptor)
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
                if (this.MerchantDescriptor != null)
                    hash = hash * 59 + this.MerchantDescriptor.GetHashCode();
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
