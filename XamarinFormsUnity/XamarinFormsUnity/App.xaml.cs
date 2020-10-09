using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsUnity.Service;
using XamarinFormsUnity.View;

namespace XamarinFormsUnity
{
    public partial class App : Application
    {
        private static ViewModelLocator _locator;
        public static ViewModelLocator Locator
        {
            get { return _locator = _locator ?? new ViewModelLocator(); }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new Home();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
