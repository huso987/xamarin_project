using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Migros.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Hareketegeç : ContentPage
    {
        public Hareketegeç()
        {
            InitializeComponent();
        }

        private void y_Clicked(object sender, EventArgs e)
        {
            y.BackgroundColor = Color.Orange;
            ı.BackgroundColor = Color.White;
            Navigation.PushAsync(new altkatogoriler.sağlıktakviyeleri(), true);
        }

        private void ı_Clicked(object sender, EventArgs e)
        {
            y.BackgroundColor = Color.White;
            ı.BackgroundColor = Color.Orange;
            Navigation.PushAsync(new altkatogoriler.enerjiiçeckler(), true);
        }
    }
}