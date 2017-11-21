using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NetStdForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //private async void pcl_Clicked(object sender, EventArgs e)
        //{
        //    var res = PCL259Lib.PCL259.Hello(entry.Text);
        //    await DisplayAlert(((Button)sender).Text, res, "OK");
        //}

        private async void netstd_Clicked(object sender, EventArgs e)
        {
            var res = NetStd20Lib.NetStd20.Hello(entry.Text);
            await DisplayAlert(((Button)sender).Text, res, "OK");
        }
    }
}
