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
    /// CardInfo
    /// </summary>
    [DataContract]
    public partial class CardInfo :  IEquatable<CardInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardInfo" /> class.
        /// </summary>
        /// <param name="CardNumber">Encrypted or plain text card number. If the encryption type of “None” was used in the Generate Key request, this value can be set to the plaintext card number/Personal Account Number (PAN). If the encryption type of RsaOaep256 was used in the Generate Key request, this value needs to be the RSA OAEP 256 encrypted card number. The card number should be encrypted on the cardholders’ device. The [WebCrypto API] (https://github.com/CyberSource/cybersource-flex-samples/blob/master/java/spring-boot/src/main/resources/public/flex.js) can be used with the JWK obtained in the Generate Key request..</param>
        /// <param name="CardExpirationMonth">Two digit expiration month.</param>
        /// <param name="CardExpirationYear">Four digit expiration year.</param>
        /// <param name="CardType">Card Type. This field is required. Refer to the CyberSource Credit Card Services documentation for supported card types..</param>
        public CardInfo(string CardNumber = default(string), string CardExpirationMonth = default(string), string CardExpirationYear = default(string), string CardType = default(string))
        {
            this.CardNumber = CardNumber;
            this.CardExpirationMonth = CardExpirationMonth;
            this.CardExpirationYear = CardExpirationYear;
            this.CardType = CardType;
        }
        
        /// <summary>
        /// Encrypted or plain text card number. If the encryption type of “None” was used in the Generate Key request, this value can be set to the plaintext card number/Personal Account Number (PAN). If the encryption type of RsaOaep256 was used in the Generate Key request, this value needs to be the RSA OAEP 256 encrypted card number. The card number should be encrypted on the cardholders’ device. The [WebCrypto API] (https://github.com/CyberSource/cybersource-flex-samples/blob/master/java/spring-boot/src/main/resources/public/flex.js) can be used with the JWK obtained in the Generate Key request.
        /// </summary>
        /// <value>Encrypted or plain text card number. If the encryption type of “None” was used in the Generate Key request, this value can be set to the plaintext card number/Personal Account Number (PAN). If the encryption type of RsaOaep256 was used in the Generate Key request, this value needs to be the RSA OAEP 256 encrypted card number. The card number should be encrypted on the cardholders’ device. The [WebCrypto API] (https://github.com/CyberSource/cybersource-flex-samples/blob/master/java/spring-boot/src/main/resources/public/flex.js) can be used with the JWK obtained in the Generate Key request.</value>
        [DataMember(Name="cardNumber", EmitDefaultValue=false)]
        public string CardNumber { get; set; }

        /// <summary>
        /// Two digit expiration month
        /// </summary>
        /// <value>Two digit expiration month</value>
        [DataMember(Name="cardExpirationMonth", EmitDefaultValue=false)]
        public string CardExpirationMonth { get; set; }

        /// <summary>
        /// Four digit expiration year
        /// </summary>
        /// <value>Four digit expiration year</value>
        [DataMember(Name="cardExpirationYear", EmitDefaultValue=false)]
        public string CardExpirationYear { get; set; }

        /// <summary>
        /// Card Type. This field is required. Refer to the CyberSource Credit Card Services documentation for supported card types.
        /// </summary>
        /// <value>Card Type. This field is required. Refer to the CyberSource Credit Card Services documentation for supported card types.</value>
        [DataMember(Name="cardType", EmitDefaultValue=false)]
        public string CardType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CardInfo {\n");
            sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  CardExpirationMonth: ").Append(CardExpirationMonth).Append("\n");
            sb.Append("  CardExpirationYear: ").Append(CardExpirationYear).Append("\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
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
            return this.Equals(obj as CardInfo);
        }

        /// <summary>
        /// Returns true if CardInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of CardInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CardNumber == other.CardNumber ||
                    this.CardNumber != null &&
                    this.CardNumber.Equals(other.CardNumber)
                ) && 
                (
                    this.CardExpirationMonth == other.CardExpirationMonth ||
                    this.CardExpirationMonth != null &&
                    this.CardExpirationMonth.Equals(other.CardExpirationMonth)
                ) && 
                (
                    this.CardExpirationYear == other.CardExpirationYear ||
                    this.CardExpirationYear != null &&
                    this.CardExpirationYear.Equals(other.CardExpirationYear)
                ) && 
                (
                    this.CardType == other.CardType ||
                    this.CardType != null &&
                    this.CardType.Equals(other.CardType)
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
                if (this.CardNumber != null)
                    hash = hash * 59 + this.CardNumber.GetHashCode();
                if (this.CardExpirationMonth != null)
                    hash = hash * 59 + this.CardExpirationMonth.GetHashCode();
                if (this.CardExpirationYear != null)
                    hash = hash * 59 + this.CardExpirationYear.GetHashCode();
                if (this.CardType != null)
                    hash = hash * 59 + this.CardType.GetHashCode();
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
