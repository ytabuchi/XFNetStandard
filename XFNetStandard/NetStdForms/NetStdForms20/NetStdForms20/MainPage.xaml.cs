using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NetStdForms20
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void pcl_Clicked(object sender, EventArgs e)
        {
            var msg = PCL259Lib.PCL259.GetMessage();
            await DisplayAlert("PCL", msg, "OK");
        }

        private async void netstd_Clicked(object sender, EventArgs e)
        {
            var msg = NetStd20Lib.NetStd20.GetMessage();
            await DisplayAlert("NET Standard", msg, "OK");
        }
    }
}
