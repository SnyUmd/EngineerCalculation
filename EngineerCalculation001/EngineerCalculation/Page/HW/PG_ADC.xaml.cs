using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EngineerCalculation.Page.HW
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PG_ADC : ContentPage
    {
        private List<string> ResolutionList = new List<string>();


        public PG_ADC()
        {
            InitializeComponent();

        }

        private void PickerResolution_Changed(object sender, EventArgs e)
        {

        }
    }
}