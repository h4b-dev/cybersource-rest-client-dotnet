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
    /// UmsV1UsersGet200ResponseAccountInformation
    /// </summary>
    [DataContract]
    public partial class UmsV1UsersGet200ResponseAccountInformation :  IEquatable<UmsV1UsersGet200ResponseAccountInformation>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "inactive"
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive,
            
            /// <summary>
            /// Enum Locked for "locked"
            /// </summary>
            [EnumMember(Value = "locked")]
            Locked,
            
            /// <summary>
            /// Enum Disabled for "disabled"
            /// </summary>
            [EnumMember(Value = "disabled")]
            Disabled,
            
            /// <summary>
            /// Enum Forgotpassword for "forgotpassword"
            /// </summary>
            [EnumMember(Value = "forgotpassword")]
            Forgotpassword,
            
            /// <summary>
            /// Enum Deleted for "deleted"
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UmsV1UsersGet200ResponseAccountInformation" /> class.
        /// </summary>
        /// <param name="UserName">UserName.</param>
        /// <param name="RoleId">RoleId.</param>
        /// <param name="Permissions">Permissions.</param>
        /// <param name="Status">Status.</param>
        /// <param name="CreatedTime">CreatedTime.</param>
        /// <param name="LastAccessTime">LastAccessTime.</param>
        /// <param name="LanguagePreference">LanguagePreference.</param>
        /// <param name="Timezone">Timezone.</param>
        public UmsV1UsersGet200ResponseAccountInformation(string UserName = default(string), string RoleId = default(string), List<string> Permissions = default(List<string>), StatusEnum? Status = default(StatusEnum?), DateTime? CreatedTime = default(DateTime?), DateTime? LastAccessTime = default(DateTime?), string LanguagePreference = default(string), string Timezone = default(string))
        {
            this.UserName = UserName;
            this.RoleId = RoleId;
            this.Permissions = Permissions;
            this.Status = Status;
            this.CreatedTime = CreatedTime;
            this.LastAccessTime = LastAccessTime;
            this.LanguagePreference = LanguagePreference;
            this.Timezone = Timezone;
        }
        
        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets RoleId
        /// </summary>
        [DataMember(Name="roleId", EmitDefaultValue=false)]
        public string RoleId { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public List<string> Permissions { get; set; }


        /// <summary>
        /// Gets or Sets CreatedTime
        /// </summary>
        [DataMember(Name="createdTime", EmitDefaultValue=false)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Gets or Sets LastAccessTime
        /// </summary>
        [DataMember(Name="lastAccessTime", EmitDefaultValue=false)]
        public DateTime? LastAccessTime { get; set; }

        /// <summary>
        /// Gets or Sets LanguagePreference
        /// </summary>
        [DataMember(Name="languagePreference", EmitDefaultValue=false)]
        public string LanguagePreference { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UmsV1UsersGet200ResponseAccountInformation {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  LastAccessTime: ").Append(LastAccessTime).Append("\n");
            sb.Append("  LanguagePreference: ").Append(LanguagePreference).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
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
            return this.Equals(obj as UmsV1UsersGet200ResponseAccountInformation);
        }

        /// <summary>
        /// Returns true if UmsV1UsersGet200ResponseAccountInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of UmsV1UsersGet200ResponseAccountInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UmsV1UsersGet200ResponseAccountInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) && 
                (
                    this.RoleId == other.RoleId ||
                    this.RoleId != null &&
                    this.RoleId.Equals(other.RoleId)
                ) && 
                (
                    this.Permissions == other.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.SequenceEqual(other.Permissions)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.CreatedTime == other.CreatedTime ||
                    this.CreatedTime != null &&
                    this.CreatedTime.Equals(other.CreatedTime)
                ) && 
                (
                    this.LastAccessTime == other.LastAccessTime ||
                    this.LastAccessTime != null &&
                    this.LastAccessTime.Equals(other.LastAccessTime)
                ) && 
                (
                    this.LanguagePreference == other.LanguagePreference ||
                    this.LanguagePreference != null &&
                    this.LanguagePreference.Equals(other.LanguagePreference)
                ) && 
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
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
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                if (this.RoleId != null)
                    hash = hash * 59 + this.RoleId.GetHashCode();
                if (this.Permissions != null)
                    hash = hash * 59 + this.Permissions.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.CreatedTime != null)
                    hash = hash * 59 + this.CreatedTime.GetHashCode();
                if (this.LastAccessTime != null)
                    hash = hash * 59 + this.LastAccessTime.GetHashCode();
                if (this.LanguagePreference != null)
                    hash = hash * 59 + this.LanguagePreference.GetHashCode();
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
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
