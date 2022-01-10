using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InformationRepo
    {
        static UMSEntities context;
        static InformationRepo()
        {
            context = new UMSEntities();
        }

        public static List<Information> GetAllInformations()
        {
            var data = context.Informations.ToList();
            return data;
        }

        public static void AddInformation(Information data)
        {
            context.Informations.Add(data);
            context.SaveChanges();
        }

        public static void InformationEdit(Information obj)
        {
            var data = context.Informations.FirstOrDefault(e => e.Id == obj.Id);
            context.Entry(data).CurrentValues.SetValues(obj);
            context.SaveChanges();
        }

        public static void InformationDelete(int id)
        {
            var info = context.Informations.FirstOrDefault(e => e.Id == id);
            context.Informations.Remove(info);
            context.SaveChanges();
        }

        public static List<Department> GetDepartments(string dept)
        {
            var data = context.Departments.ToList();
            data = context.Departments.Where(e => e.Name == "BBA" 
            || e.Name == "CSE" || e.Name == "EEE" || e.Name == "LLB"
            || e.Name == "ENGLISH LITERATURE").ToList();
            return data;
        }
    }
}
