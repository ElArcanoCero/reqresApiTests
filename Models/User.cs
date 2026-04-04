using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reqresApiTests.Models
{
    internal class Users
    {
        public int Id { get; set; }

        public required string Email { get; set; }

        public required string First_Name { get; set; }

        public required string Last_Name { get; set; }

        public required string Avatar { get; set; }
    }
}
