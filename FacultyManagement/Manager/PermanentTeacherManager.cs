using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManagement.Manager
{
    public class PermanentTeacherManager : IDepartmentManager
    {
        public decimal GetBonus()
        {
            double bonusPcnt = 4;
            double basic = 2000;
            double bonus = basic * bonusPcnt;
            return (decimal)bonus;
        }

        public decimal GetHourlyPay()
        {
            return 500;
        }
        public decimal GetMedicalAllawance()
        {
            return 5000;
        }
        public decimal GetHouseRentAllawance()
        {
            return (decimal).5;
        }


    }
}
