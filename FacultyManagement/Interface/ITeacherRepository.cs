using FacultyManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyManagement.Interface
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAllTeacher();
        Teacher GetTeacher(int id);
        Teacher CreateTeacher(Teacher teacher);
        Teacher UpdateTeacher(Teacher teacher);
        Teacher DeleteTeacher(int id);
    }
}
