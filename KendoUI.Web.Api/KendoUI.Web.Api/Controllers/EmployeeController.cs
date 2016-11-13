using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Results;
using KendoUI.Domain;

namespace KendoUI.Web.Api.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            List<Employee>  employees = new List<Employee>(10);
            return employees;
        }

        public Employee Get(int id)
        {
            return new Employee() {FirstName = "Vasia", LastName = "Pupkin", Id=1};
        }

        public HttpResponseMessage Post(Employee employee)
        {
            return new HttpResponseMessage();;
        }

        public HttpResponseMessage Put(Employee employee)
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        } 


    }
}
