using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    /// <summary>
    /// Represents one specific person.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// ID from SQL
        /// </summary>
        public int Id { get; set; } = 0;
        /// <summary>
        /// User's first names.
        /// </summary>
        public string FirstName { get; set; } = "";
        /// <summary>
        /// You know it!
        /// </summary>
        public string LastName { get; set; } = "";
    }
}