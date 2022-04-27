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
    public partial class EtBalik : ContentPage
    {

        public EtBalik()
        {
            InitializeComponent();
                       
        }

        private void t_Clicked(object sender, EventArgs e)
        {
            t.BackgroundColor = Color.Orange;
            f.BackgroundColor = Color.White;
            Navigation.PushAsync(new altkatogoriler.Migrosev(), true);
        }

        private void f_Clicked(object sender, EventArgs e)
        {
            t.BackgroundColor = Color.White;
            f.BackgroundColor = Color.Orange;
            Navigation.PushAsync(new altkatogoriler.PizzaMiG(), true);
        }
    }
}