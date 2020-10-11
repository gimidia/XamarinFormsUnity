using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using XamarinFormsUnity.Interface;
using XamarinFormsUnity.Model;

namespace XamarinFormsUnity.Service
{
    public class StudentService : IStudentService
    {
        public IEnumerable GetStudent()
        {
            return new List<Student>{

                new Student { Name = "A",Class="I" },
                new Student { Name = "B",Class="II" },
                new Student { Name = "C" ,Class="III"},
                new Student { Name = "D" ,Class="IV"},
                new Student { Name = "E" ,Class="V"},
                new Student { Name = "F" ,Class="VI"},

           };
        }
    }
}
