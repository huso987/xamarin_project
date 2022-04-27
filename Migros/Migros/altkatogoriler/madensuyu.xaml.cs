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
    public partial class madensuyu : ContentPage
    {
        List<aramaürün> list = new List<aramaürün>()
            {

                new aramaürün{ProductName ="Uludağ Doğal Maden Suyu 6X200 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08040650/08040650-1e05f1.jpg",UnitPrice=7},
                 new aramaürün{ProductName ="Sırma Doğal Maden Suyu 6x200 Ml Cam",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08040900/08040900-ce837c.jpg",UnitPrice=8},
                  new aramaürün{ProductName ="Kızılay Afyonkarahisar Doğal Maden Suyu 6X200 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08040655/08040655-406cca.jpg",UnitPrice=7},
                   new aramaürün{ProductName ="Akmina Maden Suyu 1 L",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08040923/08040923-d06826.png",UnitPrice=9},
                 new aramaürün{ProductName ="Akmina Doğal Maden Suyu Pet 6X250 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08040978/08040978-43bca8.jpg",UnitPrice=18},
                  new aramaürün{ProductName ="Akmina Limon Aromalı Maden Suyu 6X200 Ml ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08040943/08040943-286413.png",UnitPrice=12 }
           };
        public madensuyu()
        {
            InitializeComponent();
            model.list = new ObservableCollection<aramaürün>();
            beğeni.list = new ObservableCollection<aramaürün>();
            maden.ItemsSource = list;
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