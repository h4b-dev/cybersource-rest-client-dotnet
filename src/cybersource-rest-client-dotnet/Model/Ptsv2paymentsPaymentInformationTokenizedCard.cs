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
    /// Ptsv2paymentsPaymentInformationTokenizedCard
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsPaymentInformationTokenizedCard :  IEquatable<Ptsv2paymentsPaymentInformationTokenizedCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsPaymentInformationTokenizedCard" /> class.
        /// </summary>
        /// <param name="Number">Customer’s payment network token value. .</param>
        /// <param name="ExpirationMonth">Two-digit month in which the payment network token expires. &#x60;Format: MM&#x60;. Possible values: 01 through 12.  **Barclays and Streamline**\\ For Maestro (UK Domestic) and Maestro (International) cards on Barclays and Streamline, this must be a valid value (01 through 12) but is not required to be a valid expiration date. In other words, an expiration date that is in the past does not cause CyberSource to reject your request. However, an invalid expiration date might cause the issuer to reject your request.  **Encoded Account Numbers**\\ For encoded account numbers (_type_&#x3D;039), if there is no expiration date on the card, use 12.  For processor-specific information, see the customer_cc_expmo field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="ExpirationYear">Four-digit year in which the payment network token expires. &#x60;Format: YYYY&#x60;.  **Barclays and Streamline**\\ For Maestro (UK Domestic) and Maestro (International) cards on Barclays and Streamline, this must be a valid value (1900 through 3000) but is not required to be a valid expiration date. In other words, an expiration date that is in the past does not cause CyberSource to reject your request. However, an invalid expiration date might cause the issuer to reject your request.  **FDC Nashville Global and FDMS South**\\ You can send in 2 digits or 4 digits. If you send in 2 digits, they must be the last 2 digits of the year.  **Encoded Account Numbers**\\ For encoded account numbers (card_type&#x3D;039), if there is no expiration date on the card, use 2021.  For processor-specific information, see the customer_cc_expyr field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="Type">Type of card to authorize. - 001 Visa - 002 Mastercard - 003 Amex - 004 Discover .</param>
        /// <param name="Cryptogram">This field is used internally..</param>
        /// <param name="RequestorId">Value that identifies your business and indicates that the cardholder’s account number is tokenized. This value is assigned by the token service provider and is unique within the token service provider’s database.  &#x60;Note&#x60; This field is supported only for **CyberSource through VisaNet** and **FDC Nashville Global**. .</param>
        /// <param name="TransactionType">Type of transaction that provided the token data. This value does not specify the token service provider; it specifies the entity that provided you with information about the token.  Set the value for this field to 1. An application on the customer’s mobile device provided the token data. .</param>
        /// <param name="AssuranceLevel">Confidence level of the tokenization. This value is assigned by the token service provider.  &#x60;Note&#x60; This field is supported only for **CyberSource through VisaNet** and **FDC Nashville Global**. .</param>
        /// <param name="StorageMethod">Type of technology used in the device to store token data. Possible values:   - 001: Secure Element (SE)  Smart card or memory with restricted access and encryption to prevent data tampering. For storing payment credentials, a SE is tested against a set of requirements defined by the payment networks.  &#x60;Note&#x60; This field is supported only for **FDC Compass**.  - 002: Host Card Emulation (HCE)  Emulation of a smart card by using software to create a virtual and exact representation of the card. Sensitive data is stored in a database that is hosted in the cloud. For storing payment credentials, a database must meet very stringent security requirements that exceed PCI DSS.  &#x60;Note&#x60; This field is supported only for **FDC Compass**. .</param>
        /// <param name="SecurityCode">Card Verification Number.  **Ingenico ePayments** Do not include this field when _commerceIndicator&#x3D;recurring_. **Note** Ingenico ePayments was previously called Global Collect. CVN. .</param>
        public Ptsv2paymentsPaymentInformationTokenizedCard(string Number = default(string), string ExpirationMonth = default(string), string ExpirationYear = default(string), string Type = default(string), string Cryptogram = default(string), string RequestorId = default(string), string TransactionType = default(string), string AssuranceLevel = default(string), string StorageMethod = default(string), string SecurityCode = default(string))
        {
            this.Number = Number;
            this.ExpirationMonth = ExpirationMonth;
            this.ExpirationYear = ExpirationYear;
            this.Type = Type;
            this.Cryptogram = Cryptogram;
            this.RequestorId = RequestorId;
            this.TransactionType = TransactionType;
            this.AssuranceLevel = AssuranceLevel;
            this.StorageMethod = StorageMethod;
            this.SecurityCode = SecurityCode;
        }
        
        /// <summary>
        /// Customer’s payment network token value. 
        /// </summary>
        /// <value>Customer’s payment network token value. </value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Two-digit month in which the payment network token expires. &#x60;Format: MM&#x60;. Possible values: 01 through 12.  **Barclays and Streamline**\\ For Maestro (UK Domestic) and Maestro (International) cards on Barclays and Streamline, this must be a valid value (01 through 12) but is not required to be a valid expiration date. In other words, an expiration date that is in the past does not cause CyberSource to reject your request. However, an invalid expiration date might cause the issuer to reject your request.  **Encoded Account Numbers**\\ For encoded account numbers (_type_&#x3D;039), if there is no expiration date on the card, use 12.  For processor-specific information, see the customer_cc_expmo field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Two-digit month in which the payment network token expires. &#x60;Format: MM&#x60;. Possible values: 01 through 12.  **Barclays and Streamline**\\ For Maestro (UK Domestic) and Maestro (International) cards on Barclays and Streamline, this must be a valid value (01 through 12) but is not required to be a valid expiration date. In other words, an expiration date that is in the past does not cause CyberSource to reject your request. However, an invalid expiration date might cause the issuer to reject your request.  **Encoded Account Numbers**\\ For encoded account numbers (_type_&#x3D;039), if there is no expiration date on the card, use 12.  For processor-specific information, see the customer_cc_expmo field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="expirationMonth", EmitDefaultValue=false)]
        public string ExpirationMonth { get; set; }

        /// <summary>
        /// Four-digit year in which the payment network token expires. &#x60;Format: YYYY&#x60;.  **Barclays and Streamline**\\ For Maestro (UK Domestic) and Maestro (International) cards on Barclays and Streamline, this must be a valid value (1900 through 3000) but is not required to be a valid expiration date. In other words, an expiration date that is in the past does not cause CyberSource to reject your request. However, an invalid expiration date might cause the issuer to reject your request.  **FDC Nashville Global and FDMS South**\\ You can send in 2 digits or 4 digits. If you send in 2 digits, they must be the last 2 digits of the year.  **Encoded Account Numbers**\\ For encoded account numbers (card_type&#x3D;039), if there is no expiration date on the card, use 2021.  For processor-specific information, see the customer_cc_expyr field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Four-digit year in which the payment network token expires. &#x60;Format: YYYY&#x60;.  **Barclays and Streamline**\\ For Maestro (UK Domestic) and Maestro (International) cards on Barclays and Streamline, this must be a valid value (1900 through 3000) but is not required to be a valid expiration date. In other words, an expiration date that is in the past does not cause CyberSource to reject your request. However, an invalid expiration date might cause the issuer to reject your request.  **FDC Nashville Global and FDMS South**\\ You can send in 2 digits or 4 digits. If you send in 2 digits, they must be the last 2 digits of the year.  **Encoded Account Numbers**\\ For encoded account numbers (card_type&#x3D;039), if there is no expiration date on the card, use 2021.  For processor-specific information, see the customer_cc_expyr field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="expirationYear", EmitDefaultValue=false)]
        public string ExpirationYear { get; set; }

        /// <summary>
        /// Type of card to authorize. - 001 Visa - 002 Mastercard - 003 Amex - 004 Discover 
        /// </summary>
        /// <value>Type of card to authorize. - 001 Visa - 002 Mastercard - 003 Amex - 004 Discover </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// This field is used internally.
        /// </summary>
        /// <value>This field is used internally.</value>
        [DataMember(Name="cryptogram", EmitDefaultValue=false)]
        public string Cryptogram { get; set; }

        /// <summary>
        /// Value that identifies your business and indicates that the cardholder’s account number is tokenized. This value is assigned by the token service provider and is unique within the token service provider’s database.  &#x60;Note&#x60; This field is supported only for **CyberSource through VisaNet** and **FDC Nashville Global**. 
        /// </summary>
        /// <value>Value that identifies your business and indicates that the cardholder’s account number is tokenized. This value is assigned by the token service provider and is unique within the token service provider’s database.  &#x60;Note&#x60; This field is supported only for **CyberSource through VisaNet** and **FDC Nashville Global**. </value>
        [DataMember(Name="requestorId", EmitDefaultValue=false)]
        public string RequestorId { get; set; }

        /// <summary>
        /// Type of transaction that provided the token data. This value does not specify the token service provider; it specifies the entity that provided you with information about the token.  Set the value for this field to 1. An application on the customer’s mobile device provided the token data. 
        /// </summary>
        /// <value>Type of transaction that provided the token data. This value does not specify the token service provider; it specifies the entity that provided you with information about the token.  Set the value for this field to 1. An application on the customer’s mobile device provided the token data. </value>
        [DataMember(Name="transactionType", EmitDefaultValue=false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// Confidence level of the tokenization. This value is assigned by the token service provider.  &#x60;Note&#x60; This field is supported only for **CyberSource through VisaNet** and **FDC Nashville Global**. 
        /// </summary>
        /// <value>Confidence level of the tokenization. This value is assigned by the token service provider.  &#x60;Note&#x60; This field is supported only for **CyberSource through VisaNet** and **FDC Nashville Global**. </value>
        [DataMember(Name="assuranceLevel", EmitDefaultValue=false)]
        public string AssuranceLevel { get; set; }

        /// <summary>
        /// Type of technology used in the device to store token data. Possible values:   - 001: Secure Element (SE)  Smart card or memory with restricted access and encryption to prevent data tampering. For storing payment credentials, a SE is tested against a set of requirements defined by the payment networks.  &#x60;Note&#x60; This field is supported only for **FDC Compass**.  - 002: Host Card Emulation (HCE)  Emulation of a smart card by using software to create a virtual and exact representation of the card. Sensitive data is stored in a database that is hosted in the cloud. For storing payment credentials, a database must meet very stringent security requirements that exceed PCI DSS.  &#x60;Note&#x60; This field is supported only for **FDC Compass**. 
        /// </summary>
        /// <value>Type of technology used in the device to store token data. Possible values:   - 001: Secure Element (SE)  Smart card or memory with restricted access and encryption to prevent data tampering. For storing payment credentials, a SE is tested against a set of requirements defined by the payment networks.  &#x60;Note&#x60; This field is supported only for **FDC Compass**.  - 002: Host Card Emulation (HCE)  Emulation of a smart card by using software to create a virtual and exact representation of the card. Sensitive data is stored in a database that is hosted in the cloud. For storing payment credentials, a database must meet very stringent security requirements that exceed PCI DSS.  &#x60;Note&#x60; This field is supported only for **FDC Compass**. </value>
        [DataMember(Name="storageMethod", EmitDefaultValue=false)]
        public string StorageMethod { get; set; }

        /// <summary>
        /// Card Verification Number.  **Ingenico ePayments** Do not include this field when _commerceIndicator&#x3D;recurring_. **Note** Ingenico ePayments was previously called Global Collect. CVN. 
        /// </summary>
        /// <value>Card Verification Number.  **Ingenico ePayments** Do not include this field when _commerceIndicator&#x3D;recurring_. **Note** Ingenico ePayments was previously called Global Collect. CVN. </value>
        [DataMember(Name="securityCode", EmitDefaultValue=false)]
        public string SecurityCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsPaymentInformationTokenizedCard {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  ExpirationMonth: ").Append(ExpirationMonth).Append("\n");
            sb.Append("  ExpirationYear: ").Append(ExpirationYear).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Cryptogram: ").Append(Cryptogram).Append("\n");
            sb.Append("  RequestorId: ").Append(RequestorId).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  AssuranceLevel: ").Append(AssuranceLevel).Append("\n");
            sb.Append("  StorageMethod: ").Append(StorageMethod).Append("\n");
            sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsPaymentInformationTokenizedCard);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsPaymentInformationTokenizedCard instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsPaymentInformationTokenizedCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsPaymentInformationTokenizedCard other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.ExpirationMonth == other.ExpirationMonth ||
                    this.ExpirationMonth != null &&
                    this.ExpirationMonth.Equals(other.ExpirationMonth)
                ) && 
                (
                    this.ExpirationYear == other.ExpirationYear ||
                    this.ExpirationYear != null &&
                    this.ExpirationYear.Equals(other.ExpirationYear)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Cryptogram == other.Cryptogram ||
                    this.Cryptogram != null &&
                    this.Cryptogram.Equals(other.Cryptogram)
                ) && 
                (
                    this.RequestorId == other.RequestorId ||
                    this.RequestorId != null &&
                    this.RequestorId.Equals(other.RequestorId)
                ) && 
                (
                    this.TransactionType == other.TransactionType ||
                    this.TransactionType != null &&
                    this.TransactionType.Equals(other.TransactionType)
                ) && 
                (
                    this.AssuranceLevel == other.AssuranceLevel ||
                    this.AssuranceLevel != null &&
                    this.AssuranceLevel.Equals(other.AssuranceLevel)
                ) && 
                (
                    this.StorageMethod == other.StorageMethod ||
                    this.StorageMethod != null &&
                    this.StorageMethod.Equals(other.StorageMethod)
                ) && 
                (
                    this.SecurityCode == other.SecurityCode ||
                    this.SecurityCode != null &&
                    this.SecurityCode.Equals(other.SecurityCode)
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
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                if (this.ExpirationMonth != null)
                    hash = hash * 59 + this.ExpirationMonth.GetHashCode();
                if (this.ExpirationYear != null)
                    hash = hash * 59 + this.ExpirationYear.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Cryptogram != null)
                    hash = hash * 59 + this.Cryptogram.GetHashCode();
                if (this.RequestorId != null)
                    hash = hash * 59 + this.RequestorId.GetHashCode();
                if (this.TransactionType != null)
                    hash = hash * 59 + this.TransactionType.GetHashCode();
                if (this.AssuranceLevel != null)
                    hash = hash * 59 + this.AssuranceLevel.GetHashCode();
                if (this.StorageMethod != null)
                    hash = hash * 59 + this.StorageMethod.GetHashCode();
                if (this.SecurityCode != null)
                    hash = hash * 59 + this.SecurityCode.GetHashCode();
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
            // Number (string) maxLength
            if(this.Number != null && this.Number.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Number, length must be less than 20.", new [] { "Number" });
            }

            // ExpirationMonth (string) maxLength
            if(this.ExpirationMonth != null && this.ExpirationMonth.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationMonth, length must be less than 2.", new [] { "ExpirationMonth" });
            }

            // ExpirationYear (string) maxLength
            if(this.ExpirationYear != null && this.ExpirationYear.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationYear, length must be less than 4.", new [] { "ExpirationYear" });
            }

            // Cryptogram (string) maxLength
            if(this.Cryptogram != null && this.Cryptogram.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cryptogram, length must be less than 40.", new [] { "Cryptogram" });
            }

            // RequestorId (string) maxLength
            if(this.RequestorId != null && this.RequestorId.Length > 11)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RequestorId, length must be less than 11.", new [] { "RequestorId" });
            }

            // TransactionType (string) maxLength
            if(this.TransactionType != null && this.TransactionType.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionType, length must be less than 1.", new [] { "TransactionType" });
            }

            // AssuranceLevel (string) maxLength
            if(this.AssuranceLevel != null && this.AssuranceLevel.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssuranceLevel, length must be less than 2.", new [] { "AssuranceLevel" });
            }

            // StorageMethod (string) maxLength
            if(this.StorageMethod != null && this.StorageMethod.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StorageMethod, length must be less than 3.", new [] { "StorageMethod" });
            }

            // SecurityCode (string) maxLength
            if(this.SecurityCode != null && this.SecurityCode.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecurityCode, length must be less than 4.", new [] { "SecurityCode" });
            }

            yield break;
        }
    }

}
