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
    public partial class Sebze : ContentPage
    {
        List<aramaürün> list = new List<aramaürün>()
            {

                new aramaürün{ProductName ="Hıyar Badem 500 G Paket Adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28136887/28136887-d4d1b2.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Soğan Kuru 1 Kg Paket Adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28424584/28424584-a228b2.jpg",UnitPrice=5},
                  new aramaürün{ProductName ="Mantar 400 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28240403/28240403-1c982b.png",UnitPrice=15},
                   new aramaürün{ProductName ="Havuç Beypazarı 1 Kg Paket Adet ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28129043/28129043-c68cb8.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Domates Şeker 250 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28090012/28090012-677771.jpg",UnitPrice=10},
                  new aramaürün{ProductName ="Patlıcan Kemer 500 G Paket Adet ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28309054/28309054-41821e.jpg",UnitPrice=12 }
           };
        public Sebze()
        {
            InitializeComponent();
            model.list = new ObservableCollection<aramaürün>();
            beğeni.list = new ObservableCollection<aramaürün>();
            sebzeler.ItemsSource = list;
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