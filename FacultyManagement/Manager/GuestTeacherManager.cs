using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManagement.Manager
{
    public class GuestTeacherManager : IDepartmentManager
    {
        public decimal GetBonus()
        {
            return 500;

        }

        public decimal GetHourlyPay()
        {
            double hourlyPay = 200;
            int hour = 100;
            decimal pay = (decimal)hourlyPay * hour;
            return pay;
        }
        public decimal GetMedicalAllawance()
        {
            return 2000;
        }








    }

       
    


    

}
