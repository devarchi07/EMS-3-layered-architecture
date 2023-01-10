using Capgemini.EMS.DataAccessLayer;
using Capgemini.EMS.Entities;
using Capgemini.EMS.Exceptions;
using System;
using System.Collections.Generic;

namespace Capgemini.EMS.BusinessLayer
{
    public class EmployeeBL
    {
        // add //update // delete //display
        public static bool Add(Employee emp)
        {
            //business validation
            // if error throw UDE
            if (emp.Id <= 0)
            {
                throw new EmsException("Employee ID should be greater than zeroo");
            }

            //call DAL method
            bool isAdded = EmployeeDAL.Add(emp);
            return isAdded;
           

        }
        public static List<Employee> GetList()
        {
            var list = EmployeeDAL.GetList();
            return list;
        }
        public static Employee GetById(int id)
        {
            var emp = EmployeeDAL.GetById(id);
            return emp;
        }
        public static bool Update(Employee emp)
        {
            bool isUpdated = EmployeeDAL.Update(emp);
            return isUpdated;
        }
        public static bool Delete(int id)
        {
            var isDelete = EmployeeDAL.Delete(id);
            return isDelete;
        }
    }
}
