using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.MapperConfig
{
    public class AutoMapperSettings : Profile
    {
        public AutoMapperSettings()
        {
            //CreateMap<Information, InformationAdd>();
            CreateMap<InformationAdd, Information>();
            CreateMap<Information, InformationModel>();
            CreateMap<InformationModel, Department>();
            CreateMap<InformationModel, Designation>();
            CreateMap<InformationEdit, Information>();
            CreateMap<Department, InformationModel>();
        }
    }
}
