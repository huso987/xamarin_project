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
    public partial class çikolata : ContentPage
    {
        List<aramaürün> list = new List<aramaürün>()
            {

                new aramaürün{ProductName ="Nestle Damak Antep Fıstıklı Baklavalı Beyaz Çikolata 60G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07033892/07033892-3e26b3.jpg",UnitPrice=5},
                 new aramaürün{ProductName ="Nestle Classic Bitter Kare Çikolata 60 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07037273/07037273-57e752.jpg",UnitPrice=5},
                  new aramaürün{ProductName ="Ülker Bütün Antep Fıstıklı Sütlü Kare Çikolata 65G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07034568/07034568-d8397c.jpg",UnitPrice=5},
                   new aramaürün{ProductName ="Milka Çilekli Yoğurtlu Tablet Çikolata 100 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07040658/07040658-987649.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Nestle Classic Sütlü Kare Çikolata 60 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07037274/07037274-5a80b4.jpg",UnitPrice=18},
                  new aramaürün{ProductName ="Eti Karam %70 Kakaolu Bitter Çikolata 60 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07036372/07036372-b80d70.jpg",UnitPrice=12 }
           };
        public çikolata()
        {
            InitializeComponent();
            model.list = new ObservableCollection<aramaürün>();
            beğeni.list = new ObservableCollection<aramaürün>();
            çikolat.ItemsSource = list;
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