using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EngineerCalculation
{
    public partial class MainPage : ContentPage
    {
        //**********************************************************************
        public MainPage()
        {
            InitializeComponent();
        }

        //**********************************************************************
        private void BtnHardWareCal_Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page.PG_HardWareCal());
        }

        //**********************************************************************
        private void BtnSoftWareCal_Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page.PG_SoftWareCal());
        }
    }
}
//**********************************************************************
