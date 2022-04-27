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
    public partial class MeyveSebze : ContentPage
    {
        public MeyveSebze()
        {
            InitializeComponent();
                       
        }
        // meyve
        private void Button_Clicked(object sender, EventArgs e)
        {
            x.BackgroundColor = Color.Orange;
            y.BackgroundColor = Color.White;
            z.BackgroundColor = Color.White;
            Navigation.PushAsync(new altkatogoriler.Meyve(), true);
        }

        // sebze
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            x.BackgroundColor = Color.White;
            y.BackgroundColor = Color.Orange;
            z.BackgroundColor = Color.White;
            Navigation.PushAsync(new altkatogoriler.Sebze(), true);
        }
        // yeşillik
        private void Button_Clicked_2(object sender, EventArgs e)
        {
            x.BackgroundColor = Color.White;
            y.BackgroundColor = Color.White;
            z.BackgroundColor = Color.Orange;
            Navigation.PushAsync(new altkatogoriler.Yeşillik(), true);
        }
    }
}