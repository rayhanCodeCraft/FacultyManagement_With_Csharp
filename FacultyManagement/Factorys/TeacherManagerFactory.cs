using FacultyManagement.Entities;
using FacultyManagement.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManagement.Factorys
{
    public class TeacherManagerFactory
    {
        public  TeacherBaseFActory CreateFactory(Teacher emp)
        { 
            TeacherBaseFActory returnValue = null;
            if (emp.Category==TeacherCetagory.Parmanent)
            {
                returnValue = new ParmanentTeacherFactory(emp);

            }
            else if (emp.Category==TeacherCetagory.Guest)
                
            { 
            returnValue = new GuestTeacherFactory(emp);
            
            }
            return returnValue;
               
             
        
        
        
        }



    }
}
