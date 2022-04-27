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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void a_Clicked(object sender, EventArgs e)
        {
            a.BackgroundColor = Color.Orange;
            b.BackgroundColor = Color.White;
            Navigation.PushAsync(new altkatogoriler.meze(), true);
        }

        private void b_Clicked(object sender, EventArgs e)
        {
            a.BackgroundColor = Color.White;
            b.BackgroundColor = Color.Orange;
            Navigation.PushAsync(new altkatogoriler.dondurulmuş(), true);
        }
    }
}