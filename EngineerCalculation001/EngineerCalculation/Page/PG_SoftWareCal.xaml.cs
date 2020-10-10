using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EngineerCalculation.Page
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PG_SoftWareCal : ContentPage
	{
        //**********************************************************************
		public PG_SoftWareCal()
        {
			InitializeComponent ();
		}

        //**********************************************************************
        private void BtnResolution_Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page.SW.PG_Resolution());
        }





        //**********************************************************************
        //**********************************************************************
        //**********************************************************************
        private void BtnTest_Click(object sender, EventArgs e)
        {
            LblTest.Text = App.StrTest;
            App.StrTest = "Test Soft";
        }
    }
}
//**********************************************************************
