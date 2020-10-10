using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EngineerCalculation
{

    public partial class App : Application
    {
        public static string StrTest; // { get; set; }

        //**********************************************************************
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EngineerCalculation.MainPage());

            StrTest = "test";
        }

        //**********************************************************************
        protected override void OnStart()
        {
        }

        //**********************************************************************
        protected override void OnSleep()
        {
        }

        //**********************************************************************
        protected override void OnResume()
        {
        }
    }
}
//**********************************************************************
