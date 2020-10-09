using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using XamarinFormsUnity.Interface;

namespace XamarinFormsUnity.ViewModel
{
    public class StudentViewModel : BaseModel
    {
        private readonly IStudentService _istudentservice;
        public IEnumerable Students { get; set; }
        public StudentViewModel(IStudentService istudentService)
        {
            _istudentservice = istudentService;
            Students = _istudentservice.GetStudent();

        }
    }
}
