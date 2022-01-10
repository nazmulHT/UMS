using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UMS.Controllers
{
    public class InformationController : ApiController
    {
        [Route("api/Information/All")]
        [HttpGet]
        public List<InformationModel> GetALLInformations()
        {
            return InformationService.GetAllInformations();
        }

        [Route("api/Information/AddInfo")]
        [HttpPost]
        public void AddInformation(InformationAdd info)
        {
            InformationService.AddInformation(info);
        }
        
        [Route("api/Information/Edit/{id}")]
        [HttpPost]
        public void InformationEdit(InformationEdit obj)
        {
            InformationService.InformationEdit(obj);
        }

        [Route("api/Information/Delete/{id}")]
        [HttpGet]
        public void InformationDelete(int id)
        {
            InformationService.InformationDelete(id);
        }

        [Route("api/Information/UserType")]
        [HttpGet]
        public List<InformationModel> GetUserType()
        {
            return InformationService.GetUserType();
        }

        [Route("api/Information/Designation")]
        [HttpGet]
        public List<InformationModel> Designation()
        {
            return InformationService.Designation();
        }

        [Route("api/Information/Department/{dept}")]
        [HttpGet]
        public List<InformationModel> GetDepartments(string dept)
        {
            return InformationService.GetDeparments(dept);
        }

    }
}
