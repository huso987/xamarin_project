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
    public partial class Migrosev : ContentPage
    {
        List<aramaürün> list = new List<aramaürün>()
            {

                new aramaürün{ProductName ="Migros Ev Lezzetleri Tavuklu Pirinç Pilavı 210 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009224/19009224-0bc7d9.jpg",UnitPrice=21},
                 new aramaürün{ProductName ="Migros Ev Lezzetleri Şehriyeli Pirinç Pilavı 180 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009221/19009221-3cb24a.jpg",UnitPrice=21},
                  new aramaürün{ProductName ="Migros Ev Lezzetleri Tavuklu Trüflü Wrap 240 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009222/19009222-8babcf.jpg",UnitPrice=30},
                   new aramaürün{ProductName ="Migros Ev Lezzetleri Tahıllı Salata 170 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009233/19009233-2239b3.png",UnitPrice=20},
                 new aramaürün{ProductName ="Migros Ev Lezzetleri Antep Fıstıklı Sufle 140 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009225/19009225-15afd9.jpg",UnitPrice=22},
                  new aramaürün{ProductName ="Migros Ev Lezzetleri Izgara Köfte ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009864/19009864-adb1a7.jpg",UnitPrice=18 }
           };
        public Migrosev()
        {
            InitializeComponent();
            model.list = new ObservableCollection<aramaürün>();
            beğeni.list = new ObservableCollection<aramaürün>();
            migrosev.ItemsSource = list;
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