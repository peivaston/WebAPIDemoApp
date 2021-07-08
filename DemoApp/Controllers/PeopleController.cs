using DemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoApp.Controllers
{
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();
        public PeopleController()
        {
            people.Add(new Person { FirstName = "Peivaston", LastName = "Sayed", Id = 1 });
            people.Add(new Person { FirstName = "Tim", LastName = "Cook", Id = 2 });
            people.Add(new Person { FirstName = "Elon", LastName = "Musk", Id = 3 });
        }


        [Route("api/People/GetFirstNames/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstNames(int userId, int age)
        {
            List<string> output = new List<string>();
            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
        }

        [Route("api/People/GetLastNames/{userId: id}/{age: int}")]
        [HttpGet]
        public List<string> GetLastNames(int userId, int age)
        {
            List<string> output = new List<string>();
            foreach( var p in people)
            {
                output.Add(p.LastName);
            }
            return output;
        }


        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }


        // DELETE: api/People/5
        public void Delete(int id)
        {

        }
    }
}
