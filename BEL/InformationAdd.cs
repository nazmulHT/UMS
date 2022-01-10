using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace BEL
{
    public class InformationAdd
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public UserType UserType { get; set; }
        public int Department_Id { get; set; }
        public int Designation_Id { get; set; }
    }
}
