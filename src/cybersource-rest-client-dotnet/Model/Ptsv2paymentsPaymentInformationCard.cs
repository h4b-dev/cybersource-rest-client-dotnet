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
    /// Ptsv2paymentsPaymentInformationCard
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsPaymentInformationCard :  IEquatable<Ptsv2paymentsPaymentInformationCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsPaymentInformationCard" /> class.
        /// </summary>
        /// <param name="Number">Customer’s credit card number. Encoded Account Numbers when processing encoded account numbers, use this field for the encoded account number.  For processor-specific information, see the customer_cc_number field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="ExpirationMonth">Two-digit month in which the credit card expires. &#x60;Format: MM&#x60;. Possible values: 01 through 12.  **Barclays and Streamline**\\ For Maestro (UK Domestic) and Maestro (International) cards on Barclays and Streamline, this must be a valid value (01 through 12) but is not required to be a valid expiration date. In other words, an expiration date that is in the past does not cause CyberSource to reject your request. However, an invalid expiration date might cause the issuer to reject your request.  **Encoded Account Numbers**\\ For encoded account numbers (_type_&#x3D;039), if there is no expiration date on the card, use 12.  For processor-specific information, see the customer_cc_expmo field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="ExpirationYear">Four-digit year in which the credit card expires. &#x60;Format: YYYY&#x60;.  **Barclays and Streamline**\\ For Maestro (UK Domestic) and Maestro (International) cards on Barclays and Streamline, this must be a valid value (1900 through 3000) but is not required to be a valid expiration date. In other words, an expiration date that is in the past does not cause CyberSource to reject your request. However, an invalid expiration date might cause the issuer to reject your request.  **FDC Nashville Global and FDMS South**\\ You can send in 2 digits or 4 digits. If you send in 2 digits, they must be the last 2 digits of the year.  **Encoded Account Numbers**\\ For encoded account numbers (_type_&#x3D;039), if there is no expiration date on the card, use 2021.  For processor-specific information, see the customer_cc_expyr field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) .</param>
        /// <param name="Type">Type of card to authorize. - 001 Visa - 002 Mastercard - 003 Amex - 004 Discover .</param>
        /// <param name="UseAs">Flag that specifies the type of account associated with the card. The cardholder provides this information during the payment process.  **Cielo** and **Comercio Latino**  Possible values:   - CREDIT: Credit card  - DEBIT: Debit card  This field is required for:  - Debit transactions on Cielo and Comercio Latino.  - Transactions with Brazilian-issued cards on CyberSource through VisaNet. .</param>
        /// <param name="SourceAccountType">Flag that specifies the type of account associated with the card. The cardholder provides this information during the payment process.  This field is required in the following cases:   - Debit transactions on Cielo and Comercio Latino.   - Transactions with Brazilian-issued cards on CyberSource through VisaNet.   - Applicable only for Visa Platform Connect (VPC).      **Note**\\ Combo cards in Brazil contain credit and debit functionality in a single card. Visa systems use a credit bank identification number (BIN) for this type of card. Using the BIN to determine whether a card is debit or credit can cause transactions with these cards to be processed incorrectly. CyberSource strongly recommends that you include this field for combo card transactions.  Possible values include the following.   - **CHECKING**: Checking account  - **CREDIT**: Credit card account  - **SAVING**: Saving account  - **LINE_OF_CREDIT**: Line of credit or credit portion of combo card  - **PREPAID**: Prepaid card account or prepaid portion of combo card  - **UNIVERSAL**: Universal account .</param>
        /// <param name="SecurityCode">Card Verification Number.  **Ingenico ePayments** Do not include this field when _commerceIndicator&#x3D;recurring_. **Note** Ingenico ePayments was previously called Global Collect. .</param>
        /// <param name="SecurityCodeIndicator">Flag that indicates whether a CVN code was sent. Possible values:   - 0 (default): CVN service not requested. CyberSource uses this default value when you do not include      _securityCode_ field in the request.  - 1 (default): CVN service requested and supported. CyberSource uses this default value when you include      _securityCode_ field in the request.  - 2: CVN on credit card is illegible.  - 9: CVN was not imprinted on credit card. .</param>
        /// <param name="AccountEncoderId">Identifier for the issuing bank that provided the customer’s encoded account number. Contact your processor for the bank’s ID. .</param>
        /// <param name="IssueNumber">Number of times a Maestro (UK Domestic) card has been issued to the account holder. The card might or might not have an issue number. The number can consist of one or two digits, and the first digit might be a zero. When you include this value in your request, include exactly what is printed on the card. A value of 2 is different than a value of 02. Do not include the field, even with a blank value, if the card is not a Maestro (UK Domestic) card.  **Note** The issue number is not required for Maestro (UK Domestic) transactions. .</param>
        /// <param name="StartMonth">Month of the start of the Maestro (UK Domestic) card validity period. Do not include the field, even with a blank value, if the card is not a Maestro (UK Domestic) card. &#x60;Format: MM&#x60;. Possible values: 01 through 12.  **Note** The start date is not required for Maestro (UK Domestic) transactions. .</param>
        /// <param name="StartYear">Year of the start of the Maestro (UK Domestic) card validity period. Do not include the field, even with a blank value, if the card is not a Maestro (UK Domestic) card. &#x60;Format: YYYY&#x60;.  **Note** The start date is not required for Maestro (UK Domestic) transactions. .</param>
        /// <param name="ProductName">Name of the card product.  Possible value: - BNDES  This field is supported only for BNDES transactions on CyberSource through VisaNet. See BNDES.  The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP07 TCR4 - Position: 115-120 - Field: Brazil Country Data .</param>
        public Ptsv2paymentsPaymentInformationCard(string Number = default(string), string ExpirationMonth = default(string), string ExpirationYear = default(string), string Type = default(string), string UseAs = default(string), string SourceAccountType = default(string), string SecurityCode = default(string), string SecurityCodeIndicator = default(string), string AccountEncoderId = default(string), string IssueNumber = default(string), string StartMonth = default(string), string StartYear = default(string), string ProductName = default(string))
        {
            this.Number = Number;
            this.ExpirationMonth = ExpirationMonth;
            this.ExpirationYear = ExpirationYear;
            this.Type = Type;
            this.UseAs = UseAs;
            this.SourceAccountType = SourceAccountType;
            this.SecurityCode = SecurityCode;
            this.SecurityCodeIndicator = SecurityCodeIndicator;
            this.AccountEncoderId = AccountEncoderId;
            this.IssueNumber = IssueNumber;
            this.StartMonth = StartMonth;
            this.StartYear = StartYear;
            this.ProductName = ProductName;
        }
        
        /// <summary>
        /// Customer’s credit card number. Encoded Account Numbers when processing encoded account numbers, use this field for the encoded account number.  For processor-specific information, see the customer_cc_number field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Customer’s credit card number. Encoded Account Numbers when processing encoded account numbers, use this field for the encoded account number.  For processor-specific information, see the customer_cc_number field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Two-digit month in which the credit card expires. &#x60;Format: MM&#x60;. Possible values: 01 through 12.  **Barclays and Streamline**\\ For Maestro (UK Domestic) and Maestro (International) cards on Barclays and Streamline, this must be a valid value (01 through 12) but is not required to be a valid expiration date. In other words, an expiration date that is in the past does not cause CyberSource to reject your request. However, an invalid expiration date might cause the issuer to reject your request.  **Encoded Account Numbers**\\ For encoded account numbers (_type_&#x3D;039), if there is no expiration date on the card, use 12.  For processor-specific information, see the customer_cc_expmo field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Two-digit month in which the credit card expires. &#x60;Format: MM&#x60;. Possible values: 01 through 12.  **Barclays and Streamline**\\ For Maestro (UK Domestic) and Maestro (International) cards on Barclays and Streamline, this must be a valid value (01 through 12) but is not required to be a valid expiration date. In other words, an expiration date that is in the past does not cause CyberSource to reject your request. However, an invalid expiration date might cause the issuer to reject your request.  **Encoded Account Numbers**\\ For encoded account numbers (_type_&#x3D;039), if there is no expiration date on the card, use 12.  For processor-specific information, see the customer_cc_expmo field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="expirationMonth", EmitDefaultValue=false)]
        public string ExpirationMonth { get; set; }

        /// <summary>
        /// Four-digit year in which the credit card expires. &#x60;Format: YYYY&#x60;.  **Barclays and Streamline**\\ For Maestro (UK Domestic) and Maestro (International) cards on Barclays and Streamline, this must be a valid value (1900 through 3000) but is not required to be a valid expiration date. In other words, an expiration date that is in the past does not cause CyberSource to reject your request. However, an invalid expiration date might cause the issuer to reject your request.  **FDC Nashville Global and FDMS South**\\ You can send in 2 digits or 4 digits. If you send in 2 digits, they must be the last 2 digits of the year.  **Encoded Account Numbers**\\ For encoded account numbers (_type_&#x3D;039), if there is no expiration date on the card, use 2021.  For processor-specific information, see the customer_cc_expyr field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) 
        /// </summary>
        /// <value>Four-digit year in which the credit card expires. &#x60;Format: YYYY&#x60;.  **Barclays and Streamline**\\ For Maestro (UK Domestic) and Maestro (International) cards on Barclays and Streamline, this must be a valid value (1900 through 3000) but is not required to be a valid expiration date. In other words, an expiration date that is in the past does not cause CyberSource to reject your request. However, an invalid expiration date might cause the issuer to reject your request.  **FDC Nashville Global and FDMS South**\\ You can send in 2 digits or 4 digits. If you send in 2 digits, they must be the last 2 digits of the year.  **Encoded Account Numbers**\\ For encoded account numbers (_type_&#x3D;039), if there is no expiration date on the card, use 2021.  For processor-specific information, see the customer_cc_expyr field in [Credit Card Services Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html) </value>
        [DataMember(Name="expirationYear", EmitDefaultValue=false)]
        public string ExpirationYear { get; set; }

        /// <summary>
        /// Type of card to authorize. - 001 Visa - 002 Mastercard - 003 Amex - 004 Discover 
        /// </summary>
        /// <value>Type of card to authorize. - 001 Visa - 002 Mastercard - 003 Amex - 004 Discover </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Flag that specifies the type of account associated with the card. The cardholder provides this information during the payment process.  **Cielo** and **Comercio Latino**  Possible values:   - CREDIT: Credit card  - DEBIT: Debit card  This field is required for:  - Debit transactions on Cielo and Comercio Latino.  - Transactions with Brazilian-issued cards on CyberSource through VisaNet. 
        /// </summary>
        /// <value>Flag that specifies the type of account associated with the card. The cardholder provides this information during the payment process.  **Cielo** and **Comercio Latino**  Possible values:   - CREDIT: Credit card  - DEBIT: Debit card  This field is required for:  - Debit transactions on Cielo and Comercio Latino.  - Transactions with Brazilian-issued cards on CyberSource through VisaNet. </value>
        [DataMember(Name="useAs", EmitDefaultValue=false)]
        public string UseAs { get; set; }

        /// <summary>
        /// Flag that specifies the type of account associated with the card. The cardholder provides this information during the payment process.  This field is required in the following cases:   - Debit transactions on Cielo and Comercio Latino.   - Transactions with Brazilian-issued cards on CyberSource through VisaNet.   - Applicable only for Visa Platform Connect (VPC).      **Note**\\ Combo cards in Brazil contain credit and debit functionality in a single card. Visa systems use a credit bank identification number (BIN) for this type of card. Using the BIN to determine whether a card is debit or credit can cause transactions with these cards to be processed incorrectly. CyberSource strongly recommends that you include this field for combo card transactions.  Possible values include the following.   - **CHECKING**: Checking account  - **CREDIT**: Credit card account  - **SAVING**: Saving account  - **LINE_OF_CREDIT**: Line of credit or credit portion of combo card  - **PREPAID**: Prepaid card account or prepaid portion of combo card  - **UNIVERSAL**: Universal account 
        /// </summary>
        /// <value>Flag that specifies the type of account associated with the card. The cardholder provides this information during the payment process.  This field is required in the following cases:   - Debit transactions on Cielo and Comercio Latino.   - Transactions with Brazilian-issued cards on CyberSource through VisaNet.   - Applicable only for Visa Platform Connect (VPC).      **Note**\\ Combo cards in Brazil contain credit and debit functionality in a single card. Visa systems use a credit bank identification number (BIN) for this type of card. Using the BIN to determine whether a card is debit or credit can cause transactions with these cards to be processed incorrectly. CyberSource strongly recommends that you include this field for combo card transactions.  Possible values include the following.   - **CHECKING**: Checking account  - **CREDIT**: Credit card account  - **SAVING**: Saving account  - **LINE_OF_CREDIT**: Line of credit or credit portion of combo card  - **PREPAID**: Prepaid card account or prepaid portion of combo card  - **UNIVERSAL**: Universal account </value>
        [DataMember(Name="sourceAccountType", EmitDefaultValue=false)]
        public string SourceAccountType { get; set; }

        /// <summary>
        /// Card Verification Number.  **Ingenico ePayments** Do not include this field when _commerceIndicator&#x3D;recurring_. **Note** Ingenico ePayments was previously called Global Collect. 
        /// </summary>
        /// <value>Card Verification Number.  **Ingenico ePayments** Do not include this field when _commerceIndicator&#x3D;recurring_. **Note** Ingenico ePayments was previously called Global Collect. </value>
        [DataMember(Name="securityCode", EmitDefaultValue=false)]
        public string SecurityCode { get; set; }

        /// <summary>
        /// Flag that indicates whether a CVN code was sent. Possible values:   - 0 (default): CVN service not requested. CyberSource uses this default value when you do not include      _securityCode_ field in the request.  - 1 (default): CVN service requested and supported. CyberSource uses this default value when you include      _securityCode_ field in the request.  - 2: CVN on credit card is illegible.  - 9: CVN was not imprinted on credit card. 
        /// </summary>
        /// <value>Flag that indicates whether a CVN code was sent. Possible values:   - 0 (default): CVN service not requested. CyberSource uses this default value when you do not include      _securityCode_ field in the request.  - 1 (default): CVN service requested and supported. CyberSource uses this default value when you include      _securityCode_ field in the request.  - 2: CVN on credit card is illegible.  - 9: CVN was not imprinted on credit card. </value>
        [DataMember(Name="securityCodeIndicator", EmitDefaultValue=false)]
        public string SecurityCodeIndicator { get; set; }

        /// <summary>
        /// Identifier for the issuing bank that provided the customer’s encoded account number. Contact your processor for the bank’s ID. 
        /// </summary>
        /// <value>Identifier for the issuing bank that provided the customer’s encoded account number. Contact your processor for the bank’s ID. </value>
        [DataMember(Name="accountEncoderId", EmitDefaultValue=false)]
        public string AccountEncoderId { get; set; }

        /// <summary>
        /// Number of times a Maestro (UK Domestic) card has been issued to the account holder. The card might or might not have an issue number. The number can consist of one or two digits, and the first digit might be a zero. When you include this value in your request, include exactly what is printed on the card. A value of 2 is different than a value of 02. Do not include the field, even with a blank value, if the card is not a Maestro (UK Domestic) card.  **Note** The issue number is not required for Maestro (UK Domestic) transactions. 
        /// </summary>
        /// <value>Number of times a Maestro (UK Domestic) card has been issued to the account holder. The card might or might not have an issue number. The number can consist of one or two digits, and the first digit might be a zero. When you include this value in your request, include exactly what is printed on the card. A value of 2 is different than a value of 02. Do not include the field, even with a blank value, if the card is not a Maestro (UK Domestic) card.  **Note** The issue number is not required for Maestro (UK Domestic) transactions. </value>
        [DataMember(Name="issueNumber", EmitDefaultValue=false)]
        public string IssueNumber { get; set; }

        /// <summary>
        /// Month of the start of the Maestro (UK Domestic) card validity period. Do not include the field, even with a blank value, if the card is not a Maestro (UK Domestic) card. &#x60;Format: MM&#x60;. Possible values: 01 through 12.  **Note** The start date is not required for Maestro (UK Domestic) transactions. 
        /// </summary>
        /// <value>Month of the start of the Maestro (UK Domestic) card validity period. Do not include the field, even with a blank value, if the card is not a Maestro (UK Domestic) card. &#x60;Format: MM&#x60;. Possible values: 01 through 12.  **Note** The start date is not required for Maestro (UK Domestic) transactions. </value>
        [DataMember(Name="startMonth", EmitDefaultValue=false)]
        public string StartMonth { get; set; }

        /// <summary>
        /// Year of the start of the Maestro (UK Domestic) card validity period. Do not include the field, even with a blank value, if the card is not a Maestro (UK Domestic) card. &#x60;Format: YYYY&#x60;.  **Note** The start date is not required for Maestro (UK Domestic) transactions. 
        /// </summary>
        /// <value>Year of the start of the Maestro (UK Domestic) card validity period. Do not include the field, even with a blank value, if the card is not a Maestro (UK Domestic) card. &#x60;Format: YYYY&#x60;.  **Note** The start date is not required for Maestro (UK Domestic) transactions. </value>
        [DataMember(Name="startYear", EmitDefaultValue=false)]
        public string StartYear { get; set; }

        /// <summary>
        /// Name of the card product.  Possible value: - BNDES  This field is supported only for BNDES transactions on CyberSource through VisaNet. See BNDES.  The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP07 TCR4 - Position: 115-120 - Field: Brazil Country Data 
        /// </summary>
        /// <value>Name of the card product.  Possible value: - BNDES  This field is supported only for BNDES transactions on CyberSource through VisaNet. See BNDES.  The value for this field corresponds to the following data in the TC 33 capture file5: - Record: CP07 TCR4 - Position: 115-120 - Field: Brazil Country Data </value>
        [DataMember(Name="productName", EmitDefaultValue=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsPaymentInformationCard {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  ExpirationMonth: ").Append(ExpirationMonth).Append("\n");
            sb.Append("  ExpirationYear: ").Append(ExpirationYear).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UseAs: ").Append(UseAs).Append("\n");
            sb.Append("  SourceAccountType: ").Append(SourceAccountType).Append("\n");
            sb.Append("  SecurityCode: ").Append(SecurityCode).Append("\n");
            sb.Append("  SecurityCodeIndicator: ").Append(SecurityCodeIndicator).Append("\n");
            sb.Append("  AccountEncoderId: ").Append(AccountEncoderId).Append("\n");
            sb.Append("  IssueNumber: ").Append(IssueNumber).Append("\n");
            sb.Append("  StartMonth: ").Append(StartMonth).Append("\n");
            sb.Append("  StartYear: ").Append(StartYear).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsPaymentInformationCard);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsPaymentInformationCard instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsPaymentInformationCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsPaymentInformationCard other)
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
                    this.UseAs == other.UseAs ||
                    this.UseAs != null &&
                    this.UseAs.Equals(other.UseAs)
                ) && 
                (
                    this.SourceAccountType == other.SourceAccountType ||
                    this.SourceAccountType != null &&
                    this.SourceAccountType.Equals(other.SourceAccountType)
                ) && 
                (
                    this.SecurityCode == other.SecurityCode ||
                    this.SecurityCode != null &&
                    this.SecurityCode.Equals(other.SecurityCode)
                ) && 
                (
                    this.SecurityCodeIndicator == other.SecurityCodeIndicator ||
                    this.SecurityCodeIndicator != null &&
                    this.SecurityCodeIndicator.Equals(other.SecurityCodeIndicator)
                ) && 
                (
                    this.AccountEncoderId == other.AccountEncoderId ||
                    this.AccountEncoderId != null &&
                    this.AccountEncoderId.Equals(other.AccountEncoderId)
                ) && 
                (
                    this.IssueNumber == other.IssueNumber ||
                    this.IssueNumber != null &&
                    this.IssueNumber.Equals(other.IssueNumber)
                ) && 
                (
                    this.StartMonth == other.StartMonth ||
                    this.StartMonth != null &&
                    this.StartMonth.Equals(other.StartMonth)
                ) && 
                (
                    this.StartYear == other.StartYear ||
                    this.StartYear != null &&
                    this.StartYear.Equals(other.StartYear)
                ) && 
                (
                    this.ProductName == other.ProductName ||
                    this.ProductName != null &&
                    this.ProductName.Equals(other.ProductName)
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
                if (this.UseAs != null)
                    hash = hash * 59 + this.UseAs.GetHashCode();
                if (this.SourceAccountType != null)
                    hash = hash * 59 + this.SourceAccountType.GetHashCode();
                if (this.SecurityCode != null)
                    hash = hash * 59 + this.SecurityCode.GetHashCode();
                if (this.SecurityCodeIndicator != null)
                    hash = hash * 59 + this.SecurityCodeIndicator.GetHashCode();
                if (this.AccountEncoderId != null)
                    hash = hash * 59 + this.AccountEncoderId.GetHashCode();
                if (this.IssueNumber != null)
                    hash = hash * 59 + this.IssueNumber.GetHashCode();
                if (this.StartMonth != null)
                    hash = hash * 59 + this.StartMonth.GetHashCode();
                if (this.StartYear != null)
                    hash = hash * 59 + this.StartYear.GetHashCode();
                if (this.ProductName != null)
                    hash = hash * 59 + this.ProductName.GetHashCode();
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

            // UseAs (string) maxLength
            if(this.UseAs != null && this.UseAs.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UseAs, length must be less than 20.", new [] { "UseAs" });
            }

            // SourceAccountType (string) maxLength
            if(this.SourceAccountType != null && this.SourceAccountType.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SourceAccountType, length must be less than 20.", new [] { "SourceAccountType" });
            }

            // SecurityCode (string) maxLength
            if(this.SecurityCode != null && this.SecurityCode.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecurityCode, length must be less than 4.", new [] { "SecurityCode" });
            }

            // SecurityCodeIndicator (string) maxLength
            if(this.SecurityCodeIndicator != null && this.SecurityCodeIndicator.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecurityCodeIndicator, length must be less than 1.", new [] { "SecurityCodeIndicator" });
            }

            // AccountEncoderId (string) maxLength
            if(this.AccountEncoderId != null && this.AccountEncoderId.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountEncoderId, length must be less than 3.", new [] { "AccountEncoderId" });
            }

            // IssueNumber (string) maxLength
            if(this.IssueNumber != null && this.IssueNumber.Length > 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IssueNumber, length must be less than 5.", new [] { "IssueNumber" });
            }

            // StartMonth (string) maxLength
            if(this.StartMonth != null && this.StartMonth.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartMonth, length must be less than 2.", new [] { "StartMonth" });
            }

            // StartYear (string) maxLength
            if(this.StartYear != null && this.StartYear.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartYear, length must be less than 4.", new [] { "StartYear" });
            }

            // ProductName (string) maxLength
            if(this.ProductName != null && this.ProductName.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductName, length must be less than 15.", new [] { "ProductName" });
            }

            yield break;
        }
    }

}
