using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Pizzaria53
{
    public class MapPageCS : ContentPage
    {
        public MapPageCS()
        {            
            CustomMap customMap = new CustomMap
            {
                MapType = MapType.Street
            };

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
            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-23.556663, -46.658750), Distance.FromMiles(1.0)));

            Content = customMap;
        }
    }
}