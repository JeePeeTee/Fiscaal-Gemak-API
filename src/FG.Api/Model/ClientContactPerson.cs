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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

#endregion

namespace FG.Api.Model {
    /// <summary>
    /// ClientContactPerson
    /// </summary>
    [DataContract]
    public partial class ClientContactPerson : IEquatable<ClientContactPerson>, IValidatableObject {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientContactPerson" /> class.
        /// </summary>
        /// <param name="email">email (required).</param>
        /// <param name="initials">initials (required).</param>
        /// <param name="prefix">prefix.</param>
        /// <param name="surname">surname (required).</param>
        /// <param name="telephoneNumber">telephoneNumber (required).</param>
        public ClientContactPerson(string email = default(string), string initials = default(string), string prefix = default(string),
            string surname = default(string), string telephoneNumber = default(string)) {
            // to ensure "email" is required (not null)
            if (email == null) {
                throw new InvalidDataException("email is a required property for ClientContactPerson and cannot be null");
            }
            else {
                this.Email = email;
            }

            // to ensure "initials" is required (not null)
            if (initials == null) {
                throw new InvalidDataException("initials is a required property for ClientContactPerson and cannot be null");
            }
            else {
                this.Initials = initials;
            }

            // to ensure "surname" is required (not null)
            if (surname == null) {
                throw new InvalidDataException("surname is a required property for ClientContactPerson and cannot be null");
            }
            else {
                this.Surname = surname;
            }

            // to ensure "telephoneNumber" is required (not null)
            if (telephoneNumber == null) {
                throw new InvalidDataException("telephoneNumber is a required property for ClientContactPerson and cannot be null");
            }
            else {
                this.TelephoneNumber = telephoneNumber;
            }

            this.Prefix = prefix;
        }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "Email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Initials
        /// </summary>
        [DataMember(Name = "Initials", EmitDefaultValue = false)]
        public string Initials { get; set; }

        /// <summary>
        /// Gets or Sets Prefix
        /// </summary>
        [DataMember(Name = "Prefix", EmitDefaultValue = false)]
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or Sets Surname
        /// </summary>
        [DataMember(Name = "Surname", EmitDefaultValue = false)]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or Sets TelephoneNumber
        /// </summary>
        [DataMember(Name = "TelephoneNumber", EmitDefaultValue = false)]
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// Returns true if ClientContactPerson instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientContactPerson to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientContactPerson input) {
            if (input == null)
                return false;

            return
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                     this.Email.Equals(input.Email))
                ) &&
                (
                    this.Initials == input.Initials ||
                    (this.Initials != null &&
                     this.Initials.Equals(input.Initials))
                ) &&
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                     this.Prefix.Equals(input.Prefix))
                ) &&
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                     this.Surname.Equals(input.Surname))
                ) &&
                (
                    this.TelephoneNumber == input.TelephoneNumber ||
                    (this.TelephoneNumber != null &&
                     this.TelephoneNumber.Equals(input.TelephoneNumber))
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
            sb.Append("class ClientContactPerson {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Initials: ").Append(Initials).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  TelephoneNumber: ").Append(TelephoneNumber).Append("\n");
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
            return this.Equals(input as ClientContactPerson);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode() {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Initials != null)
                    hashCode = hashCode * 59 + this.Initials.GetHashCode();
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.Surname != null)
                    hashCode = hashCode * 59 + this.Surname.GetHashCode();
                if (this.TelephoneNumber != null)
                    hashCode = hashCode * 59 + this.TelephoneNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}