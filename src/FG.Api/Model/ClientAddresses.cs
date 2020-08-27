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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

#endregion

namespace FG.Api.Model {
    /// <summary>
    /// ClientAddresses
    /// </summary>
    [DataContract]
    public partial class ClientAddresses : IEquatable<ClientAddresses>, IValidatableObject {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientAddresses" /> class.
        /// </summary>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
        /// <param name="postcode">postcode.</param>
        /// <param name="street">street.</param>
        /// <param name="streetNumber">streetNumber.</param>
        /// <param name="streetNumberAddition">streetNumberAddition.</param>
        /// <param name="type">type.</param>
        public ClientAddresses(string city = default(string), string country = default(string), string postcode = default(string),
            string street = default(string), string streetNumber = default(string), string streetNumberAddition = default(string), int? type = default(int?)) {
            this.City = city;
            this.Country = country;
            this.Postcode = postcode;
            this.Street = street;
            this.StreetNumber = streetNumber;
            this.StreetNumberAddition = streetNumberAddition;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "City", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "Country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Postcode
        /// </summary>
        [DataMember(Name = "Postcode", EmitDefaultValue = false)]
        public string Postcode { get; set; }

        /// <summary>
        /// Gets or Sets Street
        /// </summary>
        [DataMember(Name = "Street", EmitDefaultValue = false)]
        public string Street { get; set; }

        /// <summary>
        /// Gets or Sets StreetNumber
        /// </summary>
        [DataMember(Name = "StreetNumber", EmitDefaultValue = false)]
        public string StreetNumber { get; set; }

        /// <summary>
        /// Gets or Sets StreetNumberAddition
        /// </summary>
        [DataMember(Name = "StreetNumberAddition", EmitDefaultValue = false)]
        public string StreetNumberAddition { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "Type", EmitDefaultValue = false)]
        public int? Type { get; set; }

        /// <summary>
        /// Returns true if ClientAddresses instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientAddresses to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientAddresses input) {
            if (input == null)
                return false;

            return
                (
                    this.City == input.City ||
                    (this.City != null &&
                     this.City.Equals(input.City))
                ) &&
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                     this.Country.Equals(input.Country))
                ) &&
                (
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                     this.Postcode.Equals(input.Postcode))
                ) &&
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                     this.Street.Equals(input.Street))
                ) &&
                (
                    this.StreetNumber == input.StreetNumber ||
                    (this.StreetNumber != null &&
                     this.StreetNumber.Equals(input.StreetNumber))
                ) &&
                (
                    this.StreetNumberAddition == input.StreetNumberAddition ||
                    (this.StreetNumberAddition != null &&
                     this.StreetNumberAddition.Equals(input.StreetNumberAddition))
                ) &&
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                     this.Type.Equals(input.Type))
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
            sb.Append("class ClientAddresses {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  StreetNumber: ").Append(StreetNumber).Append("\n");
            sb.Append("  StreetNumberAddition: ").Append(StreetNumberAddition).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ClientAddresses);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode() {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
                if (this.StreetNumber != null)
                    hashCode = hashCode * 59 + this.StreetNumber.GetHashCode();
                if (this.StreetNumberAddition != null)
                    hashCode = hashCode * 59 + this.StreetNumberAddition.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}