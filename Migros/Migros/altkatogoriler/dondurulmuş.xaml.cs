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
    public partial class dondurulmuş : ContentPage
    {
        List<aramaürün> list = new List<aramaürün>()
            {

                new aramaürün{ProductName ="Feast Ispanak 450 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/17014701/17014701-f9cc5f.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Feast Bezelye 450 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/17014576/17014576-1a72de.jpg",UnitPrice=15},
                  new aramaürün{ProductName ="Superfresh Doğranmış Soğan 450 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/17011060/17011060-0c5df1.jpg",UnitPrice=21},
                   new aramaürün{ProductName ="Superfresh Patatesli Garnitür 450 G ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/17011050/17011050-64f95e.jpg",UnitPrice=21},
                 new aramaürün{ProductName ="Superfresh Patates 1 Kg",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/17011040/17011040-3e510f.jpg",UnitPrice=9},
                  new aramaürün{ProductName ="Superfresh Taze Fasulye 450 G  ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/17011020/17011020-97f81e.jpg",UnitPrice=12 }
           };
        public dondurulmuş()
        {
            InitializeComponent();
            model.list = new ObservableCollection<aramaürün>();
            beğeni.list = new ObservableCollection<aramaürün>();
            dond.ItemsSource = list;
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