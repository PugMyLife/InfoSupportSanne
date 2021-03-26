using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Models
{
    public class ContentClass
    {
        public string Content { get; set; }
        public string[] arrContent()
        {
            return this.Content.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
        }


    }
}
