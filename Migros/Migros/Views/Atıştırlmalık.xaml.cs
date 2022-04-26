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
    public partial class SütKahvaltilik : ContentPage
    {
        public SütKahvaltilik()
        {
            InitializeComponent();
                       
        }

        private void button3_Clicked(object sender, EventArgs e)
        {
            button3.BackgroundColor = Color.Orange;
            button4.BackgroundColor = Color.White;
            button5.BackgroundColor = Color.White;
            bonibon.IsVisible = true;
            çikolata.IsVisible = true;
            züberbar.IsVisible = false;
            züberlokma.IsVisible = false;
            canga.IsVisible = false;
            hoşbeş.IsVisible = false;
        }

        private void button4_Clicked(object sender, EventArgs e)
        {
            button3.BackgroundColor = Color.White;
            button4.BackgroundColor = Color.Orange;
            button5.BackgroundColor = Color.White;

            züberbar.IsVisible = true;
            züberlokma.IsVisible=true;
            canga.IsVisible = false;
            hoşbeş.IsVisible=false;
            bonibon.IsVisible=false;
            çikolata.IsVisible=false;

        }

        private void button5_Clicked(object sender, EventArgs e)
        {
            button3.BackgroundColor = Color.White;
            button4.BackgroundColor = Color.White;
            button5.BackgroundColor = Color.Orange;
            züberbar.IsVisible = false;
            züberlokma.IsVisible = false;
            canga.IsVisible = true;
            hoşbeş.IsVisible = true;
            bonibon.IsVisible = false;
            çikolata.IsVisible = false;
        }
        public int i = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            i++;
            label7.Text = i.ToString();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                label7.Text = i.ToString();
            }
            else if (i <= 0)
            {
                i = 0;
                label7.Text = i.ToString();
            }
        }

        public int j=0;
        private void Button_Clicked_2(object sender, EventArgs e)
        {
            j++;
            label8.Text = j.ToString();
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            if (j > 0)
            {
                j--;
                label8.Text = j.ToString();
            }
            else if (j <= 0)
            {
                j = 0;
                label8.Text = j.ToString();
            }
        }
        public int k = 0;
        private void Button_Clicked_4(object sender, EventArgs e)
        {
            k++;
            label9.Text = k.ToString();
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            if (k > 0)
            {
                k--;
                label9.Text = k.ToString();
            }
            else if (k <= 0)
            {
                k = 0;
                label9.Text = k.ToString();
            }
        }
        public int h = 0;
        private void Button_Clicked_6(object sender, EventArgs e)
        {
            h++;
            label10.Text = h.ToString();
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {

            if (h > 0)
            {
                h--;
                label10.Text = h.ToString();
            }
            else if (h <= 0)
            {
                h = 0;
                label10.Text = h.ToString();
            }
        }
        public int a = 0;
        private void Button_Clicked_8(object sender, EventArgs e)
        {
            a++;
            label11.Text = a.ToString();
        }

        private void Button_Clicked_9(object sender, EventArgs e)
        {

            if (a > 0)
            {
                a--;
                label11.Text = a.ToString();
            }
            else if (a <= 0)
            {
                a = 0;
                label11.Text = a.ToString();
            }
        }

        public int b = 0;  
        private void Button_Clicked_10(object sender, EventArgs e)
        {
            b++;
            label12.Text = b.ToString();
        }

        private void Button_Clicked_11(object sender, EventArgs e)
        {
            if (b > 0)
            {
                b--;
                label12.Text = b.ToString();
            }
            else if (b <= 0)
            {
                b = 0;
                label12.Text = b.ToString();
            }
        }
    }
}