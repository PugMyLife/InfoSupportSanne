using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestAPI.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UnitTests
{
    [TestClass]
    public class unitTestsCursusDetails
    {
        [TestMethod]
        public void NewCursusIsValid()
        {
            var cursusInput = new CursusDetail
            {
                duur = 5,
                titel = "EindCase",
                cursusCode = "EICE"
            };

            var validationResults = new List<ValidationResult>();
            var actual = Validator.TryValidateObject(cursusInput, new ValidationContext(cursusInput), validationResults, true);

            Assert.IsTrue(actual, "Expected validation to succeed.");
            Assert.AreEqual(0, validationResults.Count, "Unexpected number of validation errors.");
        }
    }
}
