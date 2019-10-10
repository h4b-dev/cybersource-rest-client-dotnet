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
    /// Ptsv2paymentsMerchantInformationServiceFeeDescriptor
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsMerchantInformationServiceFeeDescriptor :  IEquatable<Ptsv2paymentsMerchantInformationServiceFeeDescriptor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsMerchantInformationServiceFeeDescriptor" /> class.
        /// </summary>
        /// <param name="Name">Name of the service provider that is collecting the service fee. The service provider name must consist of 3, 7, or 12 characters followed by an asterisk (*). This value must also include the words “Service Fee.”  When you include more than one consecutive space, extra spaces are removed. Use one of the following formats for this value: - &lt;3-character name&gt;*Service Fee - &lt;7-character name&gt;*Service Fee - &lt;12-character name&gt;*Service Fee  When payments are made in installments, this value must also include installment information such as “1 of 5” or “3 of 7.” For installment payments, use one of the following formats for this value: - &lt;3-character name&gt;*Service Fee*&lt;N&gt; of &lt;M&gt; - &lt;7-character name&gt;*Service Fee*&lt;N&gt; of &lt;M&gt; - &lt;12-character name&gt;*Service Fee*&lt;N&gt; of &lt;M&gt;  where &lt;N&gt; is the payment number and &lt;M&gt; is the total number of payments.  When you do not include this value in your request, CyberSource uses the value that is in your CyberSource account.  This value might be displayed on the cardholder’s statement. .</param>
        /// <param name="Contact">Contact information for the service provider that is collecting the service fee. when you include more than one consecutive space, extra spaces are removed.  When you do not include this value in your request, CyberSource uses the value that is in your CyberSource account.  This value might be displayed on the cardholder’s statement. .</param>
        /// <param name="State">State or territory in which the service provider is located.  When you do not include this value in your request, CyberSource uses the value that is in your CyberSource account.  This value might be displayed on the cardholder’s statement. .</param>
        public Ptsv2paymentsMerchantInformationServiceFeeDescriptor(string Name = default(string), string Contact = default(string), string State = default(string))
        {
            this.Name = Name;
            this.Contact = Contact;
            this.State = State;
        }
        
        /// <summary>
        /// Name of the service provider that is collecting the service fee. The service provider name must consist of 3, 7, or 12 characters followed by an asterisk (*). This value must also include the words “Service Fee.”  When you include more than one consecutive space, extra spaces are removed. Use one of the following formats for this value: - &lt;3-character name&gt;*Service Fee - &lt;7-character name&gt;*Service Fee - &lt;12-character name&gt;*Service Fee  When payments are made in installments, this value must also include installment information such as “1 of 5” or “3 of 7.” For installment payments, use one of the following formats for this value: - &lt;3-character name&gt;*Service Fee*&lt;N&gt; of &lt;M&gt; - &lt;7-character name&gt;*Service Fee*&lt;N&gt; of &lt;M&gt; - &lt;12-character name&gt;*Service Fee*&lt;N&gt; of &lt;M&gt;  where &lt;N&gt; is the payment number and &lt;M&gt; is the total number of payments.  When you do not include this value in your request, CyberSource uses the value that is in your CyberSource account.  This value might be displayed on the cardholder’s statement. 
        /// </summary>
        /// <value>Name of the service provider that is collecting the service fee. The service provider name must consist of 3, 7, or 12 characters followed by an asterisk (*). This value must also include the words “Service Fee.”  When you include more than one consecutive space, extra spaces are removed. Use one of the following formats for this value: - &lt;3-character name&gt;*Service Fee - &lt;7-character name&gt;*Service Fee - &lt;12-character name&gt;*Service Fee  When payments are made in installments, this value must also include installment information such as “1 of 5” or “3 of 7.” For installment payments, use one of the following formats for this value: - &lt;3-character name&gt;*Service Fee*&lt;N&gt; of &lt;M&gt; - &lt;7-character name&gt;*Service Fee*&lt;N&gt; of &lt;M&gt; - &lt;12-character name&gt;*Service Fee*&lt;N&gt; of &lt;M&gt;  where &lt;N&gt; is the payment number and &lt;M&gt; is the total number of payments.  When you do not include this value in your request, CyberSource uses the value that is in your CyberSource account.  This value might be displayed on the cardholder’s statement. </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Contact information for the service provider that is collecting the service fee. when you include more than one consecutive space, extra spaces are removed.  When you do not include this value in your request, CyberSource uses the value that is in your CyberSource account.  This value might be displayed on the cardholder’s statement. 
        /// </summary>
        /// <value>Contact information for the service provider that is collecting the service fee. when you include more than one consecutive space, extra spaces are removed.  When you do not include this value in your request, CyberSource uses the value that is in your CyberSource account.  This value might be displayed on the cardholder’s statement. </value>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public string Contact { get; set; }

        /// <summary>
        /// State or territory in which the service provider is located.  When you do not include this value in your request, CyberSource uses the value that is in your CyberSource account.  This value might be displayed on the cardholder’s statement. 
        /// </summary>
        /// <value>State or territory in which the service provider is located.  When you do not include this value in your request, CyberSource uses the value that is in your CyberSource account.  This value might be displayed on the cardholder’s statement. </value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsMerchantInformationServiceFeeDescriptor {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsMerchantInformationServiceFeeDescriptor);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsMerchantInformationServiceFeeDescriptor instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsMerchantInformationServiceFeeDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsMerchantInformationServiceFeeDescriptor other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Contact == other.Contact ||
                    this.Contact != null &&
                    this.Contact.Equals(other.Contact)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Contact != null)
                    hash = hash * 59 + this.Contact.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length >= 22)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than or equal to 22.", new [] { "Name" });
            }

            // Contact (string) maxLength
            if(this.Contact != null && this.Contact.Length >= 11)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Contact, length must be less than or equal to 11.", new [] { "Contact" });
            }

            // State (string) maxLength
            if(this.State != null && this.State.Length >= 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for State, length must be less than or equal to 20.", new [] { "State" });
            }

            yield break;
        }
    }

}
