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
    public partial class Anasayfa : ContentPage
    {
        public Anasayfa()
        {
            InitializeComponent();

            var names = new List<string>
            {

                "mohammed", "ahmed","marven","cihad"
            };

            var images = new List<string>
            {
                "https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/banner/main_page_slider/25112/27146-_hemenramazan_3420x900-72190d.png",
                "https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/banner/main_page_slider/25392/27426-web_hemen_meyvesebze-f6faca.png",
                "https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/banner/main_page_slider/21710/23744-791_hemen_web_banner_ucretsiz_teslimat-4518f1.png",
                "https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/banner/main_page_slider/20901/22935-784_hemen_web_slider_20_tl_indirim(1)-b98bf3.png",
                "https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/banner/main_page_slider/25857/27891-web_oyuncak_badgeli-9aa24e.png"
            };


            Slider.ItemsSource = images;
        }

        

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            //meyvesebze
            Navigation.PushAsync(new MeyveSebze(), true);
        }

        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            //Taze sıcak ev yemekleri 
            Navigation.PushAsync(new EtBalik(), true);
        }

        private void ImageButton_Clicked_3(object sender, EventArgs e)
        { 
            //atıştırmalık olarak belirlendi
            Navigation.PushAsync(new SütKahvaltilik(), true);
        }

      
        private void aramacubugu_SearchButtonPressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new arama(), true);
        }

    }
}