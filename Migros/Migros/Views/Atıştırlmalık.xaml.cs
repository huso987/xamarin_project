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
            Navigation.PushAsync(new altkatogoriler.çikolata(), true);

        }

        private void button4_Clicked(object sender, EventArgs e)
        {
            button3.BackgroundColor = Color.White;
            button4.BackgroundColor = Color.Orange;
            button5.BackgroundColor = Color.White;
            Navigation.PushAsync(new altkatogoriler.bar(), true);



        }

        private void button5_Clicked(object sender, EventArgs e)
        {
            button3.BackgroundColor = Color.White;
            button4.BackgroundColor = Color.White;
            button5.BackgroundColor = Color.Orange;
            Navigation.PushAsync(new altkatogoriler.gofret(), true);

        }
        
        
        

       
    }
}