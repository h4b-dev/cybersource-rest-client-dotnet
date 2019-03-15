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
    /// Ptsv2paymentsidrefundsProcessingInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsidrefundsProcessingInformation :  IEquatable<Ptsv2paymentsidrefundsProcessingInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsidrefundsProcessingInformation" /> class.
        /// </summary>
        /// <param name="PaymentSolution">Type of digital payment solution for the transaction. Possible Values:   - **visacheckout**: Visa Checkout. This value is required for Visa Checkout transactions. See Visa Checkout Using the SCMP API.  - **005**: Masterpass. This value is required for Masterpass transactions on OmniPay Direct. See \&quot;Masterpass,\&quot; page 153. .</param>
        /// <param name="ReconciliationId">Please check with Cybersource customer support to see if your merchant account is configured correctly so you can include this field in your request. * For Payouts: max length for FDCCompass is String (22). .</param>
        /// <param name="LinkId">Value that links the current authorization request to the original authorization request. Set this value to the ID that was returned in the reply message from the original authorization request.  This value is used for:   - Partial authorizations: See \&quot;Partial Authorizations,\&quot; page 88.  - Split shipments: See \&quot;Split Shipments,\&quot; page 210. .</param>
        /// <param name="ReportGroup">Attribute that lets you define custom grouping for your processor reports. This field is supported only for **Worldpay VAP**.  See \&quot;Report Groups,\&quot; page 234. .</param>
        /// <param name="VisaCheckoutId">Identifier for the **Visa Checkout** order. Visa Checkout provides a unique order ID for every transaction in the Visa Checkout **callID** field.  For more details, see Visa Checkout Using the SCMP API. .</param>
        /// <param name="PurchaseLevel">Set this field to 3 to indicate that the request includes Level III data..</param>
        /// <param name="RecurringOptions">RecurringOptions.</param>
        public Ptsv2paymentsidrefundsProcessingInformation(string PaymentSolution = default(string), string ReconciliationId = default(string), string LinkId = default(string), string ReportGroup = default(string), string VisaCheckoutId = default(string), string PurchaseLevel = default(string), Ptsv2paymentsidrefundsProcessingInformationRecurringOptions RecurringOptions = default(Ptsv2paymentsidrefundsProcessingInformationRecurringOptions))
        {
            this.PaymentSolution = PaymentSolution;
            this.ReconciliationId = ReconciliationId;
            this.LinkId = LinkId;
            this.ReportGroup = ReportGroup;
            this.VisaCheckoutId = VisaCheckoutId;
            this.PurchaseLevel = PurchaseLevel;
            this.RecurringOptions = RecurringOptions;
        }
        
        /// <summary>
        /// Type of digital payment solution for the transaction. Possible Values:   - **visacheckout**: Visa Checkout. This value is required for Visa Checkout transactions. See Visa Checkout Using the SCMP API.  - **005**: Masterpass. This value is required for Masterpass transactions on OmniPay Direct. See \&quot;Masterpass,\&quot; page 153. 
        /// </summary>
        /// <value>Type of digital payment solution for the transaction. Possible Values:   - **visacheckout**: Visa Checkout. This value is required for Visa Checkout transactions. See Visa Checkout Using the SCMP API.  - **005**: Masterpass. This value is required for Masterpass transactions on OmniPay Direct. See \&quot;Masterpass,\&quot; page 153. </value>
        [DataMember(Name="paymentSolution", EmitDefaultValue=false)]
        public string PaymentSolution { get; set; }

        /// <summary>
        /// Please check with Cybersource customer support to see if your merchant account is configured correctly so you can include this field in your request. * For Payouts: max length for FDCCompass is String (22). 
        /// </summary>
        /// <value>Please check with Cybersource customer support to see if your merchant account is configured correctly so you can include this field in your request. * For Payouts: max length for FDCCompass is String (22). </value>
        [DataMember(Name="reconciliationId", EmitDefaultValue=false)]
        public string ReconciliationId { get; set; }

        /// <summary>
        /// Value that links the current authorization request to the original authorization request. Set this value to the ID that was returned in the reply message from the original authorization request.  This value is used for:   - Partial authorizations: See \&quot;Partial Authorizations,\&quot; page 88.  - Split shipments: See \&quot;Split Shipments,\&quot; page 210. 
        /// </summary>
        /// <value>Value that links the current authorization request to the original authorization request. Set this value to the ID that was returned in the reply message from the original authorization request.  This value is used for:   - Partial authorizations: See \&quot;Partial Authorizations,\&quot; page 88.  - Split shipments: See \&quot;Split Shipments,\&quot; page 210. </value>
        [DataMember(Name="linkId", EmitDefaultValue=false)]
        public string LinkId { get; set; }

        /// <summary>
        /// Attribute that lets you define custom grouping for your processor reports. This field is supported only for **Worldpay VAP**.  See \&quot;Report Groups,\&quot; page 234. 
        /// </summary>
        /// <value>Attribute that lets you define custom grouping for your processor reports. This field is supported only for **Worldpay VAP**.  See \&quot;Report Groups,\&quot; page 234. </value>
        [DataMember(Name="reportGroup", EmitDefaultValue=false)]
        public string ReportGroup { get; set; }

        /// <summary>
        /// Identifier for the **Visa Checkout** order. Visa Checkout provides a unique order ID for every transaction in the Visa Checkout **callID** field.  For more details, see Visa Checkout Using the SCMP API. 
        /// </summary>
        /// <value>Identifier for the **Visa Checkout** order. Visa Checkout provides a unique order ID for every transaction in the Visa Checkout **callID** field.  For more details, see Visa Checkout Using the SCMP API. </value>
        [DataMember(Name="visaCheckoutId", EmitDefaultValue=false)]
        public string VisaCheckoutId { get; set; }

        /// <summary>
        /// Set this field to 3 to indicate that the request includes Level III data.
        /// </summary>
        /// <value>Set this field to 3 to indicate that the request includes Level III data.</value>
        [DataMember(Name="purchaseLevel", EmitDefaultValue=false)]
        public string PurchaseLevel { get; set; }

        /// <summary>
        /// Gets or Sets RecurringOptions
        /// </summary>
        [DataMember(Name="recurringOptions", EmitDefaultValue=false)]
        public Ptsv2paymentsidrefundsProcessingInformationRecurringOptions RecurringOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsidrefundsProcessingInformation {\n");
            sb.Append("  PaymentSolution: ").Append(PaymentSolution).Append("\n");
            sb.Append("  ReconciliationId: ").Append(ReconciliationId).Append("\n");
            sb.Append("  LinkId: ").Append(LinkId).Append("\n");
            sb.Append("  ReportGroup: ").Append(ReportGroup).Append("\n");
            sb.Append("  VisaCheckoutId: ").Append(VisaCheckoutId).Append("\n");
            sb.Append("  PurchaseLevel: ").Append(PurchaseLevel).Append("\n");
            sb.Append("  RecurringOptions: ").Append(RecurringOptions).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsidrefundsProcessingInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsidrefundsProcessingInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsidrefundsProcessingInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsidrefundsProcessingInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PaymentSolution == other.PaymentSolution ||
                    this.PaymentSolution != null &&
                    this.PaymentSolution.Equals(other.PaymentSolution)
                ) && 
                (
                    this.ReconciliationId == other.ReconciliationId ||
                    this.ReconciliationId != null &&
                    this.ReconciliationId.Equals(other.ReconciliationId)
                ) && 
                (
                    this.LinkId == other.LinkId ||
                    this.LinkId != null &&
                    this.LinkId.Equals(other.LinkId)
                ) && 
                (
                    this.ReportGroup == other.ReportGroup ||
                    this.ReportGroup != null &&
                    this.ReportGroup.Equals(other.ReportGroup)
                ) && 
                (
                    this.VisaCheckoutId == other.VisaCheckoutId ||
                    this.VisaCheckoutId != null &&
                    this.VisaCheckoutId.Equals(other.VisaCheckoutId)
                ) && 
                (
                    this.PurchaseLevel == other.PurchaseLevel ||
                    this.PurchaseLevel != null &&
                    this.PurchaseLevel.Equals(other.PurchaseLevel)
                ) && 
                (
                    this.RecurringOptions == other.RecurringOptions ||
                    this.RecurringOptions != null &&
                    this.RecurringOptions.Equals(other.RecurringOptions)
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
                if (this.PaymentSolution != null)
                    hash = hash * 59 + this.PaymentSolution.GetHashCode();
                if (this.ReconciliationId != null)
                    hash = hash * 59 + this.ReconciliationId.GetHashCode();
                if (this.LinkId != null)
                    hash = hash * 59 + this.LinkId.GetHashCode();
                if (this.ReportGroup != null)
                    hash = hash * 59 + this.ReportGroup.GetHashCode();
                if (this.VisaCheckoutId != null)
                    hash = hash * 59 + this.VisaCheckoutId.GetHashCode();
                if (this.PurchaseLevel != null)
                    hash = hash * 59 + this.PurchaseLevel.GetHashCode();
                if (this.RecurringOptions != null)
                    hash = hash * 59 + this.RecurringOptions.GetHashCode();
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
            // PaymentSolution (string) maxLength
            if(this.PaymentSolution != null && this.PaymentSolution.Length > 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentSolution, length must be less than 12.", new [] { "PaymentSolution" });
            }

            // ReconciliationId (string) maxLength
            if(this.ReconciliationId != null && this.ReconciliationId.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReconciliationId, length must be less than 60.", new [] { "ReconciliationId" });
            }

            // LinkId (string) maxLength
            if(this.LinkId != null && this.LinkId.Length > 26)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LinkId, length must be less than 26.", new [] { "LinkId" });
            }

            // ReportGroup (string) maxLength
            if(this.ReportGroup != null && this.ReportGroup.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReportGroup, length must be less than 25.", new [] { "ReportGroup" });
            }

            // VisaCheckoutId (string) maxLength
            if(this.VisaCheckoutId != null && this.VisaCheckoutId.Length > 48)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisaCheckoutId, length must be less than 48.", new [] { "VisaCheckoutId" });
            }

            // PurchaseLevel (string) maxLength
            if(this.PurchaseLevel != null && this.PurchaseLevel.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PurchaseLevel, length must be less than 1.", new [] { "PurchaseLevel" });
            }

            yield break;
        }
    }

}
