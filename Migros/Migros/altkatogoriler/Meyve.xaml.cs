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
    public partial class Meyve : ContentPage
    {

        List<aramaürün> list = new List<aramaürün>()
            {

                new aramaürün{ProductName ="Limon Ekstra 1 Kg Paket Adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/27268060/27268060-1760f1.jpg",UnitPrice=1},
                 new aramaürün{ProductName ="Avokado Adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28010004/28010004-10a053.jpg",UnitPrice=3},
                  new aramaürün{ProductName ="Muz Yerli Adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/27272021/27272021-c635a7.jpg",UnitPrice=3},
                   new aramaürün{ProductName ="Ananas Adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/27501003/-ananas-adet-c1fa49.jpg",UnitPrice=30},
                 new aramaürün{ProductName ="Elma Granny 1 Kg Paket Adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/27139293/27139293-d34d67.jpg",UnitPrice=11},
                  new aramaürün{ProductName ="Portakal Sıkma File 3 Kg Paket Adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/27307070/27307070-97eb24.jpg",UnitPrice=18 }
           };
        public Meyve()
        {
            InitializeComponent();
            model.list = new ObservableCollection<aramaürün>();
            beğeni.list = new ObservableCollection<aramaürün>();
            meyveler.ItemsSource = list;
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