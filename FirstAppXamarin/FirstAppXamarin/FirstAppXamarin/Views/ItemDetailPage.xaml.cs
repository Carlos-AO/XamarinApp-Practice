using FirstAppXamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FirstAppXamarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}