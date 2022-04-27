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
    public partial class meze : ContentPage
    {
        List<aramaürün> list = new List<aramaürün>()
            {

                new aramaürün{ProductName ="Mezzetürk Rus Salatası 300 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19000913/mezzeturk-rus-salatasi-300-gr-ff4de8.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Mezzetürk Yaprak Sarma 300 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19000910/mezzeturk-yaprak-sarma-300-gr-e37a82.jpg",UnitPrice=15},
                  new aramaürün{ProductName ="Gurumen Haydari 200 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009856/19009856-8e659a.jpg",UnitPrice=21},
                   new aramaürün{ProductName ="Gurumen Şakşuka 200 G ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009855/19009855-633d16.jpg",UnitPrice=21},
                 new aramaürün{ProductName ="Biberes Ev Acıkası 200 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19001941/19001941-30e543.jpg",UnitPrice=9},
                  new aramaürün{ProductName ="Biberes Acı Ezme 200 G  ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19001939/19001939-0e0f25.jpg",UnitPrice=12 }
           };
        public meze()
        {
            InitializeComponent();
            model.list = new ObservableCollection<aramaürün>();
            beğeni.list = new ObservableCollection<aramaürün>();
            mez.ItemsSource = list;
        }

        public static List<aramaürün> ItemsSource { get; private set; }

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