using FacultyManagement.Entities;
using FacultyManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManagement.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private List<Teacher> TeacherList;
        public TeacherRepository() 
        {

            TeacherList = new List<Teacher>()
            {
                new Teacher()
                {
                 Id = 1, Name = "Rayhan", Email="rayhan.mia879@gmail.com",
                 Basic= 5000, Type = TeacherType.Professor, Category= TeacherCetagory.Parmanent,Age = 26, Gender= "Male",
                 Subject= Subject.ReligionSociety
                },
                new Teacher()
                {
                 Id = 2, Name = "Yousuf", Email="Yousuf.Khan79@gmail.com",
                 Basic= 5000, Type = TeacherType.Professor, Category= TeacherCetagory.Guest,Age = 26, Gender= "Male",
                 Subject= Subject.SociologicalTheories
                },

                new Teacher()
                {
                 Id = 3, Name = "Shefain", Email="Shefain3@gmail.com",
                 Basic= 5000, Type = TeacherType.Professor, Category= TeacherCetagory.Parmanent,Age = 26, Gender= "Male",
                 Subject= Subject.SociologyOfDev
                },

                new Teacher()
                {
                 Id = 4, Name = "Mridul", Email="Mridul.Khan79@gmail.com",
                 Basic= 5000, Type = TeacherType.Professor, Category= TeacherCetagory.Guest,Age = 59, Gender= "Male",
                 Subject= Subject.PoliticalSociology
                },

            };

        
        }
        public IEnumerable<Teacher> GetAllTeacher() 
        { 
         return from rows in TeacherList select rows;
        
        }

        public Teacher CreateTeacher(Teacher teacher)
        {
           Teacher existingTeacher =((from T in TeacherList orderby T.Id descending select T).Take(1)).Single() as Teacher;
            teacher.Id = existingTeacher.Id +1;
            TeacherList.Add(teacher);
            return teacher;
           
        }

        public Teacher DeleteTeacher(int id)
        {

            Teacher deleteTeacher = GetTeacher(id);
            if (deleteTeacher != null)
            {
                TeacherList.Remove(deleteTeacher);
            }
            return deleteTeacher;
        }

       

        public Teacher GetTeacher(int id)
        {
            var Teacher  = (from e in TeacherList where e.Id == id select e).Single();
            return Teacher;
        }

        public Teacher UpdateTeacher(Teacher upTeacher)
        {
            Teacher teacher = GetTeacher(upTeacher.Id);
            if (teacher != null)
            {
                teacher.Id = teacher.Id;
                teacher.Name = upTeacher.Name;
                teacher.Email = upTeacher.Email;
                teacher.Basic   = upTeacher.Basic;
                teacher.Type = upTeacher.Type;
                teacher.Category = upTeacher.Category;
                teacher.Subject = upTeacher.Subject;
            }
            return teacher;
        }
    }
}
