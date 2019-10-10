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
    /// Ptsv2creditsProcessingInformationElectronicBenefitsTransfer
    /// </summary>
    [DataContract]
    public partial class Ptsv2creditsProcessingInformationElectronicBenefitsTransfer :  IEquatable<Ptsv2creditsProcessingInformationElectronicBenefitsTransfer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2creditsProcessingInformationElectronicBenefitsTransfer" /> class.
        /// </summary>
        /// <param name="Category">Flag that specifies the category for the EBT transaction.  Possible values: - &#x60;CASH&#x60;: Cash benefits, which can be used to purchase any item at a participating retailer, as well as to obtain cash-back or make a cash withdrawal from a participating ATM. - &#x60;FOOD&#x60;: Food stamp benefits, which can be used only to purchase food items authorized by the USDA SNAP program. .</param>
        public Ptsv2creditsProcessingInformationElectronicBenefitsTransfer(string Category = default(string))
        {
            this.Category = Category;
        }
        
        /// <summary>
        /// Flag that specifies the category for the EBT transaction.  Possible values: - &#x60;CASH&#x60;: Cash benefits, which can be used to purchase any item at a participating retailer, as well as to obtain cash-back or make a cash withdrawal from a participating ATM. - &#x60;FOOD&#x60;: Food stamp benefits, which can be used only to purchase food items authorized by the USDA SNAP program. 
        /// </summary>
        /// <value>Flag that specifies the category for the EBT transaction.  Possible values: - &#x60;CASH&#x60;: Cash benefits, which can be used to purchase any item at a participating retailer, as well as to obtain cash-back or make a cash withdrawal from a participating ATM. - &#x60;FOOD&#x60;: Food stamp benefits, which can be used only to purchase food items authorized by the USDA SNAP program. </value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2creditsProcessingInformationElectronicBenefitsTransfer {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
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
            return this.Equals(obj as Ptsv2creditsProcessingInformationElectronicBenefitsTransfer);
        }

        /// <summary>
        /// Returns true if Ptsv2creditsProcessingInformationElectronicBenefitsTransfer instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2creditsProcessingInformationElectronicBenefitsTransfer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2creditsProcessingInformationElectronicBenefitsTransfer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
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
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
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
            // Category (string) maxLength
            if(this.Category != null && this.Category.Length >= 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Category, length must be less than or equal to 4.", new [] { "Category" });
            }

            yield break;
        }
    }

}
