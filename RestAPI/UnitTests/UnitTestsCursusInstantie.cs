using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class UnitTestsCursusInstantie
    {
        [TestMethod]
        public void NewCursusInstantieIsValid()
        {
            var cursusInput = new CursusInstantie
            {
                startDatum = new DateTime(2021, 12, 03),
                cursusDetail = new CursusDetail {
                    Duur = 3,
                    Titel = "eindcase",
                    Code = "EICE" }
            };

            var validationResults = new List<ValidationResult>();
            var actual = Validator.TryValidateObject(cursusInput, new ValidationContext(cursusInput), validationResults, true);

            Assert.IsTrue(actual, "Expected validation to succeed.");

        }
    }
}
