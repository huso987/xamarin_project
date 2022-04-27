using Migros.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Migros.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class baskett : ContentPage
    {

        public  baskett()
        {
            InitializeComponent();
            sepetürün.ItemsSource = model.list;
            if(sepetürün.ItemsSource != null)
            {
                hd.Text = model.list.Select(a => new { Converted = Convert.ToDouble(a.UnitPrice.ToString()) }).ToList().Sum(a => a.Converted).ToString("#,0.00");
            }
            beğeni.list = new ObservableCollection<aramaürün>();

        }



        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            var button = (ImageButton)sender;
            var item = (aramaürün)button.BindingContext;

            model.list.Remove(item);
            DisplayAlert("!!!", "Sepetden Ürün Çıkarıldı", "Tamam");




        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            var item = sender as ImageButton;
            var obj = item.BindingContext as aramaürün;
            beğeni.list.Add(obj);
            DisplayAlert("!!!", "Ürün Beğendiklerime Eklendi", "Tamam");
        }
    }
}