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
        

        private async void Button_Clicked(object sender, EventArgs e)
        {
            
            button1.BackgroundColor = Color.Orange;       
            button2.BackgroundColor = Color.White;
            peynirli.IsVisible = false;
            jambon.IsVisible = false;
            karışık.IsVisible = false;
            tavuklu.IsVisible = true;
            şehriyeli.IsVisible = true;
            wrap.IsVisible = true;

        }

        private void button2_Clicked(object sender, EventArgs e)
        {
            button2.BackgroundColor = Color.Orange;
            button1.BackgroundColor = Color.White;
            tavuklu.IsVisible = false;
            şehriyeli.IsVisible = false;
            wrap.IsVisible = false;
            peynirli.IsVisible = true;
            karışık.IsVisible = true;
            jambon.IsVisible=true;
        }

        public int i=0;
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            i++;
            label1.Text = i.ToString();
           
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
           if(i>0)
            {
                i--;
                label1.Text = i.ToString();
            }
           else if(i<=0)
            {
                i= 0;
                label1.Text =i.ToString();
            }
              
        }
        public int j = 0;

        private void Button_Clicked_3(object sender, EventArgs e)
        {

            if (j > 0)
            {
                j--;
                label2.Text = j.ToString();
            }
            else if (j <= 0)
            {
                i = 0;
                label2.Text = j.ToString();
            }
        }
        
        private void Button_Clicked_4(object sender, EventArgs e)
        {
            j++;
            label2.Text=j.ToString();
        }

        public int k = 0;
        private void Button_Clicked_5(object sender, EventArgs e)
        {
            k++;
            label3.Text = k.ToString();
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            if (k > 0)
            {
                k--;
                label3.Text = k.ToString();
            }
            else if (k <= 0)
            {
                k = 0;
                label3.Text = k.ToString();
            }
        }
        public int a = 0;
        private void Button_Clicked_7(object sender, EventArgs e)
        {
            a++;
            label4.Text = a.ToString();
        }

        private void Button_Clicked_8(object sender, EventArgs e)
        {
            if (a > 0)
            {
                a--;
                label4.Text = a.ToString();
            }
            else if (a <= 0)
            {
                a = 0;
                label4.Text = a.ToString();
            }
        }
        public int b = 0;
        private void Button_Clicked_9(object sender, EventArgs e)
        {
            b++;
            label5.Text = b.ToString();
        }

        private void Button_Clicked_10(object sender, EventArgs e)
        {
            if (b > 0)
            {
                b--;
                label5.Text = b.ToString();
            }
            else if (b <= 0)
            {
                b = 0;
                label5.Text = b.ToString();
            }

        }
        public int c = 0;
        private void Button_Clicked_11(object sender, EventArgs e)
        {
            c++;
            label6.Text = c.ToString();
        }

        private void Button_Clicked_12(object sender, EventArgs e)
        {
            if (c > 0)
            {
                c--;
                label6.Text = c.ToString();
            }
            else if (c <= 0)
            {
                c = 0;
                label6.Text = b.ToString();
            }
        }
    }
}