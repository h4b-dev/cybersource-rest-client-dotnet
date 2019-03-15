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
    /// TssV2TransactionsGet200ResponsePaymentInformationBank
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponsePaymentInformationBank :  IEquatable<TssV2TransactionsGet200ResponsePaymentInformationBank>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponsePaymentInformationBank" /> class.
        /// </summary>
        /// <param name="RoutingNumber">The description for this field is not available..</param>
        /// <param name="BranchCode">The description for this field is not available..</param>
        /// <param name="SwiftCode">The description for this field is not available..</param>
        /// <param name="BankCode">The description for this field is not available..</param>
        /// <param name="Iban">The description for this field is not available..</param>
        /// <param name="Account">Account.</param>
        /// <param name="Mandate">Mandate.</param>
        public TssV2TransactionsGet200ResponsePaymentInformationBank(string RoutingNumber = default(string), string BranchCode = default(string), string SwiftCode = default(string), string BankCode = default(string), string Iban = default(string), TssV2TransactionsGet200ResponsePaymentInformationBankAccount Account = default(TssV2TransactionsGet200ResponsePaymentInformationBankAccount), TssV2TransactionsGet200ResponsePaymentInformationBankMandate Mandate = default(TssV2TransactionsGet200ResponsePaymentInformationBankMandate))
        {
            this.RoutingNumber = RoutingNumber;
            this.BranchCode = BranchCode;
            this.SwiftCode = SwiftCode;
            this.BankCode = BankCode;
            this.Iban = Iban;
            this.Account = Account;
            this.Mandate = Mandate;
        }
        
        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="routingNumber", EmitDefaultValue=false)]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="branchCode", EmitDefaultValue=false)]
        public string BranchCode { get; set; }

        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="swiftCode", EmitDefaultValue=false)]
        public string SwiftCode { get; set; }

        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="bankCode", EmitDefaultValue=false)]
        public string BankCode { get; set; }

        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="iban", EmitDefaultValue=false)]
        public string Iban { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponsePaymentInformationBankAccount Account { get; set; }

        /// <summary>
        /// Gets or Sets Mandate
        /// </summary>
        [DataMember(Name="mandate", EmitDefaultValue=false)]
        public TssV2TransactionsGet200ResponsePaymentInformationBankMandate Mandate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponsePaymentInformationBank {\n");
            sb.Append("  RoutingNumber: ").Append(RoutingNumber).Append("\n");
            sb.Append("  BranchCode: ").Append(BranchCode).Append("\n");
            sb.Append("  SwiftCode: ").Append(SwiftCode).Append("\n");
            sb.Append("  BankCode: ").Append(BankCode).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Mandate: ").Append(Mandate).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponsePaymentInformationBank);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponsePaymentInformationBank instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponsePaymentInformationBank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponsePaymentInformationBank other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RoutingNumber == other.RoutingNumber ||
                    this.RoutingNumber != null &&
                    this.RoutingNumber.Equals(other.RoutingNumber)
                ) && 
                (
                    this.BranchCode == other.BranchCode ||
                    this.BranchCode != null &&
                    this.BranchCode.Equals(other.BranchCode)
                ) && 
                (
                    this.SwiftCode == other.SwiftCode ||
                    this.SwiftCode != null &&
                    this.SwiftCode.Equals(other.SwiftCode)
                ) && 
                (
                    this.BankCode == other.BankCode ||
                    this.BankCode != null &&
                    this.BankCode.Equals(other.BankCode)
                ) && 
                (
                    this.Iban == other.Iban ||
                    this.Iban != null &&
                    this.Iban.Equals(other.Iban)
                ) && 
                (
                    this.Account == other.Account ||
                    this.Account != null &&
                    this.Account.Equals(other.Account)
                ) && 
                (
                    this.Mandate == other.Mandate ||
                    this.Mandate != null &&
                    this.Mandate.Equals(other.Mandate)
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
                if (this.RoutingNumber != null)
                    hash = hash * 59 + this.RoutingNumber.GetHashCode();
                if (this.BranchCode != null)
                    hash = hash * 59 + this.BranchCode.GetHashCode();
                if (this.SwiftCode != null)
                    hash = hash * 59 + this.SwiftCode.GetHashCode();
                if (this.BankCode != null)
                    hash = hash * 59 + this.BankCode.GetHashCode();
                if (this.Iban != null)
                    hash = hash * 59 + this.Iban.GetHashCode();
                if (this.Account != null)
                    hash = hash * 59 + this.Account.GetHashCode();
                if (this.Mandate != null)
                    hash = hash * 59 + this.Mandate.GetHashCode();
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
