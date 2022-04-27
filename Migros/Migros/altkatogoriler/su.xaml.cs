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
    public partial class su : ContentPage
    {
        List<aramaürün> list = new List<aramaürün>()
            {

                new aramaürün{ProductName ="Damla Doğal Kaynak Suyu 5 L",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08060303/08060303-536db6.jpg",UnitPrice=12},
                 new aramaürün{ProductName ="Erikli Su 1,5 L",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08060009/08060009-ff14b2.jpg",UnitPrice=6},
                  new aramaürün{ProductName ="Saka Doğal Mineralli Su 0,5 L",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08063000/08063000-1a3147.jpg",UnitPrice=3},
                   new aramaürün{ProductName ="Erikli Su 12x500 Ml ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08060028/08060028-53688c.jpg",UnitPrice=30},
                 new aramaürün{ProductName ="Erikli Su 0,5 L",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08062201/08062201-3aa86b.jpg",UnitPrice=3},
                  new aramaürün{ProductName ="Erikli Su 1 L  ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08062202/08062202-2eed0f.jpg",UnitPrice=6 }
           };
        public su()
        {
            InitializeComponent();
            model.list = new ObservableCollection<aramaürün>();
            beğeni.list = new ObservableCollection<aramaürün>();
            suşişe.ItemsSource = list;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var item = sender as Button;
            var obj = item.BindingContext as aramaürün;
            model.list.Add(obj);
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            var item = sender as ImageButton;
            var obj = item.BindingContext as aramaürün;
            beğeni.list.Add(obj);
        }
    }
}