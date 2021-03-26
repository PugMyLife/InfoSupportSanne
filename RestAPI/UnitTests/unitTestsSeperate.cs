using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestAPI.Models;

namespace UnitTests
{
    [TestClass]
    public class unitTestsSeperate
    {
        [TestMethod]
        public void StringIsSeperatedToArray()
        {
            var seperateInit = new ContentClass
            {
                Content = @"Titel: Object Oriented Programming in C# By Example 
Cursuscode: OOCS
Duur: 5 dagen
Startdatum: 22/03/2021

Titel: LINQ: .NET Language-Integrated Query
Cursuscode: LINQ
Duur: 2 dagen
Startdatum: 22/03/2021
"
            };

            string[] actualresult = seperateInit.arrContent();
            string[] expectedresult = new string[] {@"Titel: Object Oriented Programming in C# By Example ", 
"Cursuscode: OOCS",
"Duur: 5 dagen",
"Startdatum: 22/03/2021", @"Titel: LINQ: .NET Language-Integrated Query",
"Cursuscode: LINQ",
"Duur: 2 dagen",
"Startdatum: 22/03/2021"};

            CollectionAssert.AreEqual(actualresult, expectedresult);
        }

        [TestMethod]
        public void MockCursusInsert()
        {
            var CursusDetail = new Mock<CursusDetail>();
            var seperateInit = new ContentClass
            {
                Content = @"Titel: Object Oriented Programming in C# By Example 
Cursuscode: OOCS
Duur: 5 dagen
Startdatum: 22/03/2021

Titel: LINQ: .NET Language-Integrated Query
Cursuscode: LINQ
Duur: 2 dagen
Startdatum: 22/03/2021
"
            };
        }
    }
}
