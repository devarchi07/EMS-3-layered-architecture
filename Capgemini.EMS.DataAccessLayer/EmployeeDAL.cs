using Capgemini.EMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Capgemini.EMS.DataAccessLayer
{
    public class EmployeeDAL
    {
        static List<Employee> list = new List<Employee>();
         public static bool Add( Employee emp)

        {
            list.Add(emp);
            return true;
        }
        public static List<Employee> GetList()
        {
            return list;
        }
        public static Employee GetById(int id)
        {
            //linq query
            var emp = list.Where(e => e.Id == id).FirstOrDefault();//foreach employee give me that employee which matches the id
            return emp;
        }
            public static bool Update(Employee emp)
            {
             // get emp by id
             var existingEmp= list.Where(e => e.Id == emp.Id).FirstOrDefault();
            //update
            existingEmp.Name = emp.Name;
            existingEmp.DateofJoining = emp.DateofJoining;
            return true;

        }
        public static bool Delete(int id)
        {
            var emp = list.Where(e => e.Id == id).FirstOrDefault();
            list.Remove(emp);
            return true;
        }
    }
}
