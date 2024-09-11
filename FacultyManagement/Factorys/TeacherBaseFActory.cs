using FacultyManagement.Entities;
using FacultyManagement.Interface;
using FacultyManagement.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManagement.Factorys
{
    public abstract class TeacherBaseFActory
    {
        protected Teacher _emp;
        protected TeacherBaseFActory(Teacher emp)
        { 
         _emp = emp;
        
        
        }
        public abstract IDepartmentManager create();
        public Teacher ApplySalary()
        { 
         IDepartmentManager manager = this. create();
            _emp.Bonus = manager.GetBonus();
            _emp.HourlyPay = manager.GetHourlyPay();
            return _emp;
        
        }



    }
}
