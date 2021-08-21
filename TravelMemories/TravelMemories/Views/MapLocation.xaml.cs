using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;


namespace TravelMemories.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapLocation : ContentPage
    {
        public MapLocation()
        {
            Map map = new Map();
            Content = map;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}