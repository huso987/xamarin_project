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
    public partial class gofret : ContentPage
    {
        List<aramaürün> list = new List<aramaürün>()
            {

                new aramaürün{ProductName ="Hoşbeş Fındıklı Gofret 142 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07160087/07160087-f67967.jpg",UnitPrice=5},
                 new aramaürün{ProductName ="Eti Karam Gurme Bitter Çikolatalı Kremalı Gofret 50 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07160817/07160817-ef9a8d.jpg",UnitPrice=5},
                  new aramaürün{ProductName ="Eti Bidolu Kakao Kremalı Yerfıstıklı Gofret 81 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07168282/07168282-c3f46c.jpg",UnitPrice=5},
                   new aramaürün{ProductName ="Eti Hoşbeş Kakao Kremalı Gofret 142 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07160123/eti-hosbes-kakao-kremali-gofret-142g-55ebc6.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Eti Hoşbeş Misket Limonlu Kremalı Gofret 66 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07160382/07160382-efe365.jpg",UnitPrice=18},
                  new aramaürün{ProductName ="Eti Hoşbeş Çilekli Gofret 142 G ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07160086/eti-hosbes-cilekli-gofret-142g-605607.jpg",UnitPrice=12 }
           };
        public gofret()
        {
            InitializeComponent();
            model.list = new ObservableCollection<aramaürün>();
            beğeni.list = new ObservableCollection<aramaürün>();
            gof.ItemsSource = list;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var item = sender as Button;
            var obj = item.BindingContext as aramaürün;
            model.list.Add(obj);
            DisplayAlert("!!!", "Ürün Sepete Eklendi", "Tamam");


        }

        private void begeni_Clicked(object sender, EventArgs e)
        {
            var item = sender as ImageButton;
            var obj = item.BindingContext as aramaürün;
            beğeni.list.Add(obj);
            DisplayAlert("!!!", "Ürün Beğendiklerime Eklendi", "Tamam");
        }
    }
}