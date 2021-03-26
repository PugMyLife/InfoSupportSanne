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
            var seperateInit = new MockContentClass
            {
                Content = @"Titel: Object Oriented Programming in C# By Example 
Cursuscode: OOCS
Duur: 5 dagen
Startdatum: 22/03/2021
"
            };

            string[] actualresult = seperateInit.arrContent();
            string[] expectedresult = new string[] {@"Titel: Object Oriented Programming in C# By Example ",
"",
"Cursuscode: OOCS",
"",
"Duur: 5 dagen",
"",
"Startdatum: 22/03/2021","",""
 };

            CollectionAssert.AreEqual(actualresult, expectedresult);
        }
    }
}
