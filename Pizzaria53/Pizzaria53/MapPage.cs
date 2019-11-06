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
            var customMap = new CustomMap
            {
                MapType = MapType.Street,
                WidthRequest = App.ScreenWidth,
                HeightRequest = App.ScreenHeight
            };
            customMap.RouteCoordinates.Add(new Position(-23.556697, -46.658699));
            customMap.RouteCoordinates.Add(new Position(-23.556275, -46.658246));
            customMap.RouteCoordinates.Add(new Position(-23.554071, -46.660794));
            customMap.RouteCoordinates.Add(new Position(-23.555211, -46.662184));

            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(-23.555843, -46.660229), Distance.FromMiles(1.0)));
            Content = customMap;
        }
    }
}