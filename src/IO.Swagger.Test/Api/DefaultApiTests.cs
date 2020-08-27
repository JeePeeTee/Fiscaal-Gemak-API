/* 
 * Fiscaal Gemak API
 *
 * Fiscaal Gemak API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: jpt@sultancrm.nl
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using FG.Api.Api;
using FG.Api.Model;
using RestSharp;
using NUnit.Framework;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DefaultApiTests
    {
        private DefaultApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DefaultApi();
            instance.Configuration.DefaultHeader.Add("Authorization", "U4-API-KEY 1D06A1B7-F5EC-45FF-8232-8ABFF8084B81");
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DefaultApi
            Assert.IsInstanceOfType(typeof(DefaultApi), instance, "instance is a DefaultApi");
        }

        /// <summary>
        /// Test AddClientCompanyTest
        /// </summary>
        [Test]
        public void AddClientCompanyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            ModelClient body = new ModelClient(
                identificationNumber: "856420128",
                name: "API created company");

            // MUST HAVES BY TYPE = 0 >> Contactpersoon
            // body.BirthDate = new DateTime(1980,1,1);
            // body.Initials = "D.E.";
            // body.Surname = "Surname";
            // body.IdentificationNumber = "123456782"; // BSN Nummer  111222333 of 123456782.

            body.Addresses = new List<ClientAddresses>() {
                new ClientAddresses() {
                    City = "DORDRECHT",
                    Country = "NLD",
                    Postcode = "3316GL",
                    Street = "Kamerlingh Onnesweg",
                    StreetNumber = "2",
                    StreetNumberAddition = null,
                    Type = 1
                }
            };

            body.ChamberOfCommerceNumber = "66158036"; // Should be Unique
            body.IdentificationNumber = "856420128"; // Should be Unique
            body.EmailAddresses = new List<string>() { "jpt@sultancrm.nl", "info@sultancrm.nl" };
            body.Number = "123";
            body.Type = 1; // Type 1 = Company, 0 = Person
            body.TypeOfBusinessEntity = 1;

            body.BeconNumber = 123456;
            body.ClientGroupName = "Standaard";

            // body.ContactPerson = new ClientContactPerson() {
            //     Initials = "J.P.",
            //     Surname = "Teunisse",
            //     TelephoneNumber = "06-12345678",
            //     Email = "jpt@sultancrm.nl"
            // };

            body.PhoneNumbers = new List<string>() { "078-1234567", "085-1234567" };

            body.TaxConsultant = "jpt@sultancrm.nl";
            body.VatNumber = "NL856420128B01";

            var result = instance.AddClient(body);

            var newId = result.Id;
        }

        /// <summary>
        /// Test AddClientCompanyTest
        /// </summary>
        [Test]
        public void AddClientPersonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            ModelClient body = new ModelClient(
                identificationNumber: "856420128",
                name: "API created person");

            // MUST HAVES BY TYPE = 0 >> Contactpersoon
            body.BirthDate = new DateTime(1980,1,1);
            body.Initials = "D.E.";
            body.Surname = "Surname";
            body.IdentificationNumber = "123456782"; // BSN Nummer  111222333 of 123456782.

            body.Type = 0; // Type 1 = Company, 0 = Person
            body.Number = "12345";

            body.BeconNumber = 123456;
            body.ClientGroupName = "Standaard";

            body.PhoneNumbers = new List<string>() { "078-1234567", "085-1234567" };

            var result = instance.AddClient(body);

            var newId = result.Id;
        }


        /// <summary>
        /// Test GetClients
        /// </summary>
        [Test]
        public void GetClientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            var response = instance.GetClients();
            Assert.IsInstanceOf<List<ModelClient>> (response, "response is List<ModelClient>");
        }
        /// <summary>
        /// Test GetCustomer
        /// </summary>
        [Test]
        public void GetCustomerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            int? id = 123456;
            var response = instance.GetCustomer(id);
            Assert.IsInstanceOf<ModelClient> (response, "response is ModelClient");
        }
    }

}
