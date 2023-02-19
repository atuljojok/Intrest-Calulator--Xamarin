using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp
{
    public partial class MainPage : ContentPage
    {
 
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
            Data data = new Data();
            data.PricipleAmt =Convert.ToInt32( PAmount.Text);
            data.totalMnth = Convert.ToInt32(months.Text);
            data.IoR = Convert.ToInt32(ior.Text);
            totalIntrest.Text = (data.PricipleAmt * data.IoR * data.totalMnth / 100).ToString();
            totalAmount.Text = ( data.PricipleAmt + data.PricipleAmt * data.IoR * data.totalMnth / 100).ToString();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Data clear = new Data();
            clear.ClearData();
                {
                PAmount.Text = clear.PricipleAmt.ToString();
                months.Text = clear.totalMnth.ToString();
                ior.Text = clear.IoR.ToString();
            }
        }
    }
}
