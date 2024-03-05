using FirstAppXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlankApp1.ViewModel
{
    public class MainPageViewModel : BaseViewModel

    {
        public MainPageViewModel() 
        { 
            WelcomeText = "Hi Carl";
        }
        private string _welcomeText;
        public string WelcomeText 
        { 
            get { return _welcomeText; } 
            set { _welcomeText = value; } 
        }    


        

        /*
        private string _welcomeText;
        public string WelcomeText
        { 
            get => _welcomeText;
            set => SetValue(ref _welcomeText, value); 
        }*/


    }
}
