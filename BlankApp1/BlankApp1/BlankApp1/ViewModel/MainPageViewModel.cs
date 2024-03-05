using FirstAppXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

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

        public ICommand CountCommand => new Command (OnCount);

        public void OnCount()
        {
            var x = 0;
            while (x < 100)
            {
                x++;
                Console.WriteLine(x.ToString());
            }
            
        }
        
    }
}
