using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Migros.Models;
using System.Collections.ObjectModel;

namespace Migros.altkatogoriler
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Yeşillik : ContentPage
    {
        List<aramaürün> list = new List<aramaürün>()
            {

                new aramaürün{ProductName ="Maydanoz Adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28260009/maydanoz-adet-659b84.jpg",UnitPrice=5},
                 new aramaürün{ProductName ="Roka Demet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28340009/roka-demet-efff5f.jpg",UnitPrice=5},
                  new aramaürün{ProductName ="Dereotu Adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28060009/dereotu-adet-a47d2c.jpg",UnitPrice=5},
                   new aramaürün{ProductName ="Pazı Demet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28320005/pazi-demet-0225c8.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Salata Kıvırcık adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28360089/salata-kivircik-adet-da42ae.jpg",UnitPrice=18},
                  new aramaürün{ProductName ="Fesleğen Demet ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28119903/feslegen-demet-50fba7.jpg",UnitPrice=12 }
           };
        public Yeşillik()
        {
            InitializeComponent();
            model.list = new ObservableCollection<aramaürün>();
            beğeni.list = new ObservableCollection<aramaürün>();
            yeşillik.ItemsSource = list;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var item = sender as Button;
            var obj = item.BindingContext as aramaürün;
            model.list.Add(obj);
            DisplayAlert("!!!", "Ürün Sepete Eklendi", "Tamam");

        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            var item = sender as ImageButton;
            var obj = item.BindingContext as aramaürün;
            beğeni.list.Add(obj);
            DisplayAlert("!!!", "Ürün Beğendiklerime Eklendi", "Tamam");
        }
    }
}