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
    public partial class enerjiiçeckler : ContentPage
    {
        List<aramaürün> list = new List<aramaürün>()
            {

                new aramaürün{ProductName ="Red Bull Enerji İçeceği 4x250 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08110031/08110031-27c603.jpg",UnitPrice=30},
                 new aramaürün{ProductName ="Black Bruin Energy Drink 250 ML",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08059344/08059344-15ddfa.jpg",UnitPrice=12},
                  new aramaürün{ProductName ="Monster Energy Enerji İçeceği 500 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08113143/08113143-a2f4aa.jpg",UnitPrice=5},
                   new aramaürün{ProductName ="Monster Rossi Enerji İçeceği 500 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08113152/08113152-6e87b9.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Monster Enerji İçeceği Mango Loco 500ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08113136/08113136-7c1ac9.jpg",UnitPrice=18},
                  new aramaürün{ProductName ="Red Bull Enerji İçeceği 473 Ml ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08110034/08110034-3902c3.jpg",UnitPrice=12 }
           };
        public enerjiiçeckler()
        {
            InitializeComponent();
            model.list = new ObservableCollection<aramaürün>();
            beğeni.list = new ObservableCollection<aramaürün>();
            enerjiiç.ItemsSource = list;
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