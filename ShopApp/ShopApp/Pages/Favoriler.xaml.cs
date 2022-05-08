﻿using ShopApp.Siniflar;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Favoriler : ContentPage
    {
        public Favoriler()
        {
            InitializeComponent();
            UrunleriGetir();
            Device.StartTimer(TimeSpan.FromSeconds(5), (Func<bool>)(() =>
            {
                UrunleriGetir();
                return true;
            }));
        }
        private async void AramaButon(object sender, EventArgs e)
        {
            await TappedHome.instance.Navigation.PushAsync(new Arama());
        }
        private async void SepetButton(object sender, EventArgs e)
        {
            await TappedHome.instance.Navigation.PushAsync(new Sepet());
        }
        private async void KategoriButton(object sender, EventArgs e)
        {
            TappedHome.instance.CurrentPage = TappedHome.instance.Children[1];
        }
        async void UrunleriGetir()
        {
            Database database = Database.Instance();
            var data =await database.FavorileriGetir();
            if (data.Count == 0)
            {
                bos.IsVisible = true;
                dolu.IsVisible = false;
            }
            else
            {
                bos.IsVisible = false;
                dolu.IsVisible = true;
            }

           listView.ItemsSource = data;
             listView.BindingContext = data;
        }
        private async void DetayGoster(object sender, EventArgs e)
        {
            Frame frame = (Frame)sender;
            TapGestureRecognizer tapGesture = (TapGestureRecognizer)frame.GestureRecognizers[0];
            Urun img = (Urun)tapGesture.CommandParameter;

            await TappedHome.instance.Navigation.PushAsync(new UrunDetayi(img));
        }
        private async void FavorilerdenSil(object sender, EventArgs e)
        {
            ImageButton frame = (ImageButton)sender;
            Urun img = (Urun)frame.CommandParameter;

            Database database = Database.Instance();
            await database.FavoridenSil(img.UrunIsim);
            await DisplayAlert("BAŞARILI", "ÜRÜN FAVORİLERDEN SİLİNDİ", "TAMAM");
            UrunleriGetir();

        }
    }
}