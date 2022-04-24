using Migros.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Migros.Views
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