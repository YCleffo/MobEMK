using MobEMK.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MobEMK.Views
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