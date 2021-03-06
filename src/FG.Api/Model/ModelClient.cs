#region Copyright (c) 2000-2020 Sultan CRM BV

// ===========================================================
// 
// MIT License
// 
// Copyright (c) 2020 Sultan CRM B.V. / Jean Paul Teunisse
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// ===========================================================

#endregion

#region usings

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

#endregion

namespace FG.Api.Model {
    /// <summary>
    /// ModelClient
    /// </summary>
    [DataContract]
    public partial class ModelClient : IEquatable<ModelClient>, IValidatableObject {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelClient" /> class.
        /// </summary>
        /// <param name="addresses">addresses.</param>
        /// <param name="beconNumber">beconNumber.</param>
        /// <param name="birthDate">birthDate.</param>
        /// <param name="chamberOfCommerceNumber">chamberOfCommerceNumber.</param>
        /// <param name="clientGroupIsVip">clientGroupIsVip.</param>
        /// <param name="clientGroupName">clientGroupName.</param>
        /// <param name="dateStartCustomerRelation">dateStartCustomerRelation.</param>
        /// <param name="deceasedDate">deceasedDate.</param>
        /// <param name="contactPerson">contactPerson.</param>
        /// <param name="emailAddresses">emailAddresses.</param>
        /// <param name="id">id.</param>
        /// <param name="identificationNumber">identificationNumber (required).</param>
        /// <param name="initials">initials.</param>
        /// <param name="name">name (required).</param>
        /// <param name="number">number.</param>
        /// <param name="phoneNumbers">phoneNumbers.</param>
        /// <param name="prefix">prefix.</param>
        /// <param name="salutation">salutation.</param>
        /// <param name="vatNumber">vatNumber.</param>
        /// <param name="surname">surname.</param>
        /// <param name="taxConsultant">taxConsultant.</param>
        /// <param name="type">type.</param>
        /// <param name="typeOfBusinessEntity">typeOfBusinessEntity.</param>
        public ModelClient(List<ClientAddresses> addresses = default(List<ClientAddresses>), int? beconNumber = default(int?),
            DateTime? birthDate = default(DateTime?), string chamberOfCommerceNumber = default(string), bool? clientGroupIsVip = default(bool?),
            string clientGroupName = default(string), DateTime? dateStartCustomerRelation = default(DateTime?), DateTime? deceasedDate = default(DateTime?),
            ClientContactPerson contactPerson = default(ClientContactPerson), List<string> emailAddresses = default(List<string>), int? id = default(int?),
            string identificationNumber = default(string), string initials = default(string), string name = default(string), string number = default(string),
            List<string> phoneNumbers = default(List<string>), string prefix = default(string), int? salutation = default(int?),
            string vatNumber = default(string), string surname = default(string), string taxConsultant = default(string), int? type = default(int?),
            int? typeOfBusinessEntity = default(int?)) {
            // to ensure "identificationNumber" is required (not null)
            if (identificationNumber == null) {
                throw new InvalidDataException("identificationNumber is a required property for ModelClient and cannot be null");
            }
            else {
                this.IdentificationNumber = identificationNumber;
            }

            // to ensure "name" is required (not null)
            if (name == null) {
                throw new InvalidDataException("name is a required property for ModelClient and cannot be null");
            }
            else {
                this.Name = name;
            }

            this.Addresses = addresses;
            this.BeconNumber = beconNumber;
            this.BirthDate = birthDate;
            this.ChamberOfCommerceNumber = chamberOfCommerceNumber;
            this.ClientGroupIsVip = clientGroupIsVip;
            this.ClientGroupName = clientGroupName;
            this.DateStartCustomerRelation = dateStartCustomerRelation;
            this.DeceasedDate = deceasedDate;
            this.ContactPerson = contactPerson;
            this.EmailAddresses = emailAddresses;
            this.Id = id;
            this.Initials = initials;
            this.Number = number;
            this.PhoneNumbers = phoneNumbers;
            this.Prefix = prefix;
            this.Salutation = salutation;
            this.VatNumber = vatNumber;
            this.Surname = surname;
            this.TaxConsultant = taxConsultant;
            this.Type = type;
            this.TypeOfBusinessEntity = typeOfBusinessEntity;
        }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name = "Addresses", EmitDefaultValue = false)]
        public List<ClientAddresses> Addresses { get; set; }

        /// <summary>
        /// Gets or Sets BeconNumber
        /// </summary>
        [DataMember(Name = "BeconNumber", EmitDefaultValue = false)]
        public int? BeconNumber { get; set; }

        /// <summary>
        /// Gets or Sets BirthDate
        /// </summary>
        [DataMember(Name = "BirthDate", EmitDefaultValue = false)]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Gets or Sets ChamberOfCommerceNumber
        /// </summary>
        [DataMember(Name = "ChamberOfCommerceNumber", EmitDefaultValue = false)]
        public string ChamberOfCommerceNumber { get; set; }

        /// <summary>
        /// Gets or Sets ClientGroupIsVip
        /// </summary>
        [DataMember(Name = "ClientGroupIsVip", EmitDefaultValue = false)]
        public bool? ClientGroupIsVip { get; set; }

        /// <summary>
        /// Gets or Sets ClientGroupName
        /// </summary>
        [DataMember(Name = "ClientGroupName", EmitDefaultValue = false)]
        public string ClientGroupName { get; set; }

        /// <summary>
        /// Gets or Sets DateStartCustomerRelation
        /// </summary>
        [DataMember(Name = "DateStartCustomerRelation", EmitDefaultValue = false)]
        public DateTime? DateStartCustomerRelation { get; set; }

        /// <summary>
        /// Gets or Sets DeceasedDate
        /// </summary>
        [DataMember(Name = "DeceasedDate", EmitDefaultValue = false)]
        public DateTime? DeceasedDate { get; set; }

        /// <summary>
        /// Gets or Sets ContactPerson
        /// </summary>
        [DataMember(Name = "ContactPerson", EmitDefaultValue = false)]
        public ClientContactPerson ContactPerson { get; set; }

        /// <summary>
        /// Gets or Sets EmailAddresses
        /// </summary>
        [DataMember(Name = "EmailAddresses", EmitDefaultValue = false)]
        public List<string> EmailAddresses { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "Id", EmitDefaultValue = false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets IdentificationNumber
        /// </summary>
        [DataMember(Name = "IdentificationNumber", EmitDefaultValue = false)]
        public string IdentificationNumber { get; set; }

        /// <summary>
        /// Gets or Sets Initials
        /// </summary>
        [DataMember(Name = "Initials", EmitDefaultValue = false)]
        public string Initials { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "Number", EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumbers
        /// </summary>
        [DataMember(Name = "PhoneNumbers", EmitDefaultValue = false)]
        public List<string> PhoneNumbers { get; set; }

        /// <summary>
        /// Gets or Sets Prefix
        /// </summary>
        [DataMember(Name = "Prefix", EmitDefaultValue = false)]
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or Sets Salutation
        /// </summary>
        [DataMember(Name = "Salutation", EmitDefaultValue = false)]
        public int? Salutation { get; set; }

        /// <summary>
        /// Gets or Sets VatNumber
        /// </summary>
        [DataMember(Name = "VatNumber", EmitDefaultValue = false)]
        public string VatNumber { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name = "Surname", EmitDefaultValue = false)]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets TaxConsultant
        /// </summary>
        [DataMember(Name = "TaxConsultant", EmitDefaultValue = false)]
        public string TaxConsultant { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "Type", EmitDefaultValue = false)]
        public int? Type { get; set; }

        /// <summary>
        /// Gets or Sets TypeOfBusinessEntity
        /// </summary>
        [DataMember(Name = "TypeOfBusinessEntity", EmitDefaultValue = false)]
        public int? TypeOfBusinessEntity { get; set; }

        /// <summary>
        /// Returns true if ModelClient instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelClient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelClient input) {
            if (input == null)
                return false;

            return
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) &&
                (
                    this.BeconNumber == input.BeconNumber ||
                    (this.BeconNumber != null &&
                     this.BeconNumber.Equals(input.BeconNumber))
                ) &&
                (
                    this.BirthDate == input.BirthDate ||
                    (this.BirthDate != null &&
                     this.BirthDate.Equals(input.BirthDate))
                ) &&
                (
                    this.ChamberOfCommerceNumber == input.ChamberOfCommerceNumber ||
                    (this.ChamberOfCommerceNumber != null &&
                     this.ChamberOfCommerceNumber.Equals(input.ChamberOfCommerceNumber))
                ) &&
                (
                    this.ClientGroupIsVip == input.ClientGroupIsVip ||
                    (this.ClientGroupIsVip != null &&
                     this.ClientGroupIsVip.Equals(input.ClientGroupIsVip))
                ) &&
                (
                    this.ClientGroupName == input.ClientGroupName ||
                    (this.ClientGroupName != null &&
                     this.ClientGroupName.Equals(input.ClientGroupName))
                ) &&
                (
                    this.DateStartCustomerRelation == input.DateStartCustomerRelation ||
                    (this.DateStartCustomerRelation != null &&
                     this.DateStartCustomerRelation.Equals(input.DateStartCustomerRelation))
                ) &&
                (
                    this.DeceasedDate == input.DeceasedDate ||
                    (this.DeceasedDate != null &&
                     this.DeceasedDate.Equals(input.DeceasedDate))
                ) &&
                (
                    this.ContactPerson == input.ContactPerson ||
                    (this.ContactPerson != null &&
                     this.ContactPerson.Equals(input.ContactPerson))
                ) &&
                (
                    this.EmailAddresses == input.EmailAddresses ||
                    this.EmailAddresses != null &&
                    input.EmailAddresses != null &&
                    this.EmailAddresses.SequenceEqual(input.EmailAddresses)
                ) &&
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                     this.Id.Equals(input.Id))
                ) &&
                (
                    this.IdentificationNumber == input.IdentificationNumber ||
                    (this.IdentificationNumber != null &&
                     this.IdentificationNumber.Equals(input.IdentificationNumber))
                ) &&
                (
                    this.Initials == input.Initials ||
                    (this.Initials != null &&
                     this.Initials.Equals(input.Initials))
                ) &&
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                     this.Name.Equals(input.Name))
                ) &&
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                     this.Number.Equals(input.Number))
                ) &&
                (
                    this.PhoneNumbers == input.PhoneNumbers ||
                    this.PhoneNumbers != null &&
                    input.PhoneNumbers != null &&
                    this.PhoneNumbers.SequenceEqual(input.PhoneNumbers)
                ) &&
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                     this.Prefix.Equals(input.Prefix))
                ) &&
                (
                    this.Salutation == input.Salutation ||
                    (this.Salutation != null &&
                     this.Salutation.Equals(input.Salutation))
                ) &&
                (
                    this.VatNumber == input.VatNumber ||
                    (this.VatNumber != null &&
                     this.VatNumber.Equals(input.VatNumber))
                ) &&
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                     this.Surname.Equals(input.Surname))
                ) &&
                (
                    this.TaxConsultant == input.TaxConsultant ||
                    (this.TaxConsultant != null &&
                     this.TaxConsultant.Equals(input.TaxConsultant))
                ) &&
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                     this.Type.Equals(input.Type))
                ) &&
                (
                    this.TypeOfBusinessEntity == input.TypeOfBusinessEntity ||
                    (this.TypeOfBusinessEntity != null &&
                     this.TypeOfBusinessEntity.Equals(input.TypeOfBusinessEntity))
                );
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext) {
            yield break;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() {
            var sb = new StringBuilder();
            sb.Append("class ModelClient {\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  BeconNumber: ").Append(BeconNumber).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
            sb.Append("  ChamberOfCommerceNumber: ").Append(ChamberOfCommerceNumber).Append("\n");
            sb.Append("  ClientGroupIsVip: ").Append(ClientGroupIsVip).Append("\n");
            sb.Append("  ClientGroupName: ").Append(ClientGroupName).Append("\n");
            sb.Append("  DateStartCustomerRelation: ").Append(DateStartCustomerRelation).Append("\n");
            sb.Append("  DeceasedDate: ").Append(DeceasedDate).Append("\n");
            sb.Append("  ContactPerson: ").Append(ContactPerson).Append("\n");
            sb.Append("  EmailAddresses: ").Append(EmailAddresses).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdentificationNumber: ").Append(IdentificationNumber).Append("\n");
            sb.Append("  Initials: ").Append(Initials).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  Salutation: ").Append(Salutation).Append("\n");
            sb.Append("  VatNumber: ").Append(VatNumber).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  TaxConsultant: ").Append(TaxConsultant).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TypeOfBusinessEntity: ").Append(TypeOfBusinessEntity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson() {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input) {
            return this.Equals(input as ModelClient);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode() {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.BeconNumber != null)
                    hashCode = hashCode * 59 + this.BeconNumber.GetHashCode();
                if (this.BirthDate != null)
                    hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
                if (this.ChamberOfCommerceNumber != null)
                    hashCode = hashCode * 59 + this.ChamberOfCommerceNumber.GetHashCode();
                if (this.ClientGroupIsVip != null)
                    hashCode = hashCode * 59 + this.ClientGroupIsVip.GetHashCode();
                if (this.ClientGroupName != null)
                    hashCode = hashCode * 59 + this.ClientGroupName.GetHashCode();
                if (this.DateStartCustomerRelation != null)
                    hashCode = hashCode * 59 + this.DateStartCustomerRelation.GetHashCode();
                if (this.DeceasedDate != null)
                    hashCode = hashCode * 59 + this.DeceasedDate.GetHashCode();
                if (this.ContactPerson != null)
                    hashCode = hashCode * 59 + this.ContactPerson.GetHashCode();
                if (this.EmailAddresses != null)
                    hashCode = hashCode * 59 + this.EmailAddresses.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IdentificationNumber != null)
                    hashCode = hashCode * 59 + this.IdentificationNumber.GetHashCode();
                if (this.Initials != null)
                    hashCode = hashCode * 59 + this.Initials.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.PhoneNumbers != null)
                    hashCode = hashCode * 59 + this.PhoneNumbers.GetHashCode();
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.Salutation != null)
                    hashCode = hashCode * 59 + this.Salutation.GetHashCode();
                if (this.VatNumber != null)
                    hashCode = hashCode * 59 + this.VatNumber.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.TaxConsultant != null)
                    hashCode = hashCode * 59 + this.TaxConsultant.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TypeOfBusinessEntity != null)
                    hashCode = hashCode * 59 + this.TypeOfBusinessEntity.GetHashCode();
                return hashCode;
            }
        }
    }
}