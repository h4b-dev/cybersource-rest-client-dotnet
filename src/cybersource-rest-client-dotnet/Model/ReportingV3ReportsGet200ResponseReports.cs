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
    /// Report Search Result Bean
    /// </summary>
    [DataContract]
    public partial class ReportingV3ReportsGet200ResponseReports :  IEquatable<ReportingV3ReportsGet200ResponseReports>, IValidatableObject
    {
        /// <summary>
        /// Format of the report to get generated
        /// </summary>
        /// <value>Format of the report to get generated</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReportMimeTypeEnum
        {
            
            /// <summary>
            /// Enum ApplicationXml for "application/xml"
            /// </summary>
            [EnumMember(Value = "application/xml")]
            ApplicationXml,
            
            /// <summary>
            /// Enum TextCsv for "text/csv"
            /// </summary>
            [EnumMember(Value = "text/csv")]
            TextCsv
        }

        /// <summary>
        /// Frequency of the report to get generated
        /// </summary>
        /// <value>Frequency of the report to get generated</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReportFrequencyEnum
        {
            
            /// <summary>
            /// Enum DAILY for "DAILY"
            /// </summary>
            [EnumMember(Value = "DAILY")]
            DAILY,
            
            /// <summary>
            /// Enum WEEKLY for "WEEKLY"
            /// </summary>
            [EnumMember(Value = "WEEKLY")]
            WEEKLY,
            
            /// <summary>
            /// Enum MONTHLY for "MONTHLY"
            /// </summary>
            [EnumMember(Value = "MONTHLY")]
            MONTHLY,
            
            /// <summary>
            /// Enum ADHOC for "ADHOC"
            /// </summary>
            [EnumMember(Value = "ADHOC")]
            ADHOC
        }

        /// <summary>
        /// Status of the report
        /// </summary>
        /// <value>Status of the report</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum COMPLETED for "COMPLETED"
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            COMPLETED,
            
            /// <summary>
            /// Enum PENDING for "PENDING"
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING,
            
            /// <summary>
            /// Enum QUEUED for "QUEUED"
            /// </summary>
            [EnumMember(Value = "QUEUED")]
            QUEUED,
            
            /// <summary>
            /// Enum RUNNING for "RUNNING"
            /// </summary>
            [EnumMember(Value = "RUNNING")]
            RUNNING,
            
            /// <summary>
            /// Enum ERROR for "ERROR"
            /// </summary>
            [EnumMember(Value = "ERROR")]
            ERROR,
            
            /// <summary>
            /// Enum NODATA for "NO_DATA"
            /// </summary>
            [EnumMember(Value = "NO_DATA")]
            NODATA
        }

        /// <summary>
        /// Format of the report to get generated
        /// </summary>
        /// <value>Format of the report to get generated</value>
        [DataMember(Name="reportMimeType", EmitDefaultValue=false)]
        public ReportMimeTypeEnum? ReportMimeType { get; set; }
        /// <summary>
        /// Frequency of the report to get generated
        /// </summary>
        /// <value>Frequency of the report to get generated</value>
        [DataMember(Name="reportFrequency", EmitDefaultValue=false)]
        public ReportFrequencyEnum? ReportFrequency { get; set; }
        /// <summary>
        /// Status of the report
        /// </summary>
        /// <value>Status of the report</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportingV3ReportsGet200ResponseReports" /> class.
        /// </summary>
        /// <param name="ReportDefinitionId">Unique Report Identifier of each report type.</param>
        /// <param name="ReportName">Name of the report specified by merchant while creating the report.</param>
        /// <param name="ReportMimeType">Format of the report to get generated.</param>
        /// <param name="ReportFrequency">Frequency of the report to get generated.</param>
        /// <param name="Status">Status of the report.</param>
        /// <param name="ReportStartTime">Specifies the report start time in ISO 8601 format.</param>
        /// <param name="ReportEndTime">Specifies the report end time in ISO 8601 format.</param>
        /// <param name="Timezone">Time Zone.</param>
        /// <param name="ReportId">Unique identifier generated for every reports.</param>
        /// <param name="OrganizationId">CyberSource Merchant Id.</param>
        /// <param name="QueuedTime">Specifies the time of the report in queued  in ISO 8601 format.</param>
        /// <param name="ReportGeneratingTime">Specifies the time of the report started to generate  in ISO 8601 format.</param>
        /// <param name="ReportCompletedTime">Specifies the time of the report completed the generation  in ISO 8601 format.</param>
        /// <param name="SubscriptionType">Specifies whether the subscription created is either Custom, Standard or Classic .</param>
        /// <param name="GroupId">Id for selected group..</param>
        public ReportingV3ReportsGet200ResponseReports(string ReportDefinitionId = default(string), string ReportName = default(string), ReportMimeTypeEnum? ReportMimeType = default(ReportMimeTypeEnum?), ReportFrequencyEnum? ReportFrequency = default(ReportFrequencyEnum?), StatusEnum? Status = default(StatusEnum?), DateTime? ReportStartTime = default(DateTime?), DateTime? ReportEndTime = default(DateTime?), string Timezone = default(string), string ReportId = default(string), string OrganizationId = default(string), DateTime? QueuedTime = default(DateTime?), DateTime? ReportGeneratingTime = default(DateTime?), DateTime? ReportCompletedTime = default(DateTime?), string SubscriptionType = default(string), string GroupId = default(string))
        {
            this.ReportDefinitionId = ReportDefinitionId;
            this.ReportName = ReportName;
            this.ReportMimeType = ReportMimeType;
            this.ReportFrequency = ReportFrequency;
            this.Status = Status;
            this.ReportStartTime = ReportStartTime;
            this.ReportEndTime = ReportEndTime;
            this.Timezone = Timezone;
            this.ReportId = ReportId;
            this.OrganizationId = OrganizationId;
            this.QueuedTime = QueuedTime;
            this.ReportGeneratingTime = ReportGeneratingTime;
            this.ReportCompletedTime = ReportCompletedTime;
            this.SubscriptionType = SubscriptionType;
            this.GroupId = GroupId;
        }
        
        /// <summary>
        /// Unique Report Identifier of each report type
        /// </summary>
        /// <value>Unique Report Identifier of each report type</value>
        [DataMember(Name="reportDefinitionId", EmitDefaultValue=false)]
        public string ReportDefinitionId { get; set; }

        /// <summary>
        /// Name of the report specified by merchant while creating the report
        /// </summary>
        /// <value>Name of the report specified by merchant while creating the report</value>
        [DataMember(Name="reportName", EmitDefaultValue=false)]
        public string ReportName { get; set; }




        /// <summary>
        /// Specifies the report start time in ISO 8601 format
        /// </summary>
        /// <value>Specifies the report start time in ISO 8601 format</value>
        [DataMember(Name="reportStartTime", EmitDefaultValue=false)]
        public DateTime? ReportStartTime { get; set; }

        /// <summary>
        /// Specifies the report end time in ISO 8601 format
        /// </summary>
        /// <value>Specifies the report end time in ISO 8601 format</value>
        [DataMember(Name="reportEndTime", EmitDefaultValue=false)]
        public DateTime? ReportEndTime { get; set; }

        /// <summary>
        /// Time Zone
        /// </summary>
        /// <value>Time Zone</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Unique identifier generated for every reports
        /// </summary>
        /// <value>Unique identifier generated for every reports</value>
        [DataMember(Name="reportId", EmitDefaultValue=false)]
        public string ReportId { get; set; }

        /// <summary>
        /// CyberSource Merchant Id
        /// </summary>
        /// <value>CyberSource Merchant Id</value>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Specifies the time of the report in queued  in ISO 8601 format
        /// </summary>
        /// <value>Specifies the time of the report in queued  in ISO 8601 format</value>
        [DataMember(Name="queuedTime", EmitDefaultValue=false)]
        public DateTime? QueuedTime { get; set; }

        /// <summary>
        /// Specifies the time of the report started to generate  in ISO 8601 format
        /// </summary>
        /// <value>Specifies the time of the report started to generate  in ISO 8601 format</value>
        [DataMember(Name="reportGeneratingTime", EmitDefaultValue=false)]
        public DateTime? ReportGeneratingTime { get; set; }

        /// <summary>
        /// Specifies the time of the report completed the generation  in ISO 8601 format
        /// </summary>
        /// <value>Specifies the time of the report completed the generation  in ISO 8601 format</value>
        [DataMember(Name="reportCompletedTime", EmitDefaultValue=false)]
        public DateTime? ReportCompletedTime { get; set; }

        /// <summary>
        /// Specifies whether the subscription created is either Custom, Standard or Classic 
        /// </summary>
        /// <value>Specifies whether the subscription created is either Custom, Standard or Classic </value>
        [DataMember(Name="subscriptionType", EmitDefaultValue=false)]
        public string SubscriptionType { get; set; }

        /// <summary>
        /// Id for selected group.
        /// </summary>
        /// <value>Id for selected group.</value>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportingV3ReportsGet200ResponseReports {\n");
            sb.Append("  ReportDefinitionId: ").Append(ReportDefinitionId).Append("\n");
            sb.Append("  ReportName: ").Append(ReportName).Append("\n");
            sb.Append("  ReportMimeType: ").Append(ReportMimeType).Append("\n");
            sb.Append("  ReportFrequency: ").Append(ReportFrequency).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ReportStartTime: ").Append(ReportStartTime).Append("\n");
            sb.Append("  ReportEndTime: ").Append(ReportEndTime).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  ReportId: ").Append(ReportId).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  QueuedTime: ").Append(QueuedTime).Append("\n");
            sb.Append("  ReportGeneratingTime: ").Append(ReportGeneratingTime).Append("\n");
            sb.Append("  ReportCompletedTime: ").Append(ReportCompletedTime).Append("\n");
            sb.Append("  SubscriptionType: ").Append(SubscriptionType).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
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
            return this.Equals(obj as ReportingV3ReportsGet200ResponseReports);
        }

        /// <summary>
        /// Returns true if ReportingV3ReportsGet200ResponseReports instances are equal
        /// </summary>
        /// <param name="other">Instance of ReportingV3ReportsGet200ResponseReports to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportingV3ReportsGet200ResponseReports other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReportDefinitionId == other.ReportDefinitionId ||
                    this.ReportDefinitionId != null &&
                    this.ReportDefinitionId.Equals(other.ReportDefinitionId)
                ) && 
                (
                    this.ReportName == other.ReportName ||
                    this.ReportName != null &&
                    this.ReportName.Equals(other.ReportName)
                ) && 
                (
                    this.ReportMimeType == other.ReportMimeType ||
                    this.ReportMimeType != null &&
                    this.ReportMimeType.Equals(other.ReportMimeType)
                ) && 
                (
                    this.ReportFrequency == other.ReportFrequency ||
                    this.ReportFrequency != null &&
                    this.ReportFrequency.Equals(other.ReportFrequency)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.ReportStartTime == other.ReportStartTime ||
                    this.ReportStartTime != null &&
                    this.ReportStartTime.Equals(other.ReportStartTime)
                ) && 
                (
                    this.ReportEndTime == other.ReportEndTime ||
                    this.ReportEndTime != null &&
                    this.ReportEndTime.Equals(other.ReportEndTime)
                ) && 
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
                ) && 
                (
                    this.ReportId == other.ReportId ||
                    this.ReportId != null &&
                    this.ReportId.Equals(other.ReportId)
                ) && 
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) && 
                (
                    this.QueuedTime == other.QueuedTime ||
                    this.QueuedTime != null &&
                    this.QueuedTime.Equals(other.QueuedTime)
                ) && 
                (
                    this.ReportGeneratingTime == other.ReportGeneratingTime ||
                    this.ReportGeneratingTime != null &&
                    this.ReportGeneratingTime.Equals(other.ReportGeneratingTime)
                ) && 
                (
                    this.ReportCompletedTime == other.ReportCompletedTime ||
                    this.ReportCompletedTime != null &&
                    this.ReportCompletedTime.Equals(other.ReportCompletedTime)
                ) && 
                (
                    this.SubscriptionType == other.SubscriptionType ||
                    this.SubscriptionType != null &&
                    this.SubscriptionType.Equals(other.SubscriptionType)
                ) && 
                (
                    this.GroupId == other.GroupId ||
                    this.GroupId != null &&
                    this.GroupId.Equals(other.GroupId)
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
                if (this.ReportDefinitionId != null)
                    hash = hash * 59 + this.ReportDefinitionId.GetHashCode();
                if (this.ReportName != null)
                    hash = hash * 59 + this.ReportName.GetHashCode();
                if (this.ReportMimeType != null)
                    hash = hash * 59 + this.ReportMimeType.GetHashCode();
                if (this.ReportFrequency != null)
                    hash = hash * 59 + this.ReportFrequency.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.ReportStartTime != null)
                    hash = hash * 59 + this.ReportStartTime.GetHashCode();
                if (this.ReportEndTime != null)
                    hash = hash * 59 + this.ReportEndTime.GetHashCode();
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                if (this.ReportId != null)
                    hash = hash * 59 + this.ReportId.GetHashCode();
                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();
                if (this.QueuedTime != null)
                    hash = hash * 59 + this.QueuedTime.GetHashCode();
                if (this.ReportGeneratingTime != null)
                    hash = hash * 59 + this.ReportGeneratingTime.GetHashCode();
                if (this.ReportCompletedTime != null)
                    hash = hash * 59 + this.ReportCompletedTime.GetHashCode();
                if (this.SubscriptionType != null)
                    hash = hash * 59 + this.SubscriptionType.GetHashCode();
                if (this.GroupId != null)
                    hash = hash * 59 + this.GroupId.GetHashCode();
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
