using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManagement.Entities
{
    public abstract class Person
    {
        
        int age;
        string gender;

        public Person()
        {
            
        }
        public Person( int age, string gender)
        {
            
            this.Age = age;
            this.Gender = gender;
        }

       
        public int Age { get; set; }
        public string Gender { get; set; }


    }
}
