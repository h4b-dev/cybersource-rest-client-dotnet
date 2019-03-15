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
    /// TssV2TransactionsGet200ResponseBuyerInformation
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponseBuyerInformation :  IEquatable<TssV2TransactionsGet200ResponseBuyerInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponseBuyerInformation" /> class.
        /// </summary>
        /// <param name="MerchantCustomerId">Your identifier for the customer.  For processor-specific information, see the customer_account_id field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="HashedPassword">The description for this field is not available. .</param>
        public TssV2TransactionsGet200ResponseBuyerInformation(string MerchantCustomerId = default(string), string HashedPassword = default(string))
        {
            this.MerchantCustomerId = MerchantCustomerId;
            this.HashedPassword = HashedPassword;
        }
        
        /// <summary>
        /// Your identifier for the customer.  For processor-specific information, see the customer_account_id field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Your identifier for the customer.  For processor-specific information, see the customer_account_id field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="merchantCustomerId", EmitDefaultValue=false)]
        public string MerchantCustomerId { get; set; }

        /// <summary>
        /// The description for this field is not available. 
        /// </summary>
        /// <value>The description for this field is not available. </value>
        [DataMember(Name="hashedPassword", EmitDefaultValue=false)]
        public string HashedPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponseBuyerInformation {\n");
            sb.Append("  MerchantCustomerId: ").Append(MerchantCustomerId).Append("\n");
            sb.Append("  HashedPassword: ").Append(HashedPassword).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponseBuyerInformation);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponseBuyerInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponseBuyerInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponseBuyerInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MerchantCustomerId == other.MerchantCustomerId ||
                    this.MerchantCustomerId != null &&
                    this.MerchantCustomerId.Equals(other.MerchantCustomerId)
                ) && 
                (
                    this.HashedPassword == other.HashedPassword ||
                    this.HashedPassword != null &&
                    this.HashedPassword.Equals(other.HashedPassword)
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
                if (this.MerchantCustomerId != null)
                    hash = hash * 59 + this.MerchantCustomerId.GetHashCode();
                if (this.HashedPassword != null)
                    hash = hash * 59 + this.HashedPassword.GetHashCode();
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
            // MerchantCustomerId (string) maxLength
            if(this.MerchantCustomerId != null && this.MerchantCustomerId.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantCustomerId, length must be less than 100.", new [] { "MerchantCustomerId" });
            }

            // HashedPassword (string) maxLength
            if(this.HashedPassword != null && this.HashedPassword.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HashedPassword, length must be less than 100.", new [] { "HashedPassword" });
            }

            yield break;
        }
    }

}
