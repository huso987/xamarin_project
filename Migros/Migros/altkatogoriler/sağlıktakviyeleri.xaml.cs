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
    public partial class sağlıktakviyeleri : ContentPage
    {

        List<aramaürün> list = new List<aramaürün>()
            {

                new aramaürün{ProductName ="Effer-C-Vitamin C Sambucus Karışık Meyve Aromalı 20 Şase",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/34511145/34511145-ed0b7b.jpg",UnitPrice=70},
                 new aramaürün{ProductName ="Nature's Supreme Vitamin C + Zinc 20 Efervesan Tablet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/34510435/34510435-652539.jpg",UnitPrice=70},
                  new aramaürün{ProductName ="Talya Omega 3 60 Softgel 1000 Mg",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/34510406/34510406-5e57a7.jpg",UnitPrice=78},
                   new aramaürün{ProductName ="Natures Supreme Beauty Collagen 30 Tablet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/34511173/34511173-d1f2c1.png",UnitPrice=90},
                 new aramaürün{ProductName ="Talya Omega 3-6-9 60 Softgel",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/34510407/34510407-9cd358.jpg",UnitPrice=98},
                  new aramaürün{ProductName ="Effer-C-Vitamin C Portakal Aromalı 20 Şase ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/34511144/34511144-e812b9.jpg",UnitPrice=72 }
           };
        public sağlıktakviyeleri()
        {
            InitializeComponent();
            model.list = new ObservableCollection<aramaürün>();
            beğeni.list = new ObservableCollection<aramaürün>();
            sağlıktak.ItemsSource = list;
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