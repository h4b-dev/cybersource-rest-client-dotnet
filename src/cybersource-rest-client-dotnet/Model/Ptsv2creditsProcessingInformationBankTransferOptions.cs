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
    /// Ptsv2creditsProcessingInformationBankTransferOptions
    /// </summary>
    [DataContract]
    public partial class Ptsv2creditsProcessingInformationBankTransferOptions :  IEquatable<Ptsv2creditsProcessingInformationBankTransferOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2creditsProcessingInformationBankTransferOptions" /> class.
        /// </summary>
        /// <param name="CustomerMemo">Payment related information.  This information is included on the customer’s statement. .</param>
        /// <param name="SecCode">Authorization method used for the transaction. See \&quot;SEC Codes,\&quot; page 89.  TeleCheck Accepts only the following values: - **PPD** - **TEL** - **WEB** .</param>
        /// <param name="TerminalCity">City in which the terminal is located. If more than four alphanumeric characters are submitted, the transaction will be declined.  You cannot include any special characters. .</param>
        /// <param name="TerminalState">State in which the terminal is located. If more than two alphanumeric characters are submitted, the transaction will be declined.  You cannot include any special characters. .</param>
        /// <param name="EffectiveDate">Effective date for the transaction. The effective date must be within 45 days of the current day. If you do not include this value, CyberSource sets the effective date to the next business day.  Format: &#x60;MMDDYYYY&#x60;  Supported only for the CyberSource ACH Service. .</param>
        /// <param name="PartialPaymentId">Identifier for a partial payment or partial credit.  The value for each debit request or credit request must be unique within the scope of the order. See \&quot;Multiple Partial Credits,\&quot; page 41. .</param>
        /// <param name="SettlementMethod">Method used for settlement.  Possible values: - **A**: Automated Clearing House (default for credits and for transactions using Canadian dollars) - **F**: Facsimile draft (U.S. dollars only) - **B**: Best possible (U.S. dollars only) (default if the field has not already been configured for your merchant ID)  See \&quot;Settlement Delivery Methods,\&quot; page 44. .</param>
        public Ptsv2creditsProcessingInformationBankTransferOptions(string CustomerMemo = default(string), string SecCode = default(string), string TerminalCity = default(string), string TerminalState = default(string), string EffectiveDate = default(string), string PartialPaymentId = default(string), string SettlementMethod = default(string))
        {
            this.CustomerMemo = CustomerMemo;
            this.SecCode = SecCode;
            this.TerminalCity = TerminalCity;
            this.TerminalState = TerminalState;
            this.EffectiveDate = EffectiveDate;
            this.PartialPaymentId = PartialPaymentId;
            this.SettlementMethod = SettlementMethod;
        }
        
        /// <summary>
        /// Payment related information.  This information is included on the customer’s statement. 
        /// </summary>
        /// <value>Payment related information.  This information is included on the customer’s statement. </value>
        [DataMember(Name="customerMemo", EmitDefaultValue=false)]
        public string CustomerMemo { get; set; }

        /// <summary>
        /// Authorization method used for the transaction. See \&quot;SEC Codes,\&quot; page 89.  TeleCheck Accepts only the following values: - **PPD** - **TEL** - **WEB** 
        /// </summary>
        /// <value>Authorization method used for the transaction. See \&quot;SEC Codes,\&quot; page 89.  TeleCheck Accepts only the following values: - **PPD** - **TEL** - **WEB** </value>
        [DataMember(Name="secCode", EmitDefaultValue=false)]
        public string SecCode { get; set; }

        /// <summary>
        /// City in which the terminal is located. If more than four alphanumeric characters are submitted, the transaction will be declined.  You cannot include any special characters. 
        /// </summary>
        /// <value>City in which the terminal is located. If more than four alphanumeric characters are submitted, the transaction will be declined.  You cannot include any special characters. </value>
        [DataMember(Name="terminalCity", EmitDefaultValue=false)]
        public string TerminalCity { get; set; }

        /// <summary>
        /// State in which the terminal is located. If more than two alphanumeric characters are submitted, the transaction will be declined.  You cannot include any special characters. 
        /// </summary>
        /// <value>State in which the terminal is located. If more than two alphanumeric characters are submitted, the transaction will be declined.  You cannot include any special characters. </value>
        [DataMember(Name="terminalState", EmitDefaultValue=false)]
        public string TerminalState { get; set; }

        /// <summary>
        /// Effective date for the transaction. The effective date must be within 45 days of the current day. If you do not include this value, CyberSource sets the effective date to the next business day.  Format: &#x60;MMDDYYYY&#x60;  Supported only for the CyberSource ACH Service. 
        /// </summary>
        /// <value>Effective date for the transaction. The effective date must be within 45 days of the current day. If you do not include this value, CyberSource sets the effective date to the next business day.  Format: &#x60;MMDDYYYY&#x60;  Supported only for the CyberSource ACH Service. </value>
        [DataMember(Name="effectiveDate", EmitDefaultValue=false)]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// Identifier for a partial payment or partial credit.  The value for each debit request or credit request must be unique within the scope of the order. See \&quot;Multiple Partial Credits,\&quot; page 41. 
        /// </summary>
        /// <value>Identifier for a partial payment or partial credit.  The value for each debit request or credit request must be unique within the scope of the order. See \&quot;Multiple Partial Credits,\&quot; page 41. </value>
        [DataMember(Name="partialPaymentId", EmitDefaultValue=false)]
        public string PartialPaymentId { get; set; }

        /// <summary>
        /// Method used for settlement.  Possible values: - **A**: Automated Clearing House (default for credits and for transactions using Canadian dollars) - **F**: Facsimile draft (U.S. dollars only) - **B**: Best possible (U.S. dollars only) (default if the field has not already been configured for your merchant ID)  See \&quot;Settlement Delivery Methods,\&quot; page 44. 
        /// </summary>
        /// <value>Method used for settlement.  Possible values: - **A**: Automated Clearing House (default for credits and for transactions using Canadian dollars) - **F**: Facsimile draft (U.S. dollars only) - **B**: Best possible (U.S. dollars only) (default if the field has not already been configured for your merchant ID)  See \&quot;Settlement Delivery Methods,\&quot; page 44. </value>
        [DataMember(Name="settlementMethod", EmitDefaultValue=false)]
        public string SettlementMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2creditsProcessingInformationBankTransferOptions {\n");
            sb.Append("  CustomerMemo: ").Append(CustomerMemo).Append("\n");
            sb.Append("  SecCode: ").Append(SecCode).Append("\n");
            sb.Append("  TerminalCity: ").Append(TerminalCity).Append("\n");
            sb.Append("  TerminalState: ").Append(TerminalState).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  PartialPaymentId: ").Append(PartialPaymentId).Append("\n");
            sb.Append("  SettlementMethod: ").Append(SettlementMethod).Append("\n");
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
            return this.Equals(obj as Ptsv2creditsProcessingInformationBankTransferOptions);
        }

        /// <summary>
        /// Returns true if Ptsv2creditsProcessingInformationBankTransferOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2creditsProcessingInformationBankTransferOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2creditsProcessingInformationBankTransferOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CustomerMemo == other.CustomerMemo ||
                    this.CustomerMemo != null &&
                    this.CustomerMemo.Equals(other.CustomerMemo)
                ) && 
                (
                    this.SecCode == other.SecCode ||
                    this.SecCode != null &&
                    this.SecCode.Equals(other.SecCode)
                ) && 
                (
                    this.TerminalCity == other.TerminalCity ||
                    this.TerminalCity != null &&
                    this.TerminalCity.Equals(other.TerminalCity)
                ) && 
                (
                    this.TerminalState == other.TerminalState ||
                    this.TerminalState != null &&
                    this.TerminalState.Equals(other.TerminalState)
                ) && 
                (
                    this.EffectiveDate == other.EffectiveDate ||
                    this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(other.EffectiveDate)
                ) && 
                (
                    this.PartialPaymentId == other.PartialPaymentId ||
                    this.PartialPaymentId != null &&
                    this.PartialPaymentId.Equals(other.PartialPaymentId)
                ) && 
                (
                    this.SettlementMethod == other.SettlementMethod ||
                    this.SettlementMethod != null &&
                    this.SettlementMethod.Equals(other.SettlementMethod)
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
                if (this.CustomerMemo != null)
                    hash = hash * 59 + this.CustomerMemo.GetHashCode();
                if (this.SecCode != null)
                    hash = hash * 59 + this.SecCode.GetHashCode();
                if (this.TerminalCity != null)
                    hash = hash * 59 + this.TerminalCity.GetHashCode();
                if (this.TerminalState != null)
                    hash = hash * 59 + this.TerminalState.GetHashCode();
                if (this.EffectiveDate != null)
                    hash = hash * 59 + this.EffectiveDate.GetHashCode();
                if (this.PartialPaymentId != null)
                    hash = hash * 59 + this.PartialPaymentId.GetHashCode();
                if (this.SettlementMethod != null)
                    hash = hash * 59 + this.SettlementMethod.GetHashCode();
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
            // CustomerMemo (string) maxLength
            if(this.CustomerMemo != null && this.CustomerMemo.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerMemo, length must be less than 80.", new [] { "CustomerMemo" });
            }

            // SecCode (string) maxLength
            if(this.SecCode != null && this.SecCode.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecCode, length must be less than 3.", new [] { "SecCode" });
            }

            // TerminalCity (string) maxLength
            if(this.TerminalCity != null && this.TerminalCity.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TerminalCity, length must be less than 4.", new [] { "TerminalCity" });
            }

            // TerminalState (string) maxLength
            if(this.TerminalState != null && this.TerminalState.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TerminalState, length must be less than 2.", new [] { "TerminalState" });
            }

            // EffectiveDate (string) maxLength
            if(this.EffectiveDate != null && this.EffectiveDate.Length > 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EffectiveDate, length must be less than 8.", new [] { "EffectiveDate" });
            }

            // PartialPaymentId (string) maxLength
            if(this.PartialPaymentId != null && this.PartialPaymentId.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PartialPaymentId, length must be less than 25.", new [] { "PartialPaymentId" });
            }

            // SettlementMethod (string) maxLength
            if(this.SettlementMethod != null && this.SettlementMethod.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SettlementMethod, length must be less than 1.", new [] { "SettlementMethod" });
            }

            yield break;
        }
    }

}
