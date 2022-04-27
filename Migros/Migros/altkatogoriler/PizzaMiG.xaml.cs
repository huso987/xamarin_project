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
    public partial class PizzaMiG : ContentPage
    {
        List<aramaürün> list = new List<aramaürün>()
            {

                new aramaürün{ProductName ="Pizza Mi-go Karışık Pizza 545G Dondurulmuş (Yeni)",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/05060619/05060619-89c102.jpg",UnitPrice=25},
                 new aramaürün{ProductName ="Pizza Mi-go Peynirli Pizza 475G Dondurulmuş Yeni",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/05060617/05060617-8b497e.jpg",UnitPrice=25},
                  new aramaürün{ProductName ="Pizza Mi-go Jambon - Chedarlı 520G Dondurulmuş Yeni",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/05060618/05060618-9d28cb.jpg",UnitPrice=25}
        };
        public PizzaMiG()
        {
            InitializeComponent();
            model.list = new ObservableCollection<aramaürün>();
            beğeni.list = new ObservableCollection<aramaürün>();
            pizzamigo.ItemsSource = list;
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
            DisplayAlert("!!!", "Ürün Beğendiklerime  Eklendi", "Tamam");
        }
    }
}