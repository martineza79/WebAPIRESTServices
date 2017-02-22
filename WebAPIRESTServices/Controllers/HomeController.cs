using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIRESTServices.Controllers
{
    public class HomeController : ApiController
    {
        [HttpPost]
        public bool AddEmpDetails()
        {
            return true;
        }

        [HttpGet]
        public string GetEmpDetails()
        {
            return "Willie Wanka";
        }

        [HttpDelete]
        public string DeleteEmpDetails(string id)
        {
            return "Employees details delete having Id " + id;
        }

        [HttpPut]
        public string UpdateEmpDetails(string Name, String Id)
        {
            return "Employee details Updated with Name " + Name + " and id " + Id;
        }
    }
}
