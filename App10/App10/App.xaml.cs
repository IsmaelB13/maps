using System;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;

namespace App10
{
    public partial class App : Application
    {
        private Map map;

        public App()
        {
            InitializeComponent();

            MainPage mainPage = new MainPage(map);

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
