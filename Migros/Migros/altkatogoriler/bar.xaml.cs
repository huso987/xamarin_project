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
    public partial class bar : ContentPage
    {
        List<aramaürün> list = new List<aramaürün>()
            {

                new aramaürün{ProductName ="Eti Lifalif Bitter Çikolatalı Yulaf Bar 35 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07169801/07169801-7f1423.jpg",UnitPrice=5},
                 new aramaürün{ProductName ="Eti Lifalif Kuruyemişli Yulaf Bar 35 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07169802/07169802-1cc274.jpg",UnitPrice=5},
                  new aramaürün{ProductName ="Eti Lifalif Kırmızı Meyveli Yulaf Bar 35 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07161717/07161717-d8db81.jpg",UnitPrice=5},
                   new aramaürün{ProductName ="Nestle Nesfit Çikolata Bar 23,5 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/05099121/05099121-0a14eb.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Nestle Nesfit Çilekli Bar 23,5 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/05099120/05099120-0c9186.jpg",UnitPrice=18},
                  new aramaürün{ProductName ="Tadım Antep Fıstıklı Bar 27 G ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07080787/07080787-3a66de.jpg",UnitPrice=12 }
           };
        public bar()
        {
            InitializeComponent();
            model.list = new ObservableCollection<aramaürün>();
            beğeni.list = new ObservableCollection<aramaürün>();
            bard.ItemsSource = list;
            
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