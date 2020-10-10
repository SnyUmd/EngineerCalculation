using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EngineerCalculation.Page.SW
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class PG_Resolution : ContentPage
    {
        private List<string> ResolutionList = new List<string>();

        //**********************************************************************
        public PG_Resolution()
        {
            InitializeComponent();

            //2-32の値をセット
            for (int i = 2; i < 33; i++)
                ResolutionList.Add($"　　　　分解能：{i.ToString()}　　　　　");
            //PickerのItemをセット
            PickerResolution.ItemsSource = ResolutionList;
        }

        //**********************************************************************
        private void PickerResolution_Changed(object sender, EventArgs e)
        {
            PickerResolution.FontSize = 15;
            BtnResolutionCal1.IsEnabled = true;
        }

        //**********************************************************************
        private void BtnResolutionCal1_Clicked(object sender, EventArgs e)
        {
            double dResolution;
            double dMax;

            if (PickerResolution.SelectedIndex < 0) return;

            //分解能値以外の文字列を削除
            dResolution = int.Parse(PickerResolution.SelectedItem.ToString().Replace("　", "").Replace("分解能：", ""));

            dMax = Cls_Cal.ResolutionCal(dResolution);

            LblMax.Text = dMax.ToString();
            //16進数に変換して表示
            LblMax_Hex.Text = $"0x{((int)dMax).ToString("x2")}";
        }
    }
}

//**********************************************************************
