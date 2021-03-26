using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UnitTests
{
    public class MockContentClass
    {
        public string Content { get; set; }
        public string[] arrContent()
        {
            return Regex.Split(this.Content, @"[\r\n]");

        }
    }
}
