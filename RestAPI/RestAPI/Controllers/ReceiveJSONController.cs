using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiveJSONController : ControllerBase
    {
        public CursusContext context;
        public static CursusInstantie model;
        public ReceiveJSONController(CursusContext cursusContext)
        {
            this.context = cursusContext;
        }
            // POST: api/CursusDetails
            [HttpPost]
            public string JsonStringBody(ContentClass content)
            {


            string[] arrContent = Regex.Split(content.Content, @"[\r\n]");
 
                foreach (string items in arrContent)
                {

                for (int i = 0; i < arrContent.Length-2; i += 5) {
                    var newInstantie = new CursusInstantie
                    {
                        cursusDetail = new CursusDetail()
                        {
                            titel = arrContent[i+0],
                            cursusCode = arrContent[i+1],
                            duur = 8

                        }
                    };


                    context.Add(newInstantie);
                    context.SaveChanges();
                }
            }
                
            return content.Content;
            }
        }
    }

