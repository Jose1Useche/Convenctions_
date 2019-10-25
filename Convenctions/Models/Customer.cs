using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Convenctions.Models
{
    //This classes are created with only an objective, There are exists to create the DB with Code First from Entity Framework.
    //The name of these classes are declared in singular.
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public DateTime Birthdate { get; set; }
    }
}