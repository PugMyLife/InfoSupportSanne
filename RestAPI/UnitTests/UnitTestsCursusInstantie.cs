//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Moq;
//using RestAPI.Models;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace UnitTests
//{
//    [TestClass]
//    public class UnitTestsCursusInstantie
//    {
//        [TestMethod]
//        public void NewCursusInstantieIsValid()
//        {
//            var cursusInput = new CursusInstantie
//            {
//                startDatum = new DateTime(2021, 12, 03),
//            };

//            var validationResults = new List<ValidationResult>();
//            var actual = Validator.TryValidateObject(cursusInput, new ValidationContext(cursusInput), validationResults, true);

//            Assert.IsTrue(actual, "Expected validation to succeed.");
//            Assert.AreEqual(0, validationResults.Count, "Unexpected number of validation errors.");
//        }

//        [TestMethod]
//        public void Instantie_Recognises_DetailKey()
//        {
//            //Arrange
//            var newCursusDetail = new CursusDetail
//            {
//                Id = 1,
//                duur = 3,
//                titel = "eindcase",
//                cursusCode = "EICE"
//            };

//            var newCursusInstantie = new Mock CursusInstantie
//            {
//                Id = 1,
//                startDatum = new DateTime(2021, 12, 03),
//                cursusDetail = new CursusDetail { titel = "eindcase" }
//            };


//            var actualresult = newCursusInstantie.cursusDetail.cursusCode;
//            var expectedresult = newCursusDetail.cursusCode;

//            Assert.AreEqual(expectedresult, actualresult);
//        }
//    }
//}
