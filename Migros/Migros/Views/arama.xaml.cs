using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Migros.Models;
using System.Collections.ObjectModel;

namespace Migros.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class arama : ContentPage
    {
        List<aramaürün> list = new List<aramaürün>()
            {
                new aramaürün{ProductName ="Eti Lifalif Bitter Çikolatalı Yulaf Bar 35 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07169801/07169801-7f1423.jpg",UnitPrice=5},
                 new aramaürün{ProductName ="Eti Lifalif Kuruyemişli Yulaf Bar 35 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07169802/07169802-1cc274.jpg",UnitPrice=5},
                  new aramaürün{ProductName ="Eti Lifalif Kırmızı Meyveli Yulaf Bar 35 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07161717/07161717-d8db81.jpg",UnitPrice=5},
                   new aramaürün{ProductName ="Nestle Nesfit Çikolata Bar 23,5 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/05099121/05099121-0a14eb.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Nestle Nesfit Çilekli Bar 23,5 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/05099120/05099120-0c9186.jpg",UnitPrice=18},
                  new aramaürün{ProductName ="Tadım Antep Fıstıklı Bar 27 G ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07080787/07080787-3a66de.jpg",UnitPrice=12 },
                   new aramaürün{ProductName ="Nestle Damak Antep Fıstıklı Baklavalı Beyaz Çikolata 60G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07033892/07033892-3e26b3.jpg",UnitPrice=5},
                 new aramaürün{ProductName ="Nestle Classic Bitter Kare Çikolata 60 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07037273/07037273-57e752.jpg",UnitPrice=5},
                  new aramaürün{ProductName ="Ülker Bütün Antep Fıstıklı Sütlü Kare Çikolata 65G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07034568/07034568-d8397c.jpg",UnitPrice=5},
                   new aramaürün{ProductName ="Milka Çilekli Yoğurtlu Tablet Çikolata 100 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07040658/07040658-987649.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Nestle Classic Sütlü Kare Çikolata 60 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07037274/07037274-5a80b4.jpg",UnitPrice=18},
                  new aramaürün{ProductName ="Eti Karam %70 Kakaolu Bitter Çikolata 60 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07036372/07036372-b80d70.jpg",UnitPrice=12 },
                  new aramaürün{ProductName ="Feast Ispanak 450 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/17014701/17014701-f9cc5f.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Feast Bezelye 450 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/17014576/17014576-1a72de.jpg",UnitPrice=15},
                  new aramaürün{ProductName ="Superfresh Doğranmış Soğan 450 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/17011060/17011060-0c5df1.jpg",UnitPrice=21},
                   new aramaürün{ProductName ="Superfresh Patatesli Garnitür 450 G ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/17011050/17011050-64f95e.jpg",UnitPrice=21},
                 new aramaürün{ProductName ="Superfresh Patates 1 Kg",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/17011040/17011040-3e510f.jpg",UnitPrice=9},
                  new aramaürün{ProductName ="Superfresh Taze Fasulye 450 G  ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/17011020/17011020-97f81e.jpg",UnitPrice=12 },
                  new aramaürün{ProductName ="Red Bull Enerji İçeceği 4x250 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08110031/08110031-27c603.jpg",UnitPrice=30},
                 new aramaürün{ProductName ="Black Bruin Energy Drink 250 ML",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08059344/08059344-15ddfa.jpg",UnitPrice=12},
                  new aramaürün{ProductName ="Monster Energy Enerji İçeceği 500 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08113143/08113143-a2f4aa.jpg",UnitPrice=5},
                   new aramaürün{ProductName ="Monster Rossi Enerji İçeceği 500 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08113152/08113152-6e87b9.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Monster Enerji İçeceği Mango Loco 500ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08113136/08113136-7c1ac9.jpg",UnitPrice=18},
                  new aramaürün{ProductName ="Red Bull Enerji İçeceği 473 Ml ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08110034/08110034-3902c3.jpg",UnitPrice=12 },
                  new aramaürün{ProductName ="Coca-Cola Zero Sugar 6X250 Ml Kutu",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08019112/08019112-843f91.png",UnitPrice=5},
                 new aramaürün{ProductName ="Coca-Cola Zero Sugar 1 L",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08010701/08010701-8c549e.png",UnitPrice=5},
                  new aramaürün{ProductName ="Pepsi Cola Max Pet 1.5 L",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08011010/08011010-d2200d.jpg",UnitPrice=5},
                   new aramaürün{ProductName ="Uludağ Efsane Gazoz 6X250 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08038901/08038901-943be3.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Schweppes Misket Limonu Ve Nane Aromalı Gazlı İçecek Pet 1 L",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08022718/08022718-ecb57b.png",UnitPrice=18},
                  new aramaürün{ProductName ="Uludağ Sıfır Kalori Tonik 250 Ml ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08038956/08038956-060641.jpg",UnitPrice=12 },
                   new aramaürün{ProductName ="Hoşbeş Fındıklı Gofret 142 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07160087/07160087-f67967.jpg",UnitPrice=5},
                 new aramaürün{ProductName ="Eti Karam Gurme Bitter Çikolatalı Kremalı Gofret 50 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07160817/07160817-ef9a8d.jpg",UnitPrice=5},
                  new aramaürün{ProductName ="Eti Bidolu Kakao Kremalı Yerfıstıklı Gofret 81 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07168282/07168282-c3f46c.jpg",UnitPrice=5},
                   new aramaürün{ProductName ="Eti Hoşbeş Kakao Kremalı Gofret 142 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07160123/eti-hosbes-kakao-kremali-gofret-142g-55ebc6.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Eti Hoşbeş Misket Limonlu Kremalı Gofret 66 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07160382/07160382-efe365.jpg",UnitPrice=18},
                  new aramaürün{ProductName ="Eti Hoşbeş Çilekli Gofret 142 G ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/07160086/eti-hosbes-cilekli-gofret-142g-605607.jpg",UnitPrice=12 },
                   new aramaürün{ProductName ="Uludağ Doğal Maden Suyu 6X200 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08040650/08040650-1e05f1.jpg",UnitPrice=7},
                 new aramaürün{ProductName ="Sırma Doğal Maden Suyu 6x200 Ml Cam",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08040900/08040900-ce837c.jpg",UnitPrice=8},
                  new aramaürün{ProductName ="Kızılay Afyonkarahisar Doğal Maden Suyu 6X200 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08040655/08040655-406cca.jpg",UnitPrice=7},
                   new aramaürün{ProductName ="Akmina Maden Suyu 1 L",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08040923/08040923-d06826.png",UnitPrice=9},
                 new aramaürün{ProductName ="Akmina Doğal Maden Suyu Pet 6X250 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08040978/08040978-43bca8.jpg",UnitPrice=18},
                  new aramaürün{ProductName ="Akmina Limon Aromalı Maden Suyu 6X200 Ml ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08040943/08040943-286413.png",UnitPrice=12 },
                  new aramaürün{ProductName ="Limon Ekstra 1 Kg Paket Adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/27268060/27268060-1760f1.jpg",UnitPrice=1},
                 new aramaürün{ProductName ="Avokado Adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28010004/28010004-10a053.jpg",UnitPrice=3},
                  new aramaürün{ProductName ="Muz Yerli Adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/27272021/27272021-c635a7.jpg",UnitPrice=3},
                   new aramaürün{ProductName ="Ananas Adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/27501003/-ananas-adet-c1fa49.jpg",UnitPrice=30},
                 new aramaürün{ProductName ="Elma Granny 1 Kg Paket Adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/27139293/27139293-d34d67.jpg",UnitPrice=11},
                  new aramaürün{ProductName ="Portakal Sıkma File 3 Kg Paket Adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/27307070/27307070-97eb24.jpg",UnitPrice=18 },
                  new aramaürün{ProductName ="Mezzetürk Rus Salatası 300 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19000913/mezzeturk-rus-salatasi-300-gr-ff4de8.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Mezzetürk Yaprak Sarma 300 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19000910/mezzeturk-yaprak-sarma-300-gr-e37a82.jpg",UnitPrice=15},
                  new aramaürün{ProductName ="Gurumen Haydari 200 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009856/19009856-8e659a.jpg",UnitPrice=21},
                   new aramaürün{ProductName ="Gurumen Şakşuka 200 G ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009855/19009855-633d16.jpg",UnitPrice=21},
                 new aramaürün{ProductName ="Biberes Ev Acıkası 200 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19001941/19001941-30e543.jpg",UnitPrice=9},
                  new aramaürün{ProductName ="Biberes Acı Ezme 200 G  ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19001939/19001939-0e0f25.jpg",UnitPrice=12 },
                   new aramaürün{ProductName ="Migros Ev Lezzetleri Tavuklu Pirinç Pilavı 210 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009224/19009224-0bc7d9.jpg",UnitPrice=21},
                 new aramaürün{ProductName ="Migros Ev Lezzetleri Şehriyeli Pirinç Pilavı 180 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009221/19009221-3cb24a.jpg",UnitPrice=21},
                  new aramaürün{ProductName ="Migros Ev Lezzetleri Tavuklu Trüflü Wrap 240 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009222/19009222-8babcf.jpg",UnitPrice=30},
                   new aramaürün{ProductName ="Migros Ev Lezzetleri Tahıllı Salata 170 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009233/19009233-2239b3.png",UnitPrice=20},
                 new aramaürün{ProductName ="Migros Ev Lezzetleri Antep Fıstıklı Sufle 140 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009225/19009225-15afd9.jpg",UnitPrice=22},
                  new aramaürün{ProductName ="Migros Ev Lezzetleri Izgara Köfte ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/19009864/19009864-adb1a7.jpg",UnitPrice=18 },
                  new aramaürün{ProductName ="Pizza Mi-go Karışık Pizza 545G Dondurulmuş (Yeni)",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/05060619/05060619-89c102.jpg",UnitPrice=25},
                 new aramaürün{ProductName ="Pizza Mi-go Peynirli Pizza 475G Dondurulmuş Yeni",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/05060617/05060617-8b497e.jpg",UnitPrice=25},
                  new aramaürün{ProductName ="Pizza Mi-go Jambon - Chedarlı 520G Dondurulmuş Yeni",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/05060618/05060618-9d28cb.jpg",UnitPrice=25},
                  new aramaürün{ProductName ="Effer-C-Vitamin C Sambucus Karışık Meyve Aromalı 20 Şase",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/34511145/34511145-ed0b7b.jpg",UnitPrice=70},
                 new aramaürün{ProductName ="Nature's Supreme Vitamin C + Zinc 20 Efervesan Tablet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/34510435/34510435-652539.jpg",UnitPrice=70},
                  new aramaürün{ProductName ="Talya Omega 3 60 Softgel 1000 Mg",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/34510406/34510406-5e57a7.jpg",UnitPrice=78},
                   new aramaürün{ProductName ="Natures Supreme Beauty Collagen 30 Tablet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/34511173/34511173-d1f2c1.png",UnitPrice=90},
                 new aramaürün{ProductName ="Talya Omega 3-6-9 60 Softgel",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/34510407/34510407-9cd358.jpg",UnitPrice=98},
                  new aramaürün{ProductName ="Effer-C-Vitamin C Portakal Aromalı 20 Şase ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/34511144/34511144-e812b9.jpg",UnitPrice=72 },
                  new aramaürün{ProductName ="Hıyar Badem 500 G Paket Adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28136887/28136887-d4d1b2.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Soğan Kuru 1 Kg Paket Adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28424584/28424584-a228b2.jpg",UnitPrice=5},
                  new aramaürün{ProductName ="Mantar 400 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28240403/28240403-1c982b.png",UnitPrice=15},
                   new aramaürün{ProductName ="Havuç Beypazarı 1 Kg Paket Adet ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28129043/28129043-c68cb8.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Domates Şeker 250 G",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28090012/28090012-677771.jpg",UnitPrice=10},
                  new aramaürün{ProductName ="Patlıcan Kemer 500 G Paket Adet ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28309054/28309054-41821e.jpg",UnitPrice=12 },
                  new aramaürün{ProductName ="Nescafe Xpress Latte Original Soğuk Kahve 250 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08059620/08059620-3f79fe.jpg",UnitPrice=5},
                 new aramaürün{ProductName ="Starbucks Chilled Classics Caramel Macchiato 220 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08059619/08059619-f2d66f.jpg",UnitPrice=5},
                  new aramaürün{ProductName ="Starbucks Doubleshot Espresso Milk 200 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08089618/08089618-16d25c.jpg",UnitPrice=5},
                   new aramaürün{ProductName ="Obsesso Iced Chai Tea Latte Sütlü Çaylı İçecek 250 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08052131/08052131-e03e18.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Obsesso Caramel Macchiato Soğuk Kahve 250 Ml",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08053257/08053257-da5851.jpg",UnitPrice=18},
                  new aramaürün{ProductName ="Nescafe Xpress Karamel Aromalı Kahveli Sütlü İçecek 250 ml ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08079715/08079715-009b89.jpg",UnitPrice=12 },
                  new aramaürün{ProductName ="Damla Doğal Kaynak Suyu 5 L",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08060303/08060303-536db6.jpg",UnitPrice=12},
                 new aramaürün{ProductName ="Erikli Su 1,5 L",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08060009/08060009-ff14b2.jpg",UnitPrice=6},
                  new aramaürün{ProductName ="Saka Doğal Mineralli Su 0,5 L",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08063000/08063000-1a3147.jpg",UnitPrice=3},
                   new aramaürün{ProductName ="Erikli Su 12x500 Ml ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08060028/08060028-53688c.jpg",UnitPrice=30},
                 new aramaürün{ProductName ="Erikli Su 0,5 L",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08062201/08062201-3aa86b.jpg",UnitPrice=3},
                  new aramaürün{ProductName ="Erikli Su 1 L  ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/08062202/08062202-2eed0f.jpg",UnitPrice=6 },
                  new aramaürün{ProductName ="Maydanoz Adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28260009/maydanoz-adet-659b84.jpg",UnitPrice=5},
                 new aramaürün{ProductName ="Roka Demet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28340009/roka-demet-efff5f.jpg",UnitPrice=5},
                  new aramaürün{ProductName ="Dereotu Adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28060009/dereotu-adet-a47d2c.jpg",UnitPrice=5},
                   new aramaürün{ProductName ="Pazı Demet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28320005/pazi-demet-0225c8.jpg",UnitPrice=9},
                 new aramaürün{ProductName ="Salata Kıvırcık adet",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28360089/salata-kivircik-adet-da42ae.jpg",UnitPrice=18},
                  new aramaürün{ProductName ="Fesleğen Demet ",ProductImageUrl ="https://migros-dali-storage-prod.global.ssl.fastly.net/hemen/product/28119903/feslegen-demet-50fba7.jpg",UnitPrice=12 }

           };

   

        public arama()
        {

            InitializeComponent();
            model.list = new ObservableCollection<aramaürün>();
            myListView.ItemsSource = list;
            beğeni.list = new ObservableCollection<aramaürün>();

            myListView.ItemsSource = list;
           
        }

        private void aramacubugu_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                myListView.ItemsSource = list;
            }

            else
            {
                myListView.ItemsSource = list.Where(x => x.ProductName.StartsWith(e.NewTextValue));
            }

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var item = sender as Button;
            var obj = item.BindingContext as aramaürün;
            model.list.Add(obj);
            DisplayAlert("!!!", "Ürün Sepete eklendi", "Tamam");
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            var item = sender as ImageButton;
            var obj = item.BindingContext as aramaürün;
            beğeni.list.Add(obj);
            DisplayAlert("!!!", "Ürün Beğendiklerime eklendi", "Tamam");
        }
    }
}