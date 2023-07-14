using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace App10
{
    public partial class MainPage : ContentPage
    {
        //private object map;
        private Xamarin.Forms.GoogleMaps.Map map;

        public MainPage(Xamarin.Forms.GoogleMaps.Map map)

        {
            var defaultPin = new Pin { Type = PinType.Place, Label = "This is my home", Address = "Here", Position = new Position(-23.68, -46.87) };

            map.Pins.Add(defaultPin);
            
            this.map = map;
        }
    }
}
