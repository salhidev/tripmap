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
            Map = new Map();
            InitializeComponent();
            this.BindingContext = this;
        }

        public Map Map { get; private set; }
    }
}