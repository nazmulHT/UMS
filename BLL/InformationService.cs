using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class InformationService
    {
        public static List<InformationModel> GetAllInformations()
        {
            var data = InformationRepo.GetAllInformations();
            var info = AutoMapper.Mapper.Map<List<Information>, List<InformationModel>>(data);
            return info;
        }

        public static void AddInformation(InformationAdd info)
        {
            var data = AutoMapper.Mapper.Map<InformationAdd, Information>(info);
            InformationRepo.AddInformation(data);
        }

        public static void InformationEdit(InformationEdit obj)
        {
            var data = AutoMapper.Mapper.Map<InformationEdit, Information>(obj);
            InformationRepo.InformationEdit(data);
        }

        public static void InformationDelete(int id)
        {
            InformationRepo.InformationDelete(id);
        }

        public static List<InformationModel> GetUserType()
        {
            throw new NotImplementedException();
        }

        public static List<InformationModel> Designation()
        {
            throw new NotImplementedException();
        }

        public static List<InformationModel> GetDeparments(string dept)
        {
            var info = InformationRepo.GetDepartments(dept);
            var data = AutoMapper.Mapper.Map<List<Department>, List<InformationModel>>(info);
            return data;
        }
    }
}
