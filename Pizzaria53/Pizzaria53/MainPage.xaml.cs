using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Pizzaria53
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            /*customMap.RouteCoordinates.Add(new Position(-23.556697, -46.658699));
            customMap.RouteCoordinates.Add(new Position(-23.556275, -46.658246));
            customMap.RouteCoordinates.Add(new Position(-23.554071, -46.660794));
            customMap.RouteCoordinates.Add(new Position(-23.555211, -46.662184));

            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-23.555843, -46.660229), Distance.FromMiles(1.0)));*/

            CustomPin pin = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(-23.556663, -46.658750),
                Label = "Pizzaria 53 - Local",
                Address = "Rua Augusta, 1508",
                Name = "Pizzaria 53",
                Url = "http://pizzaria.azurewebsites.net/"
            };
            CustomPin pin2 = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(-23.556663, -46.658750),
                Label = "Masp - Museu de Arte de São Paulo",
                Address = "Av. Paulista, 1578 - Bela Vista",
                Name = "Masp",
                Url = "http://pizzaria.azurewebsites.net/"
            };
            customMap.CustomPins = new List<CustomPin> { pin };
            customMap.CustomPins = new List<CustomPin> { pin2 };
            customMap.Pins.Add(pin);
            customMap.Pins.Add(pin2);
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-23.558083, -46.657678), Distance.FromMiles(1.0)));
        }
    }
}
