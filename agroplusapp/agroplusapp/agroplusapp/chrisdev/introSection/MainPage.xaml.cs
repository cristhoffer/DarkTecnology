using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace agroplusapp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            animateFirstSplashLogo();
        }

        public async Task animateFirstSplashLogo()
        {
            gokuImageSplash.Opacity = 0;
            await gokuImageSplash.FadeTo(1, 4000);
            Application.Current.MainPage = new secondSplash();
        }
    }
}
