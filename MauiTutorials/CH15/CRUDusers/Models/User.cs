using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDusers.Models
{
    // user is a domain model
    public class User
    {
        public int Id { get; set; } // primary key column
        public required string Name { get; set; } // required name column

    }
}
