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
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace CyberSource.Model
{
    /// <summary>
    /// PtsV2PaymentsReversalsPost201Response
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsReversalsPost201Response :  IEquatable<PtsV2PaymentsReversalsPost201Response>, IValidatableObject
    {
        /// <summary>
        /// The status of the submitted transaction.  Possible values:  - REVERSED 
        /// </summary>
        /// <value>The status of the submitted transaction.  Possible values:  - REVERSED </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum REVERSED for "REVERSED"
            /// </summary>
            [EnumMember(Value = "REVERSED")]
            REVERSED
        }

        /// <summary>
        /// The status of the submitted transaction.  Possible values:  - REVERSED 
        /// </summary>
        /// <value>The status of the submitted transaction.  Possible values:  - REVERSED </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsReversalsPost201Response" /> class.
        /// </summary>
        /// <param name="Links">Links.</param>
        /// <param name="Id">An unique identification number assigned by CyberSource to identify the submitted request..</param>
        /// <param name="SubmitTimeUtc">Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. .</param>
        /// <param name="Status">The status of the submitted transaction.  Possible values:  - REVERSED .</param>
        /// <param name="ReconciliationId">The reconciliation id for the submitted transaction. This value is not returned for all processors. .</param>
        /// <param name="ClientReferenceInformation">ClientReferenceInformation.</param>
        /// <param name="ReversalAmountDetails">ReversalAmountDetails.</param>
        /// <param name="ProcessorInformation">ProcessorInformation.</param>
        /// <param name="IssuerInformation">IssuerInformation.</param>
        /// <param name="AuthorizationInformation">AuthorizationInformation.</param>
        /// <param name="PointOfSaleInformation">PointOfSaleInformation.</param>
        public PtsV2PaymentsReversalsPost201Response(PtsV2PaymentsReversalsPost201ResponseLinks Links = default(PtsV2PaymentsReversalsPost201ResponseLinks), string Id = default(string), string SubmitTimeUtc = default(string), StatusEnum? Status = default(StatusEnum?), string ReconciliationId = default(string), PtsV2PaymentsPost201ResponseClientReferenceInformation ClientReferenceInformation = default(PtsV2PaymentsPost201ResponseClientReferenceInformation), PtsV2PaymentsReversalsPost201ResponseReversalAmountDetails ReversalAmountDetails = default(PtsV2PaymentsReversalsPost201ResponseReversalAmountDetails), PtsV2PaymentsReversalsPost201ResponseProcessorInformation ProcessorInformation = default(PtsV2PaymentsReversalsPost201ResponseProcessorInformation), PtsV2PaymentsReversalsPost201ResponseIssuerInformation IssuerInformation = default(PtsV2PaymentsReversalsPost201ResponseIssuerInformation), PtsV2PaymentsReversalsPost201ResponseAuthorizationInformation AuthorizationInformation = default(PtsV2PaymentsReversalsPost201ResponseAuthorizationInformation), Ptsv2paymentsidreversalsPointOfSaleInformation PointOfSaleInformation = default(Ptsv2paymentsidreversalsPointOfSaleInformation))
        {
            this.Links = Links;
            this.Id = Id;
            this.SubmitTimeUtc = SubmitTimeUtc;
            this.Status = Status;
            this.ReconciliationId = ReconciliationId;
            this.ClientReferenceInformation = ClientReferenceInformation;
            this.ReversalAmountDetails = ReversalAmountDetails;
            this.ProcessorInformation = ProcessorInformation;
            this.IssuerInformation = IssuerInformation;
            this.AuthorizationInformation = AuthorizationInformation;
            this.PointOfSaleInformation = PointOfSaleInformation;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public PtsV2PaymentsReversalsPost201ResponseLinks Links { get; set; }

        /// <summary>
        /// An unique identification number assigned by CyberSource to identify the submitted request.
        /// </summary>
        /// <value>An unique identification number assigned by CyberSource to identify the submitted request.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. 
        /// </summary>
        /// <value>Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. </value>
        [DataMember(Name="submitTimeUtc", EmitDefaultValue=false)]
        public string SubmitTimeUtc { get; set; }


        /// <summary>
        /// The reconciliation id for the submitted transaction. This value is not returned for all processors. 
        /// </summary>
        /// <value>The reconciliation id for the submitted transaction. This value is not returned for all processors. </value>
        [DataMember(Name="reconciliationId", EmitDefaultValue=false)]
        public string ReconciliationId { get; set; }

        /// <summary>
        /// Gets or Sets ClientReferenceInformation
        /// </summary>
        [DataMember(Name="clientReferenceInformation", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseClientReferenceInformation ClientReferenceInformation { get; set; }

        /// <summary>
        /// Gets or Sets ReversalAmountDetails
        /// </summary>
        [DataMember(Name="reversalAmountDetails", EmitDefaultValue=false)]
        public PtsV2PaymentsReversalsPost201ResponseReversalAmountDetails ReversalAmountDetails { get; set; }

        /// <summary>
        /// Gets or Sets ProcessorInformation
        /// </summary>
        [DataMember(Name="processorInformation", EmitDefaultValue=false)]
        public PtsV2PaymentsReversalsPost201ResponseProcessorInformation ProcessorInformation { get; set; }

        /// <summary>
        /// Gets or Sets IssuerInformation
        /// </summary>
        [DataMember(Name="issuerInformation", EmitDefaultValue=false)]
        public PtsV2PaymentsReversalsPost201ResponseIssuerInformation IssuerInformation { get; set; }

        /// <summary>
        /// Gets or Sets AuthorizationInformation
        /// </summary>
        [DataMember(Name="authorizationInformation", EmitDefaultValue=false)]
        public PtsV2PaymentsReversalsPost201ResponseAuthorizationInformation AuthorizationInformation { get; set; }

        /// <summary>
        /// Gets or Sets PointOfSaleInformation
        /// </summary>
        [DataMember(Name="pointOfSaleInformation", EmitDefaultValue=false)]
        public Ptsv2paymentsidreversalsPointOfSaleInformation PointOfSaleInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsReversalsPost201Response {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SubmitTimeUtc: ").Append(SubmitTimeUtc).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ReconciliationId: ").Append(ReconciliationId).Append("\n");
            sb.Append("  ClientReferenceInformation: ").Append(ClientReferenceInformation).Append("\n");
            sb.Append("  ReversalAmountDetails: ").Append(ReversalAmountDetails).Append("\n");
            sb.Append("  ProcessorInformation: ").Append(ProcessorInformation).Append("\n");
            sb.Append("  IssuerInformation: ").Append(IssuerInformation).Append("\n");
            sb.Append("  AuthorizationInformation: ").Append(AuthorizationInformation).Append("\n");
            sb.Append("  PointOfSaleInformation: ").Append(PointOfSaleInformation).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsReversalsPost201Response);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsReversalsPost201Response instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsReversalsPost201Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsReversalsPost201Response other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
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
                    this.ReconciliationId == other.ReconciliationId ||
                    this.ReconciliationId != null &&
                    this.ReconciliationId.Equals(other.ReconciliationId)
                ) && 
                (
                    this.ClientReferenceInformation == other.ClientReferenceInformation ||
                    this.ClientReferenceInformation != null &&
                    this.ClientReferenceInformation.Equals(other.ClientReferenceInformation)
                ) && 
                (
                    this.ReversalAmountDetails == other.ReversalAmountDetails ||
                    this.ReversalAmountDetails != null &&
                    this.ReversalAmountDetails.Equals(other.ReversalAmountDetails)
                ) && 
                (
                    this.ProcessorInformation == other.ProcessorInformation ||
                    this.ProcessorInformation != null &&
                    this.ProcessorInformation.Equals(other.ProcessorInformation)
                ) && 
                (
                    this.IssuerInformation == other.IssuerInformation ||
                    this.IssuerInformation != null &&
                    this.IssuerInformation.Equals(other.IssuerInformation)
                ) && 
                (
                    this.AuthorizationInformation == other.AuthorizationInformation ||
                    this.AuthorizationInformation != null &&
                    this.AuthorizationInformation.Equals(other.AuthorizationInformation)
                ) && 
                (
                    this.PointOfSaleInformation == other.PointOfSaleInformation ||
                    this.PointOfSaleInformation != null &&
                    this.PointOfSaleInformation.Equals(other.PointOfSaleInformation)
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
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.SubmitTimeUtc != null)
                    hash = hash * 59 + this.SubmitTimeUtc.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.ReconciliationId != null)
                    hash = hash * 59 + this.ReconciliationId.GetHashCode();
                if (this.ClientReferenceInformation != null)
                    hash = hash * 59 + this.ClientReferenceInformation.GetHashCode();
                if (this.ReversalAmountDetails != null)
                    hash = hash * 59 + this.ReversalAmountDetails.GetHashCode();
                if (this.ProcessorInformation != null)
                    hash = hash * 59 + this.ProcessorInformation.GetHashCode();
                if (this.IssuerInformation != null)
                    hash = hash * 59 + this.IssuerInformation.GetHashCode();
                if (this.AuthorizationInformation != null)
                    hash = hash * 59 + this.AuthorizationInformation.GetHashCode();
                if (this.PointOfSaleInformation != null)
                    hash = hash * 59 + this.PointOfSaleInformation.GetHashCode();
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
            // Id (string) maxLength
            if(this.Id != null && this.Id.Length > 26)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be less than 26.", new [] { "Id" });
            }

            // ReconciliationId (string) maxLength
            if(this.ReconciliationId != null && this.ReconciliationId.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReconciliationId, length must be less than 60.", new [] { "ReconciliationId" });
            }

            yield break;
        }
    }

}
