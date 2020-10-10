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
	public partial class PG_HardWareCal : ContentPage
	{
		public PG_HardWareCal ()
		{
			InitializeComponent ();
		}

        //**********************************************************************
        private void BtnADC_Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page.HW.PG_ADC());
        }






        //**********************************************************************
        //**********************************************************************
        //**********************************************************************
        private void BtnTest_Click(object sender, EventArgs e)
        {
            LblTest.Text = App.StrTest;
            App.StrTest = "Test Hard";
        }
    }
}


//**********************************************************************
