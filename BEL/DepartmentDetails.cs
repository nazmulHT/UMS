using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class DepartmentDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<InformationModel> Informations { get; set; }
    }
}
