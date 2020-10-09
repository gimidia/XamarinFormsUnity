using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using XamarinFormsUnity.Interface;
using XamarinFormsUnity.ViewModel;

namespace XamarinFormsUnity.Service
{
    public class ViewModelLocator
    {
        private readonly IUnityContainer _container;
        public ViewModelLocator()
        {
            _container = new UnityContainer();
            _container.RegisterType<IStudentService, StudentService>();
            _container.RegisterInstance(typeof(StudentViewModel));
        }

        public StudentViewModel StudentViewModel
        {
            get { return _container.Resolve<StudentViewModel>(); }
        }
    }
}
