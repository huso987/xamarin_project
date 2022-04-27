using Migros.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Migros.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class begendiklerim : ContentPage
    {
        private IEnumerable list;

        public begendiklerim()
        {
            InitializeComponent();
            begeni.ItemsSource = beğeni.list;
            model.list = new ObservableCollection<aramaürün>();
           

        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            
            var button = (ImageButton)sender;
            var item = (aramaürün) button.BindingContext;

            beğeni.list.Remove(item);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var item = sender as Button;
            var obj = item.BindingContext as aramaürün;
            model.list.Add(obj);

        }
    }
}