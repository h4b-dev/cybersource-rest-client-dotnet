/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// Ptsv2paymentsPaymentInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsPaymentInformation :  IEquatable<Ptsv2paymentsPaymentInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsPaymentInformation" /> class.
        /// </summary>
        /// <param name="Card">Card.</param>
        /// <param name="TokenizedCard">TokenizedCard.</param>
        /// <param name="FluidData">FluidData.</param>
        /// <param name="Customer">Customer.</param>
        /// <param name="Bank">Bank.</param>
        /// <param name="PaymentType">PaymentType.</param>
        public Ptsv2paymentsPaymentInformation(Ptsv2paymentsPaymentInformationCard Card = default(Ptsv2paymentsPaymentInformationCard), Ptsv2paymentsPaymentInformationTokenizedCard TokenizedCard = default(Ptsv2paymentsPaymentInformationTokenizedCard), Ptsv2paymentsPaymentInformationFluidData FluidData = default(Ptsv2paymentsPaymentInformationFluidData), Ptsv2paymentsPaymentInformationCustomer Customer = default(Ptsv2paymentsPaymentInformationCustomer), Ptsv2paymentsPaymentInformationBank Bank = default(Ptsv2paymentsPaymentInformationBank), Ptsv2paymentsPaymentInformationPaymentType PaymentType = default(Ptsv2paymentsPaymentInformationPaymentType))
        {
            this.Card = Card;
            this.TokenizedCard = TokenizedCard;
            this.FluidData = FluidData;
            this.Customer = Customer;
            this.Bank = Bank;
            this.PaymentType = PaymentType;
        }
        
        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public Ptsv2paymentsPaymentInformationCard Card { get; set; }

        /// <summary>
        /// Gets or Sets TokenizedCard
        /// </summary>
        [DataMember(Name="tokenizedCard", EmitDefaultValue=false)]
        public Ptsv2paymentsPaymentInformationTokenizedCard TokenizedCard { get; set; }

        /// <summary>
        /// Gets or Sets FluidData
        /// </summary>
        [DataMember(Name="fluidData", EmitDefaultValue=false)]
        public Ptsv2paymentsPaymentInformationFluidData FluidData { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        public Ptsv2paymentsPaymentInformationCustomer Customer { get; set; }

        /// <summary>
        /// Gets or Sets Bank
        /// </summary>
        [DataMember(Name="bank", EmitDefaultValue=false)]
        public Ptsv2paymentsPaymentInformationBank Bank { get; set; }

        /// <summary>
        /// Gets or Sets PaymentType
        /// </summary>
        [DataMember(Name="paymentType", EmitDefaultValue=false)]
        public Ptsv2paymentsPaymentInformationPaymentType PaymentType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsPaymentInformation {\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  TokenizedCard: ").Append(TokenizedCard).Append("\n");
            sb.Append("  FluidData: ").Append(FluidData).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Bank: ").Append(Bank).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsPaymentInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsPaymentInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsPaymentInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsPaymentInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Card == other.Card ||
                    this.Card != null &&
                    this.Card.Equals(other.Card)
                ) && 
                (
                    this.TokenizedCard == other.TokenizedCard ||
                    this.TokenizedCard != null &&
                    this.TokenizedCard.Equals(other.TokenizedCard)
                ) && 
                (
                    this.FluidData == other.FluidData ||
                    this.FluidData != null &&
                    this.FluidData.Equals(other.FluidData)
                ) && 
                (
                    this.Customer == other.Customer ||
                    this.Customer != null &&
                    this.Customer.Equals(other.Customer)
                ) && 
                (
                    this.Bank == other.Bank ||
                    this.Bank != null &&
                    this.Bank.Equals(other.Bank)
                ) && 
                (
                    this.PaymentType == other.PaymentType ||
                    this.PaymentType != null &&
                    this.PaymentType.Equals(other.PaymentType)
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
                if (this.Card != null)
                    hash = hash * 59 + this.Card.GetHashCode();
                if (this.TokenizedCard != null)
                    hash = hash * 59 + this.TokenizedCard.GetHashCode();
                if (this.FluidData != null)
                    hash = hash * 59 + this.FluidData.GetHashCode();
                if (this.Customer != null)
                    hash = hash * 59 + this.Customer.GetHashCode();
                if (this.Bank != null)
                    hash = hash * 59 + this.Bank.GetHashCode();
                if (this.PaymentType != null)
                    hash = hash * 59 + this.PaymentType.GetHashCode();
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
