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
    public partial class İçecek : ContentPage
    {
        public İçecek()
        {
            InitializeComponent();
        }

        private void s_Clicked(object sender, EventArgs e)
        {
            s.BackgroundColor = Color.Orange;
            m.BackgroundColor = Color.White;
            g.BackgroundColor = Color.White;
            k.BackgroundColor = Color.White;
            Navigation.PushAsync(new altkatogoriler.su(), true);
        }

        private void m_Clicked(object sender, EventArgs e)
        {
            s.BackgroundColor = Color.White;
            m.BackgroundColor = Color.Orange;
            g.BackgroundColor = Color.White;
            k.BackgroundColor = Color.White;
            Navigation.PushAsync(new altkatogoriler.madensuyu(), true);
        }

        private void g_Clicked(object sender, EventArgs e)
        {
            s.BackgroundColor = Color.White;
            m.BackgroundColor = Color.White;
            g.BackgroundColor = Color.Orange;
            k.BackgroundColor = Color.White;
            Navigation.PushAsync(new altkatogoriler.gazlıçecek(), true);
        }

        private void k_Clicked(object sender, EventArgs e)
        {
            s.BackgroundColor = Color.Orange;
            m.BackgroundColor = Color.White;
            g.BackgroundColor = Color.White;
            k.BackgroundColor = Color.White;
            Navigation.PushAsync(new altkatogoriler.soğukkahve(), true);
        }
    }
}