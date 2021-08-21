using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelMemories.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }
       
        private  void AlreadyRegister_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }

    }
}