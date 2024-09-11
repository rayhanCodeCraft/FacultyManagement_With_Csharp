using FacultyManagement.Entities;
using FacultyManagement.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManagement.Factorys
{
    public class ParmanentTeacherFactory  : TeacherBaseFActory
    {
        protected new Teacher _emp;
        public ParmanentTeacherFactory(Teacher emp) : base(emp)
        {
            _emp = emp;
        }
        
         
        public override IDepartmentManager create()
        {
            PermanentTeacherManager  manager = new PermanentTeacherManager ();
            _emp.Bonus = manager.GetBonus();
            _emp.HourlyPay = manager.GetHourlyPay();
            return manager;
        }
    }
   
}
