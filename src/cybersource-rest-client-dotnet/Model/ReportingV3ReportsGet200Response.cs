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
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CyberSource.Model
{
    /// <summary>
    /// ReportingV3ReportsGet200Response
    /// </summary>
    [DataContract]
    public partial class ReportingV3ReportsGet200Response :  IEquatable<ReportingV3ReportsGet200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingV3ReportsGet200Response" /> class.
        /// </summary>
        /// <param name="Reports">Reports.</param>
        public ReportingV3ReportsGet200Response(List<ReportingV3ReportsGet200ResponseReports> Reports = default(List<ReportingV3ReportsGet200ResponseReports>))
        {
            this.Reports = Reports;
        }
        
        /// <summary>
        /// Gets or Sets Reports
        /// </summary>
        [DataMember(Name="reports", EmitDefaultValue=false)]
        public List<ReportingV3ReportsGet200ResponseReports> Reports { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingV3ReportsGet200Response {\n");
            sb.Append("  Reports: ").Append(Reports).Append("\n");
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
            return this.Equals(obj as ReportingV3ReportsGet200Response);
        }

        /// <summary>
        /// Returns true if ReportingV3ReportsGet200Response instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingV3ReportsGet200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingV3ReportsGet200Response other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Reports == other.Reports ||
                    this.Reports != null &&
                    this.Reports.SequenceEqual(other.Reports)
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
                if (this.Reports != null)
                    hash = hash * 59 + this.Reports.GetHashCode();
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
