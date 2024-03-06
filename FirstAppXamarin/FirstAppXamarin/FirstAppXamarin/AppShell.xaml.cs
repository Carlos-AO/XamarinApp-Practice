using FirstAppXamarin.ViewModels;
using FirstAppXamarin.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FirstAppXamarin
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute("gorilladetails", typeof(GorillaDetails));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            FlyoutIsPresented = false;
            DisplayAlert("Alert Title", "Menu item clicked - message", "OK");
        }
        /* 
         * 
         * Routing.RegisterRoute("gorilladetails", typeof(GorillaDetails));
         * Line abouve added, after method below from 2019 didn't work
         * 
        Dictionary<string, Type> routes = new Dictionary<string, Type>();

        private void RegisterRoutes() 
        {
            routes.Add("gorilladetails", typeof(GorillaDetails));
            foreach (var route in routes)
            {
                Routing.RegisterRoute(route.Key, route.Value);           }
        }*/
    }
}
