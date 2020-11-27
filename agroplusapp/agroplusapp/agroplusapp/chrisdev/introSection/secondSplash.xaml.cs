using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using agroplusapp.chrisdev.loginSection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace agroplusapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class secondSplash : ContentPage
    {
        public secondSplash()
        {
            InitializeComponent();
            animateSecondSplashLogo();
        }

        public async Task animateSecondSplashLogo()
        {
            mortalKombatSplash.Opacity = 0;
            await mortalKombatSplash.FadeTo(1, 4000);
            Application.Current.MainPage = new loginSection();
        }
    }
}