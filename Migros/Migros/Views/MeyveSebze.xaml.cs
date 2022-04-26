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

      

        private void button6_Clicked(object sender, EventArgs e)
        {
            button6.BackgroundColor = Color.Orange;
            button7.BackgroundColor = Color.White;
            button8.BackgroundColor = Color.White;
            limon.IsVisible = true;
            avokado.IsVisible = true;
            hıyar.IsVisible = false;
            domates.IsVisible = false;
            maydanoz.IsVisible = false;
            salata.IsVisible = false;
        }

        private void button7_Clicked(object sender, EventArgs e)
        {
            button6.BackgroundColor = Color.White;
            button7.BackgroundColor = Color.Orange;
            button8.BackgroundColor = Color.White;
            limon.IsVisible = false;
            avokado.IsVisible = false;
            hıyar.IsVisible = true;
            domates.IsVisible = true;
            maydanoz.IsVisible = false;
            salata.IsVisible = false;
        }

        private void button8_Clicked(object sender, EventArgs e)
        {
            button6.BackgroundColor = Color.White;
            button7.BackgroundColor = Color.White;
            button8.BackgroundColor = Color.Orange;
            limon.IsVisible = false;
            avokado.IsVisible = false;
            hıyar.IsVisible = false;
            domates.IsVisible = false;
            maydanoz.IsVisible = true;
            salata.IsVisible = true;
        }
        public int i = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            i++;
            label13.Text = i.ToString();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                label13.Text = i.ToString();
            }
            else if (i <= 0)
            {
                i = 0;
                label13.Text = i.ToString();
            }
        }
        public int j = 0;
        private void Button_Clicked_2(object sender, EventArgs e)
        {
            j++;
            label14.Text = j.ToString();
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            if (j > 0)
            {
                j--;
                label14.Text = j.ToString();
            }
            else if (j <= 0)
            {
                j = 0;
                label14.Text = j.ToString();
            }
        }
        public int k = 0;
        private void Button_Clicked_4(object sender, EventArgs e)
        {
            k++;
            label15.Text = k.ToString();
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            if (k > 0)
            {
                k--;
                label15.Text = k.ToString();
            }
            else if (k <= 0)
            {
                k = 0;
                label15.Text = k.ToString();
            }
        }
        public int a = 0;
        private void Button_Clicked_6(object sender, EventArgs e)
        {
            a++;
            label16.Text = a.ToString();
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            if (a > 0)
            {
                a--;
                label16.Text = a.ToString();
            }
            else if (a <= 0)
            {
                a = 0;
                label16.Text = a.ToString();
            }
        }
        public int b = 0;
        private void Button_Clicked_8(object sender, EventArgs e)
        {
            b++;
            label17.Text = b.ToString();
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {
            if (b > 0)
            {
                b--;
                label17.Text = b.ToString();
            }
            else if (b <= 0)
            {
                b = 0;
                label17.Text = b.ToString();
            }
        }
        public int c = 0;
        private void Button_Clicked_10(object sender, EventArgs e)
        {
            c++;
            label18.Text = c.ToString();
        }

        private void Button_Clicked_11(object sender, EventArgs e)
        {
            if (c > 0)
            {
                c--;
                label18.Text = c.ToString();
            }
            else if (c <= 0)
            {
                c = 0;
                label18.Text = c.ToString();
            }
        }
    }
}