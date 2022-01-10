using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class DesignationDetails
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public ICollection<InformationModel> Informations { get; set; } 
    }
}
