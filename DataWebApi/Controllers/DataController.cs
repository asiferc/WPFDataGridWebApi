using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Globalization;
using Microsoft.AspNetCore.Cors;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DataWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {

        [HttpGet]
        public List<Employee> Get()
        {
            return GetEmployeeList();
        }

        static List<Employee> GetEmployeeList()
        {
            var employee = new List<Employee>() {
                new Employee(){ EmployeeID = 1, EmployeeName="Jason Fong", Location = "Korea", ReportingManager = "Won Duo"},
                new Employee(){ EmployeeID = 2, EmployeeName="Lohith Sharma", Location = "Bangalore", ReportingManager = "Ravi Kumar"},
                new Employee(){ EmployeeID = 3, EmployeeName="Sam Daniel", Location = "Singapore", ReportingManager = "Lee Wong"},
                new Employee(){ EmployeeID = 4, EmployeeName="Richard Lee", Location = "Singapore", ReportingManager = "Mike Frost"},
                new Employee(){ EmployeeID = 4, EmployeeName="Anil Rao", Location = "Bangalore", ReportingManager = "Mike Dave"},
            };
            return employee;
        }


        // GET api/<DataController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DataController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DataController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DataController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
