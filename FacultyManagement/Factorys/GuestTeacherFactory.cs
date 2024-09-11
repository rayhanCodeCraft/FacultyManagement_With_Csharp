using FacultyManagement.Entities;
using FacultyManagement.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManagement.Factorys
{
    public class GuestTeacherFactory : TeacherBaseFActory
    {

        public GuestTeacherFactory(Teacher emp) : base (emp)
        {
        
        
        }

         public override IDepartmentManager create()
        {
            GuestTeacherManager manager = new GuestTeacherManager();
            _emp.Bonus = manager.GetBonus();
            _emp.HourlyPay = manager.GetHourlyPay();
            return manager;
        }

    }
}
