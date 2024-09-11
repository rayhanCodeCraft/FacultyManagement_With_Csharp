using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManagement.Entities
{
    public class Teacher:Person
    {
        int id;
        string name;
        string email;
        double basic;
        Subject subject;
        TeacherType type;
        TeacherCetagory category;
       

        public Teacher()
        {
            
        }

        public Teacher(int id, string name, string email, double basic, TeacherType type, TeacherCetagory category, int age, string gender, Subject subject) : base(age, gender)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Basic = basic;
            this.Type = type;
            this.Category = category;
            this.Subject = subject;
           
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public double Basic { get => basic; set => basic = value; }
        public TeacherType Type { get => type; set => type = value; }
        public TeacherCetagory Category { get => category; set => category = value; }
        public Subject Subject { get => subject; set => subject = value; }
        public decimal HouseRentAllaowance { get; set; }
        public decimal MedicalAllowance { get; set; }
        public decimal HourlyPay { get; set; }
        public decimal Bonus { get; set; }
    }
}
