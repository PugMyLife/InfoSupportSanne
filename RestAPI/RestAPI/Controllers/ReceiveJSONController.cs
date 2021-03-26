using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiveJSONController : ControllerBase
    {
        // POST: api/CursusDetails
        [HttpPost]
        public string JsonStringBody(ContentClass content)
        {
            foreach (string items in content.arrContent())
            {
                SqlConnection con = new SqlConnection("Data Source = .\\sqlexpress;initial catalog=InfoSupportDb;integrated security=true;");
                con.Open();
                var mycommand = new SqlCommand("INSERT INTO dbo.CursusDetails VALUES(@titel, @cursusCode, @duur)", con);
                //var my2ndcommand = new SqlCommand("INSERT INTO dbo.CursusInstanties VALUES(@startDatum, @cursusDetailId)", con);
                mycommand.Parameters.AddWithValue("@titel", items[0]);
                mycommand.Parameters.AddWithValue("@cursusCode", "ABC");
                mycommand.Parameters.AddWithValue("@duur", 1);
                mycommand.ExecuteNonQuery();
                con.Close();
            }

            return content.Content;
        }
    }
}
