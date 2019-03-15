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
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace CyberSource.Model
{
    /// <summary>
    /// PtsV2PaymentsReversalsPost400Response
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsReversalsPost400Response :  IEquatable<PtsV2PaymentsReversalsPost400Response>, IValidatableObject
    {
        /// <summary>
        /// The status of the submitted transaction.  Possible values:  - INVALID_REQUEST 
        /// </summary>
        /// <value>The status of the submitted transaction.  Possible values:  - INVALID_REQUEST </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum REQUEST for "INVALID_REQUEST"
            /// </summary>
            [EnumMember(Value = "INVALID_REQUEST")]
            REQUEST
        }

        /// <summary>
        /// The reason of the status.  Possible values:  - MISSING_FIELD  - INVALID_DATA  - DUPLICATE_REQUEST  - INVALID_MERCHANT_CONFIGURATION  - PROCESSOR_UNAVAILABLE  - AUTH_ALREADY_REVERSED  - TRANSACTION_ALREADY_SETTLED  - INVALID_AMOUNT  - MISSING_AUTH  - TRANSACTION_ALREADY_REVERSED_OR_SETTLED 
        /// </summary>
        /// <value>The reason of the status.  Possible values:  - MISSING_FIELD  - INVALID_DATA  - DUPLICATE_REQUEST  - INVALID_MERCHANT_CONFIGURATION  - PROCESSOR_UNAVAILABLE  - AUTH_ALREADY_REVERSED  - TRANSACTION_ALREADY_SETTLED  - INVALID_AMOUNT  - MISSING_AUTH  - TRANSACTION_ALREADY_REVERSED_OR_SETTLED </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            
            /// <summary>
            /// Enum MISSINGFIELD for "MISSING_FIELD"
            /// </summary>
            [EnumMember(Value = "MISSING_FIELD")]
            MISSINGFIELD,
            
            /// <summary>
            /// Enum INVALIDDATA for "INVALID_DATA"
            /// </summary>
            [EnumMember(Value = "INVALID_DATA")]
            INVALIDDATA,
            
            /// <summary>
            /// Enum DUPLICATEREQUEST for "DUPLICATE_REQUEST"
            /// </summary>
            [EnumMember(Value = "DUPLICATE_REQUEST")]
            DUPLICATEREQUEST,
            
            /// <summary>
            /// Enum INVALIDMERCHANTCONFIGURATION for "INVALID_MERCHANT_CONFIGURATION"
            /// </summary>
            [EnumMember(Value = "INVALID_MERCHANT_CONFIGURATION")]
            INVALIDMERCHANTCONFIGURATION,
            
            /// <summary>
            /// Enum AUTHALREADYREVERSED for "AUTH_ALREADY_REVERSED"
            /// </summary>
            [EnumMember(Value = "AUTH_ALREADY_REVERSED")]
            AUTHALREADYREVERSED,
            
            /// <summary>
            /// Enum MISSINGAUTH for "MISSING_AUTH"
            /// </summary>
            [EnumMember(Value = "MISSING_AUTH")]
            MISSINGAUTH,
            
            /// <summary>
            /// Enum TRANSACTIONALREADYREVERSEDORSETTLED for "TRANSACTION_ALREADY_REVERSED_OR_SETTLED"
            /// </summary>
            [EnumMember(Value = "TRANSACTION_ALREADY_REVERSED_OR_SETTLED")]
            TRANSACTIONALREADYREVERSEDORSETTLED
        }

        /// <summary>
        /// The status of the submitted transaction.  Possible values:  - INVALID_REQUEST 
        /// </summary>
        /// <value>The status of the submitted transaction.  Possible values:  - INVALID_REQUEST </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The reason of the status.  Possible values:  - MISSING_FIELD  - INVALID_DATA  - DUPLICATE_REQUEST  - INVALID_MERCHANT_CONFIGURATION  - PROCESSOR_UNAVAILABLE  - AUTH_ALREADY_REVERSED  - TRANSACTION_ALREADY_SETTLED  - INVALID_AMOUNT  - MISSING_AUTH  - TRANSACTION_ALREADY_REVERSED_OR_SETTLED 
        /// </summary>
        /// <value>The reason of the status.  Possible values:  - MISSING_FIELD  - INVALID_DATA  - DUPLICATE_REQUEST  - INVALID_MERCHANT_CONFIGURATION  - PROCESSOR_UNAVAILABLE  - AUTH_ALREADY_REVERSED  - TRANSACTION_ALREADY_SETTLED  - INVALID_AMOUNT  - MISSING_AUTH  - TRANSACTION_ALREADY_REVERSED_OR_SETTLED </value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsReversalsPost400Response" /> class.
        /// </summary>
        /// <param name="SubmitTimeUtc">Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. .</param>
        /// <param name="Status">The status of the submitted transaction.  Possible values:  - INVALID_REQUEST .</param>
        /// <param name="Reason">The reason of the status.  Possible values:  - MISSING_FIELD  - INVALID_DATA  - DUPLICATE_REQUEST  - INVALID_MERCHANT_CONFIGURATION  - PROCESSOR_UNAVAILABLE  - AUTH_ALREADY_REVERSED  - TRANSACTION_ALREADY_SETTLED  - INVALID_AMOUNT  - MISSING_AUTH  - TRANSACTION_ALREADY_REVERSED_OR_SETTLED .</param>
        /// <param name="Message">The detail message related to the status and reason listed above..</param>
        /// <param name="Details">Details.</param>
        public PtsV2PaymentsReversalsPost400Response(string SubmitTimeUtc = default(string), StatusEnum? Status = default(StatusEnum?), ReasonEnum? Reason = default(ReasonEnum?), string Message = default(string), List<PtsV2PaymentsPost201ResponseErrorInformationDetails> Details = default(List<PtsV2PaymentsPost201ResponseErrorInformationDetails>))
        {
            this.SubmitTimeUtc = SubmitTimeUtc;
            this.Status = Status;
            this.Reason = Reason;
            this.Message = Message;
            this.Details = Details;
        }
        
        /// <summary>
        /// Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. 
        /// </summary>
        /// <value>Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. </value>
        [DataMember(Name="submitTimeUtc", EmitDefaultValue=false)]
        public string SubmitTimeUtc { get; set; }



        /// <summary>
        /// The detail message related to the status and reason listed above.
        /// </summary>
        /// <value>The detail message related to the status and reason listed above.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<PtsV2PaymentsPost201ResponseErrorInformationDetails> Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsReversalsPost400Response {\n");
            sb.Append("  SubmitTimeUtc: ").Append(SubmitTimeUtc).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsReversalsPost400Response);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsReversalsPost400Response instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsReversalsPost400Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsReversalsPost400Response other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SubmitTimeUtc == other.SubmitTimeUtc ||
                    this.SubmitTimeUtc != null &&
                    this.SubmitTimeUtc.Equals(other.SubmitTimeUtc)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(other.Details)
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
                if (this.SubmitTimeUtc != null)
                    hash = hash * 59 + this.SubmitTimeUtc.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
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
