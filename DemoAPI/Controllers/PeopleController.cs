using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    /// <summary>
    /// This is where I give you all the info about my people.
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { Id = 1, FirstName = "Tim", LastName = "Corey" });
            people.Add(new Person { Id = 2, FirstName = "Sue", LastName = "Storm" });
            people.Add(new Person { Id = 3, FirstName = "Bilbo", LastName = "Baggins" });
        }
        /// <summary>
        /// Gets a list of the first names of all users
        /// </summary>
        /// <param name="userId">The unique identifier for this person.</param>
        /// <param name="age">We want to know how old they are</param>
        /// <returns>A list of first names .....</returns>
        // Route that this is the specific that applies to this specific method (an override)
        [Route("api/People/GetFirstNames{userId:int}/{age:int}")]
        [HttpGet] // tell it what type of http request
        public List<string> GetFirstNames(int userId, int age)
        {
            List<string> output = new List<string>();

            foreach (var p in people)
            {
                output.Add(p.FirstName);
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
            // make sure this is a valid person
            people.Add(val);
        }


        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
