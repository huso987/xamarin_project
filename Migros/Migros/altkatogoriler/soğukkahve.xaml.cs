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
    public partial class soğukkahve : ContentPage
    {
        List<aramaürün> list = new List<aramaürün>()
            {

                new aramaürün{ProductName ="Nescafe Xpress Latte Original Soğuk Kahve 250 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08059620/08059620-3f79fe.jpg",UnitPrice=5},
                 new aramaürün{ProductName ="Starbucks Chilled Classics Caramel Macchiato 220 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08059619/08059619-f2d66f.jpg",UnitPrice=5},
                  new aramaürün{ProductName ="Starbucks Doubleshot Espresso Milk 200 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08089618/08089618-16d25c.jpg",UnitPrice=5},
                   new aramaürün{ProductName ="Obsesso Iced Chai Tea Latte Sütlü Çaylı İçecek 250 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08052131/08052131-e03e18.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Obsesso Caramel Macchiato Soğuk Kahve 250 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08053257/08053257-da5851.jpg",UnitPrice=18},
                  new aramaürün{ProductName ="Nescafe Xpress Karamel Aromalı Kahveli Sütlü İçecek 250 ml ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08079715/08079715-009b89.jpg",UnitPrice=12 }
           };
        public soğukkahve()
        {
            InitializeComponent();
            model.list = new ObservableCollection<aramaürün>();
            beğeni.list = new ObservableCollection<aramaürün>();
            soguk.ItemsSource = list;
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