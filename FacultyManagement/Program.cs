using FacultyManagement.Entities;
using FacultyManagement.Factorys;
using FacultyManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManagement
{
    internal class Program
    {
        public static TeacherRepository repo = new TeacherRepository();
        static void Main(string[] args)
        {
            try
            {
                DoTask();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally { Console.ReadLine(); }
        }

        private static void DoTask()
        {
            
            Console.WriteLine("\t\t\t\t=====Faculty Management=====\r");
            Console.WriteLine("\t\t\t\tName : Md.Rayhan Mia\r");
            Console.WriteLine("\t\t\t\tTraineeId : 1280382\r");
            Console.WriteLine("\t\t\t\t--------------------\n");
            Console.WriteLine("\t\t\t\t--------------------\n");
            Console.WriteLine("\t\tHow many operation would you like to perform? \n");
            int count = Convert.ToInt32(Console.ReadLine());
            
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("\t\t\t\tSelect Operation\n");
                    Console.WriteLine("\t\t\t\tHint: \n\t\t\t\tSelect -1\n\t\t\t\tCreate -2\n\t\t\t\tUpdate -3\n\t\t\t\tDelete -4\n");
                    int opeCount = Convert.ToInt32(Console.ReadLine());
                    switch (opeCount)
                    {
                        case 1:
                            ShowTeacher(null); break;
                                case 2:
                            CreateTeacher();break;
                            case 3:UpdateTeacher();break;
                            case 4: DeleteTeacher();break;
                        default: Console.WriteLine("invalid ");
                                break;



             



                    }
                }
            }


        }

        private static void CreateTeacher()
        {
           

            Console.WriteLine(" ID Will Genarate autometically by squence");
            
            Console.WriteLine("Enter name ");
            string nm = Console.ReadLine();
            Console.WriteLine("Enter Gmail");
            string gmail = Console.ReadLine();

            Console.WriteLine("Enter basic Slary");
            double bs = Convert.ToDouble(Console.ReadLine());

        EnterType:
            Console.WriteLine("Enter type : Parmanent =1 , Guest =2 ");
            string TypeRead = Console.ReadLine();
            TeacherCetagory teacherCetagory;
            try
            {
                teacherCetagory = (TeacherCetagory)Enum.Parse(typeof(TeacherCetagory), TypeRead);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid");
                goto EnterType;
            }


            Teacher emp = new Teacher(0, nm, gmail, bs, TeacherType.Lecturer, teacherCetagory, 20, "Male", Subject.PoliticalSociology );
            emp.Type = TeacherType.Lecturer;
            TeacherBaseFActory empFactory = new TeacherManagerFactory().CreateFactory(emp);
            empFactory.ApplySalary();
            repo.CreateTeacher(emp);
            ShowTeacher(null);


        }

        private static void ShowTeacher(Teacher teacher)
        {
            IEnumerable<Teacher> Teacher = repo.GetAllTeacher();
            Console.WriteLine(string.Format("| {0,2}| {1,10}| {2,-25}| {3,5}| {4,10}| {5,10}| {6,-20}| {7,12}| {8,8}|", 
                "ID", "Name", "Email", "Basic", "Type", "Category", "Subject", "HourlyPay", "Bonus"));
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            if (teacher == null)
            {
                foreach (Teacher item in Teacher)
                {
                 Console.WriteLine(string.Format("| {0,2}| {1,10}| {2,-25}| {3,5}| {4,10}| {5,10}| {6,-20}| {7,12}| {8,8}|",
                    item.Id, item.Name, item.Email, item.Basic,item.Type,item.Category, item.Subject,item.HourlyPay, item.Bonus));
                }

            }
            else
            {
                Console.WriteLine(string.Format("| {0,2}| {1,10}| {2,-25}| {3,5}| {4,10}| {5,10}| {6,-20}| {7,12}| {8,8}|",
                       teacher.Id , teacher.Name, teacher.Email,teacher.Basic,teacher.Type,teacher.Category,teacher.Subject,teacher.HourlyPay, teacher.Bonus));
            }
        }

        private static void UpdateTeacher()
        {
            Console.WriteLine("Enter ID");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name ");
            string nm = Console.ReadLine();
            Console.WriteLine("Enter Gmail");
            string gmail = Console.ReadLine();

            Console.WriteLine("Enter basic Slary");
            double bs = Convert.ToDouble(Console.ReadLine());

        EnterType:
            Console.WriteLine("Enter type : Parmanent =1 , Guest =2 ");
            string TypeRead = Console.ReadLine();
            TeacherCetagory teacherCetagory;
            try
            {
                teacherCetagory = (TeacherCetagory)Enum.Parse(typeof(TeacherCetagory), TypeRead);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid");
                goto EnterType;
            }


            Teacher emp = new Teacher(id, nm, gmail, bs, TeacherType.Lecturer, teacherCetagory, 20, "Male", Subject.PoliticalSociology);
            emp.Type = TeacherType.Lecturer;
            TeacherBaseFActory empFactory = new TeacherManagerFactory().CreateFactory(emp);
            empFactory.ApplySalary();
            repo.UpdateTeacher(emp);
            ShowTeacher(null);
        }

        private static void DeleteTeacher()
        {

            Console.WriteLine("Enter ID");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name ");
            string nm = Console.ReadLine();
            Console.WriteLine("Enter Gmail");
            string gmail = Console.ReadLine();

            Console.WriteLine("Enter basic Slary");
            double bs = Convert.ToDouble(Console.ReadLine());

        EnterType:
            Console.WriteLine("Enter type : Parmanent =1 , Guest =2 ");
            string TypeRead = Console.ReadLine();
            TeacherCetagory teacherCetagory;
            try
            {
                teacherCetagory = (TeacherCetagory)Enum.Parse(typeof(TeacherCetagory), TypeRead);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid");
                goto EnterType;
            }


            Teacher emp = new Teacher(id, nm, gmail, bs, TeacherType.Lecturer, teacherCetagory, 20, "Male", Subject.PoliticalSociology);
            emp.Type = TeacherType.Lecturer;
            TeacherBaseFActory empFactory = new TeacherManagerFactory().CreateFactory(emp);
            empFactory.ApplySalary();
            repo.DeleteTeacher(emp.Id);
            ShowTeacher(null);


           
        }

        
    }
}
