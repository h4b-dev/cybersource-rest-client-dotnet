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
    /// PtsV1TransactionBatchesGet200Response
    /// </summary>
    [DataContract]
    public partial class PtsV1TransactionBatchesGet200Response :  IEquatable<PtsV1TransactionBatchesGet200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV1TransactionBatchesGet200Response" /> class.
        /// </summary>
        /// <param name="TransactionBatches">TransactionBatches.</param>
        /// <param name="Links">Links.</param>
        /// <param name="SubmitTimeUtc">Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. .</param>
        public PtsV1TransactionBatchesGet200Response(List<PtsV1TransactionBatchesGet200ResponseTransactionBatches> TransactionBatches = default(List<PtsV1TransactionBatchesGet200ResponseTransactionBatches>), PtsV1TransactionBatchesGet200ResponseLinks Links = default(PtsV1TransactionBatchesGet200ResponseLinks), string SubmitTimeUtc = default(string))
        {
            this.TransactionBatches = TransactionBatches;
            this.Links = Links;
            this.SubmitTimeUtc = SubmitTimeUtc;
        }
        
        /// <summary>
        /// Gets or Sets TransactionBatches
        /// </summary>
        [DataMember(Name="transactionBatches", EmitDefaultValue=false)]
        public List<PtsV1TransactionBatchesGet200ResponseTransactionBatches> TransactionBatches { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public PtsV1TransactionBatchesGet200ResponseLinks Links { get; set; }

        /// <summary>
        /// Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. 
        /// </summary>
        /// <value>Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. </value>
        [DataMember(Name="submitTimeUtc", EmitDefaultValue=false)]
        public string SubmitTimeUtc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV1TransactionBatchesGet200Response {\n");
            sb.Append("  TransactionBatches: ").Append(TransactionBatches).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  SubmitTimeUtc: ").Append(SubmitTimeUtc).Append("\n");
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
            return this.Equals(obj as PtsV1TransactionBatchesGet200Response);
        }

        /// <summary>
        /// Returns true if PtsV1TransactionBatchesGet200Response instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV1TransactionBatchesGet200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV1TransactionBatchesGet200Response other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TransactionBatches == other.TransactionBatches ||
                    this.TransactionBatches != null &&
                    this.TransactionBatches.SequenceEqual(other.TransactionBatches)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.SubmitTimeUtc == other.SubmitTimeUtc ||
                    this.SubmitTimeUtc != null &&
                    this.SubmitTimeUtc.Equals(other.SubmitTimeUtc)
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
                if (this.TransactionBatches != null)
                    hash = hash * 59 + this.TransactionBatches.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.SubmitTimeUtc != null)
                    hash = hash * 59 + this.SubmitTimeUtc.GetHashCode();
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
