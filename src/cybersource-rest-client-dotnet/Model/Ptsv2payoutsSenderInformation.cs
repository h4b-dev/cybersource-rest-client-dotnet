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
    /// Ptsv2payoutsSenderInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv2payoutsSenderInformation :  IEquatable<Ptsv2payoutsSenderInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2payoutsSenderInformation" /> class.
        /// </summary>
        /// <param name="ReferenceNumber">Reference number generated by you that uniquely identifies the sender..</param>
        /// <param name="Account">Account.</param>
        /// <param name="FirstName">First name of sender (Optional). * CTV (14) * Paymentech (30) .</param>
        /// <param name="MiddleInitial">Recipient middle initial (Optional). .</param>
        /// <param name="LastName">Recipient last name (Optional). * CTV (14) * Paymentech (30) .</param>
        /// <param name="Name">Name of sender.  **Funds Disbursement**  This value is the name of the originator sending the funds disbursement. * CTV, Paymentech (30) .</param>
        /// <param name="Address1">Street address of sender.  **Funds Disbursement**  This value is the address of the originator sending the funds disbursement. .</param>
        /// <param name="Locality">City of sender.  **Funds Disbursement**  This value is the city of the originator sending the funds disbursement. .</param>
        /// <param name="AdministrativeArea">Sender’s state. Use the State, Province, and Territory Codes for the United States and Canada. .</param>
        /// <param name="CountryCode">Country of sender. Use the ISO Standard Country Codes. * CTV (3) .</param>
        /// <param name="PostalCode">Sender’s postal code. Required only for FDCCompass..</param>
        /// <param name="PhoneNumber">Sender’s phone number. Required only for FDCCompass..</param>
        /// <param name="DateOfBirth">Sender’s date of birth in YYYYMMDD format. Required only for FDCCompass..</param>
        /// <param name="VatRegistrationNumber">Customer&#39;s government-assigned tax identification number. .</param>
        public Ptsv2payoutsSenderInformation(string ReferenceNumber = default(string), Ptsv2payoutsSenderInformationAccount Account = default(Ptsv2payoutsSenderInformationAccount), string FirstName = default(string), string MiddleInitial = default(string), string LastName = default(string), string Name = default(string), string Address1 = default(string), string Locality = default(string), string AdministrativeArea = default(string), string CountryCode = default(string), string PostalCode = default(string), string PhoneNumber = default(string), string DateOfBirth = default(string), string VatRegistrationNumber = default(string))
        {
            this.ReferenceNumber = ReferenceNumber;
            this.Account = Account;
            this.FirstName = FirstName;
            this.MiddleInitial = MiddleInitial;
            this.LastName = LastName;
            this.Name = Name;
            this.Address1 = Address1;
            this.Locality = Locality;
            this.AdministrativeArea = AdministrativeArea;
            this.CountryCode = CountryCode;
            this.PostalCode = PostalCode;
            this.PhoneNumber = PhoneNumber;
            this.DateOfBirth = DateOfBirth;
            this.VatRegistrationNumber = VatRegistrationNumber;
        }
        
        /// <summary>
        /// Reference number generated by you that uniquely identifies the sender.
        /// </summary>
        /// <value>Reference number generated by you that uniquely identifies the sender.</value>
        [DataMember(Name="referenceNumber", EmitDefaultValue=false)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public Ptsv2payoutsSenderInformationAccount Account { get; set; }

        /// <summary>
        /// First name of sender (Optional). * CTV (14) * Paymentech (30) 
        /// </summary>
        /// <value>First name of sender (Optional). * CTV (14) * Paymentech (30) </value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Recipient middle initial (Optional). 
        /// </summary>
        /// <value>Recipient middle initial (Optional). </value>
        [DataMember(Name="middleInitial", EmitDefaultValue=false)]
        public string MiddleInitial { get; set; }

        /// <summary>
        /// Recipient last name (Optional). * CTV (14) * Paymentech (30) 
        /// </summary>
        /// <value>Recipient last name (Optional). * CTV (14) * Paymentech (30) </value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Name of sender.  **Funds Disbursement**  This value is the name of the originator sending the funds disbursement. * CTV, Paymentech (30) 
        /// </summary>
        /// <value>Name of sender.  **Funds Disbursement**  This value is the name of the originator sending the funds disbursement. * CTV, Paymentech (30) </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Street address of sender.  **Funds Disbursement**  This value is the address of the originator sending the funds disbursement. 
        /// </summary>
        /// <value>Street address of sender.  **Funds Disbursement**  This value is the address of the originator sending the funds disbursement. </value>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// City of sender.  **Funds Disbursement**  This value is the city of the originator sending the funds disbursement. 
        /// </summary>
        /// <value>City of sender.  **Funds Disbursement**  This value is the city of the originator sending the funds disbursement. </value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// Sender’s state. Use the State, Province, and Territory Codes for the United States and Canada. 
        /// </summary>
        /// <value>Sender’s state. Use the State, Province, and Territory Codes for the United States and Canada. </value>
        [DataMember(Name="administrativeArea", EmitDefaultValue=false)]
        public string AdministrativeArea { get; set; }

        /// <summary>
        /// Country of sender. Use the ISO Standard Country Codes. * CTV (3) 
        /// </summary>
        /// <value>Country of sender. Use the ISO Standard Country Codes. * CTV (3) </value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Sender’s postal code. Required only for FDCCompass.
        /// </summary>
        /// <value>Sender’s postal code. Required only for FDCCompass.</value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Sender’s phone number. Required only for FDCCompass.
        /// </summary>
        /// <value>Sender’s phone number. Required only for FDCCompass.</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Sender’s date of birth in YYYYMMDD format. Required only for FDCCompass.
        /// </summary>
        /// <value>Sender’s date of birth in YYYYMMDD format. Required only for FDCCompass.</value>
        [DataMember(Name="dateOfBirth", EmitDefaultValue=false)]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Customer&#39;s government-assigned tax identification number. 
        /// </summary>
        /// <value>Customer&#39;s government-assigned tax identification number. </value>
        [DataMember(Name="vatRegistrationNumber", EmitDefaultValue=false)]
        public string VatRegistrationNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2payoutsSenderInformation {\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleInitial: ").Append(MiddleInitial).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  AdministrativeArea: ").Append(AdministrativeArea).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  VatRegistrationNumber: ").Append(VatRegistrationNumber).Append("\n");
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
            return this.Equals(obj as Ptsv2payoutsSenderInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2payoutsSenderInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2payoutsSenderInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2payoutsSenderInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReferenceNumber == other.ReferenceNumber ||
                    this.ReferenceNumber != null &&
                    this.ReferenceNumber.Equals(other.ReferenceNumber)
                ) && 
                (
                    this.Account == other.Account ||
                    this.Account != null &&
                    this.Account.Equals(other.Account)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.MiddleInitial == other.MiddleInitial ||
                    this.MiddleInitial != null &&
                    this.MiddleInitial.Equals(other.MiddleInitial)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Address1 == other.Address1 ||
                    this.Address1 != null &&
                    this.Address1.Equals(other.Address1)
                ) && 
                (
                    this.Locality == other.Locality ||
                    this.Locality != null &&
                    this.Locality.Equals(other.Locality)
                ) && 
                (
                    this.AdministrativeArea == other.AdministrativeArea ||
                    this.AdministrativeArea != null &&
                    this.AdministrativeArea.Equals(other.AdministrativeArea)
                ) && 
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.DateOfBirth == other.DateOfBirth ||
                    this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(other.DateOfBirth)
                ) && 
                (
                    this.VatRegistrationNumber == other.VatRegistrationNumber ||
                    this.VatRegistrationNumber != null &&
                    this.VatRegistrationNumber.Equals(other.VatRegistrationNumber)
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
                if (this.ReferenceNumber != null)
                    hash = hash * 59 + this.ReferenceNumber.GetHashCode();
                if (this.Account != null)
                    hash = hash * 59 + this.Account.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.MiddleInitial != null)
                    hash = hash * 59 + this.MiddleInitial.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Address1 != null)
                    hash = hash * 59 + this.Address1.GetHashCode();
                if (this.Locality != null)
                    hash = hash * 59 + this.Locality.GetHashCode();
                if (this.AdministrativeArea != null)
                    hash = hash * 59 + this.AdministrativeArea.GetHashCode();
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.DateOfBirth != null)
                    hash = hash * 59 + this.DateOfBirth.GetHashCode();
                if (this.VatRegistrationNumber != null)
                    hash = hash * 59 + this.VatRegistrationNumber.GetHashCode();
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
            // ReferenceNumber (string) maxLength
            if(this.ReferenceNumber != null && this.ReferenceNumber.Length > 19)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReferenceNumber, length must be less than 19.", new [] { "ReferenceNumber" });
            }

            // FirstName (string) maxLength
            if(this.FirstName != null && this.FirstName.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 35.", new [] { "FirstName" });
            }

            // MiddleInitial (string) maxLength
            if(this.MiddleInitial != null && this.MiddleInitial.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MiddleInitial, length must be less than 1.", new [] { "MiddleInitial" });
            }

            // LastName (string) maxLength
            if(this.LastName != null && this.LastName.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be less than 35.", new [] { "LastName" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 24)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 24.", new [] { "Name" });
            }

            // Address1 (string) maxLength
            if(this.Address1 != null && this.Address1.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address1, length must be less than 50.", new [] { "Address1" });
            }

            // Locality (string) maxLength
            if(this.Locality != null && this.Locality.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Locality, length must be less than 25.", new [] { "Locality" });
            }

            // AdministrativeArea (string) maxLength
            if(this.AdministrativeArea != null && this.AdministrativeArea.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AdministrativeArea, length must be less than 2.", new [] { "AdministrativeArea" });
            }

            // CountryCode (string) maxLength
            if(this.CountryCode != null && this.CountryCode.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CountryCode, length must be less than 2.", new [] { "CountryCode" });
            }

            // PostalCode (string) maxLength
            if(this.PostalCode != null && this.PostalCode.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than 10.", new [] { "PostalCode" });
            }

            // PhoneNumber (string) maxLength
            if(this.PhoneNumber != null && this.PhoneNumber.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PhoneNumber, length must be less than 20.", new [] { "PhoneNumber" });
            }

            // DateOfBirth (string) maxLength
            if(this.DateOfBirth != null && this.DateOfBirth.Length > 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DateOfBirth, length must be less than 8.", new [] { "DateOfBirth" });
            }

            // DateOfBirth (string) minLength
            if(this.DateOfBirth != null && this.DateOfBirth.Length < 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DateOfBirth, length must be greater than 8.", new [] { "DateOfBirth" });
            }

            // VatRegistrationNumber (string) maxLength
            if(this.VatRegistrationNumber != null && this.VatRegistrationNumber.Length > 13)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VatRegistrationNumber, length must be less than 13.", new [] { "VatRegistrationNumber" });
            }

            yield break;
        }
    }

}
