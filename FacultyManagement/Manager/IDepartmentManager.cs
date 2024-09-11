using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManagement.Manager
{
    public  interface IDepartmentManager
    {
        decimal GetBonus();
        decimal GetHourlyPay();
        decimal GetMedicalAllawance();
    }
}
