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
    /// TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformation
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformation :  IEquatable<TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformation" /> class.
        /// </summary>
        /// <param name="TerminalId">Identifier for the terminal at your retail location. You can define this value yourself, but consult the processor for requirements.  For Payouts: This field is applicable for CtV. .</param>
        /// <param name="TerminalSerialNumber">The description for this field is not available..</param>
        /// <param name="DeviceId">The description for this field is not available..</param>
        /// <param name="Partner">Partner.</param>
        public TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformation(string TerminalId = default(string), string TerminalSerialNumber = default(string), string DeviceId = default(string), TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformationPartner Partner = default(TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformationPartner))
        {
            this.TerminalId = TerminalId;
            this.TerminalSerialNumber = TerminalSerialNumber;
            this.DeviceId = DeviceId;
            this.Partner = Partner;
        }
        
        /// <summary>
        /// Identifier for the terminal at your retail location. You can define this value yourself, but consult the processor for requirements.  For Payouts: This field is applicable for CtV. 
        /// </summary>
        /// <value>Identifier for the terminal at your retail location. You can define this value yourself, but consult the processor for requirements.  For Payouts: This field is applicable for CtV. </value>
        [DataMember(Name="terminalId", EmitDefaultValue=false)]
        public string TerminalId { get; set; }

        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="terminalSerialNumber", EmitDefaultValue=false)]
        public string TerminalSerialNumber { get; set; }

        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="deviceId", EmitDefaultValue=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or Sets Partner
        /// </summary>
        [DataMember(Name="partner", EmitDefaultValue=false)]
        public TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformationPartner Partner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformation {\n");
            sb.Append("  TerminalId: ").Append(TerminalId).Append("\n");
            sb.Append("  TerminalSerialNumber: ").Append(TerminalSerialNumber).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  Partner: ").Append(Partner).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformation);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsPost201ResponseEmbeddedPointOfSaleInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TerminalId == other.TerminalId ||
                    this.TerminalId != null &&
                    this.TerminalId.Equals(other.TerminalId)
                ) && 
                (
                    this.TerminalSerialNumber == other.TerminalSerialNumber ||
                    this.TerminalSerialNumber != null &&
                    this.TerminalSerialNumber.Equals(other.TerminalSerialNumber)
                ) && 
                (
                    this.DeviceId == other.DeviceId ||
                    this.DeviceId != null &&
                    this.DeviceId.Equals(other.DeviceId)
                ) && 
                (
                    this.Partner == other.Partner ||
                    this.Partner != null &&
                    this.Partner.Equals(other.Partner)
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
                if (this.TerminalId != null)
                    hash = hash * 59 + this.TerminalId.GetHashCode();
                if (this.TerminalSerialNumber != null)
                    hash = hash * 59 + this.TerminalSerialNumber.GetHashCode();
                if (this.DeviceId != null)
                    hash = hash * 59 + this.DeviceId.GetHashCode();
                if (this.Partner != null)
                    hash = hash * 59 + this.Partner.GetHashCode();
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
            // TerminalId (string) maxLength
            if(this.TerminalId != null && this.TerminalId.Length > 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TerminalId, length must be less than 8.", new [] { "TerminalId" });
            }

            yield break;
        }
    }

}