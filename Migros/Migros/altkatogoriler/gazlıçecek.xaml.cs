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
    public partial class gazlıçecek : ContentPage
    {
        List<aramaürün> list = new List<aramaürün>()
            {

                new aramaürün{ProductName ="Coca-Cola Zero Sugar 6X250 Ml Kutu",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08019112/08019112-843f91.png",UnitPrice=5},
                 new aramaürün{ProductName ="Coca-Cola Zero Sugar 1 L",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08010701/08010701-8c549e.png",UnitPrice=5},
                  new aramaürün{ProductName ="Pepsi Cola Max Pet 1.5 L",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08011010/08011010-d2200d.jpg",UnitPrice=5},
                   new aramaürün{ProductName ="Uludağ Efsane Gazoz 6X250 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08038901/08038901-943be3.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Schweppes Misket Limonu Ve Nane Aromalı Gazlı İçecek Pet 1 L",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08022718/08022718-ecb57b.png",UnitPrice=18},
                  new aramaürün{ProductName ="Uludağ Sıfır Kalori Tonik 250 Ml ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08038956/08038956-060641.jpg",UnitPrice=12 }
           };
        public gazlıçecek()
        {
            InitializeComponent();
            model.list = new ObservableCollection<aramaürün>();
            beğeni.list = new ObservableCollection<aramaürün>();
            gazlı.ItemsSource = list;
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