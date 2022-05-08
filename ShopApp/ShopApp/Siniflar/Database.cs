using Plugin.DeviceInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Siniflar
{
    sealed class Database
    {
        public string test { get; set; }
        private static Database _instance = null;
        public static List<Category> categories = new List<Category>();
        public static List<Urun> urunler = new List<Urun>();
        public static List<Urun> Sepet = new List<Urun>();
        public static List<Urun> favorilist = new List<Urun>();


        private Database()
        {
            DatalariIsle();
        }

        void DatalariIsle()
        {

            Category MainCategory =
                new Category
                {
                    CategoryImg = "AnaKategori",
                    CategoryName = "AnaKategori",
                };
            categories.Add(MainCategory);

            Category giyim =
                new Category
                {
                    CategoryImg = "https://firebasestorage.googleapis.com/v0/b/recentram-afa1b.appspot.com/o/katmak7.png?alt=media&token=f70c782f-9639-4ab1-9504-770cab132183",
                    CategoryName = "Giyim",
                    ParentCategory = MainCategory,
                };
            categories.Add(giyim);

            Category ayakkabilar =
            new Category
            {
                CategoryImg = "https://firebasestorage.googleapis.com/v0/b/recentram-afa1b.appspot.com/o/katmat3.png?alt=media&token=f50882a6-8f07-4b74-9926-4533dfc51679",
                CategoryName = "Ayakkabılar",
                ParentCategory = MainCategory,
            };
            categories.Add(ayakkabilar);

            Category aksesuarlar =
          new Category
          {
              CategoryImg = "https://firebasestorage.googleapis.com/v0/b/recentram-afa1b.appspot.com/o/katmat4.png?alt=media&token=c16ec2f0-940b-4d4c-a374-1d09b6e5903c",
              CategoryName = "Aksesuarlar",
              ParentCategory = MainCategory,
          };
            categories.Add(aksesuarlar);

            Category Pantolonlar =
       new Category
       {
           CategoryImg = "https://firebasestorage.googleapis.com/v0/b/recentram-afa1b.appspot.com/o/catmat2.png?alt=media&token=ac8b7dc5-75fa-4c22-a25e-0a19b761d7cb",
           CategoryName = "Pantolonlar",
           ParentCategory = MainCategory,
       };
            categories.Add(Pantolonlar);

            Category Elbiseler =
new Category
{
    CategoryImg = "https://firebasestorage.googleapis.com/v0/b/recentram-afa1b.appspot.com/o/catmat1.png?alt=media&token=6de70907-40ca-46dd-98e1-22223ef79239",
    CategoryName = "Elbiseler",
    ParentCategory = MainCategory,
};
            categories.Add(Elbiseler);

            Category Kabanlar =
new Category
{
    CategoryImg = "Kabanlar",
    CategoryName = "Kabanlar",
    ParentCategory = giyim,
};
            categories.Add(Kabanlar);

            Category Bluzlar =
new Category
{
    CategoryImg = "Bluzlar",
    CategoryName = "Bluzlar",
    ParentCategory = giyim,
};
            categories.Add(Bluzlar);


            Category Tisortler =
new Category
{
    CategoryImg = "Tisortler",
    CategoryName = "Tişörtler",
    ParentCategory = giyim,
};
            categories.Add(Tisortler);

            Category Atletler =
new Category
{
   CategoryImg = "Atletler",
   CategoryName = "Atletler",
   ParentCategory = giyim,
};
            categories.Add(Atletler);


            Category Etekler =
new Category
{
    CategoryImg = "Etekler",
    CategoryName = "Etekler",
    ParentCategory = giyim,
};
            categories.Add(Etekler);


            Category KisaElbise =
new Category
{
    CategoryImg = "Kısa Elbiseler",
    CategoryName = "Kısa Elbiseler",
    ParentCategory = Elbiseler,
};
            categories.Add(KisaElbise);


            Category UzunElbise =
new Category
{
    CategoryImg = "Uzun Elbiseler",
    CategoryName = "Uzun Elbiseler",
    ParentCategory = Elbiseler,
};
            categories.Add(UzunElbise);

            Category KolluElbise =
new Category
{
    CategoryImg = "Kollu Elbiseler",
    CategoryName = "Kollu Elbiseler",
    ParentCategory = Elbiseler,
};
            categories.Add(KolluElbise);

            Category DesenliElbise =
new Category
{
CategoryImg = "Desenli Elbiseler",
CategoryName = "Desenli Elbiseler",
ParentCategory = Elbiseler,
};
            categories.Add(DesenliElbise);


            Category DuzElbise =
new Category
{
    CategoryImg = "Düz Elbiseler",
    CategoryName = "Düz Elbiseler",
    ParentCategory = Elbiseler,
};
            categories.Add(DuzElbise);


            Category SporAyakkabi =
            new Category
            {
            CategoryImg = "Spor Ayakkabı",
            CategoryName = "Spor Ayakkabı",
            ParentCategory = ayakkabilar,
            };
            categories.Add(SporAyakkabi);

            Category GunlukAyakkabi =
            new Category
            {
                CategoryImg = "Günlük Ayakkabı",
                CategoryName = "Günlük Ayakkabı",
                ParentCategory = ayakkabilar,
            };
            categories.Add(GunlukAyakkabi);

            Category Sandalet =
            new Category
            {
                CategoryImg = "Sandalet&Terlik",
                CategoryName = "Sandalet&Terlik",
                ParentCategory = ayakkabilar,
            };
            categories.Add(Sandalet);

            Category Topuklu =
            new Category
            {
                CategoryImg = "Topuklu Ayakkabı",
                CategoryName = "Topuklu Ayakkabı",
                ParentCategory = ayakkabilar,
            };
            categories.Add(Topuklu);

            Category EvTerligi =
            new Category
            {
                CategoryImg = "Ev Terliği&Botu",
                CategoryName = "Ev Terliği&Botu",
                ParentCategory = ayakkabilar,
            };
            categories.Add(EvTerligi);

            Category AskiliCantalar =
            new Category
            {
                CategoryImg = "Askılı Çantalar",
                CategoryName = "Askılı Çantalar",
                ParentCategory = aksesuarlar,
            };
            categories.Add(AskiliCantalar);

            Category SirtCantalari =
            new Category
            {
                CategoryImg = "Sırt Çantaları",
                CategoryName = "Sırt Çantaları",
                ParentCategory = aksesuarlar,
            };
            categories.Add(SirtCantalari);

            Category Kemer =
            new Category
            {
                CategoryImg = "Kemer",
                CategoryName = "Kemer",
                ParentCategory = aksesuarlar,
            };
            categories.Add(Kemer);

            Category Sapka =
            new Category
            {
                CategoryImg = "Şapka",
                CategoryName = "Şapka",
                ParentCategory = aksesuarlar,
            };
            categories.Add(Sapka);

            Category Corap =
            new Category
            {
                CategoryImg = "Corap",
                CategoryName = "Corap",
                ParentCategory = aksesuarlar,
            };
            categories.Add(Corap);

            Category DarPaca =
             new Category
             {
             CategoryImg = "Dar Paça Pantolon",
             CategoryName = "Dar Paça Pantolon",
             ParentCategory = Pantolonlar,
              };
            categories.Add(DarPaca);

            Category BoruPaca =
             new Category
             {
                 CategoryImg = "Boru Paça Pantolon",
                 CategoryName = "Boru Paça Pantolon",
                 ParentCategory = Pantolonlar,
             };
            categories.Add(BoruPaca);

            Category ispanyolpaca =
             new Category
             {
                 CategoryImg = "İspanyol Paça Pantolon",
                 CategoryName = "İspanyol Paça Pantolon",
                 ParentCategory = Pantolonlar,
             };
            categories.Add(ispanyolpaca);

            Category BolPaca =
             new Category
             {
                 CategoryImg = "Bol Paça Pantolon",
                 CategoryName = "Bol Paça Pantolon",
                 ParentCategory = Pantolonlar,
             };
            categories.Add(BolPaca);

            Category KadifePantolon =
            new Category
            {
                CategoryImg = "Kadife Kumaş Pantolon",
                CategoryName = "Kadife Kumaş Pantolon",
                ParentCategory = Pantolonlar,
            };
            categories.Add(KadifePantolon);

            Urun KRRQDMQJVG = new Urun

            {

                UrunCategory = Kabanlar.CategoryName,

                UrunFiyat = "97.19 ₺",

                UrunIsim = "Kazayağı Desenli Cepli Kaşe Kaban 78718",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/kazayagi-desenli-cepli-kase-kaban-78718-1409648271.jpg",

            };

            urunler.Add(KRRQDMQJVG);


            Urun YYZOHGYZVU = new Urun

            {

                UrunCategory = Kabanlar.CategoryName,

                UrunFiyat = "161.99 ₺",

                UrunIsim = "Siyah Uzun Kapitone Kaban 90674",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-uzun-kapitone-kaban-90674-17418306.jpg",

            };

            urunler.Add(YYZOHGYZVU);


            Urun JCHRIZEMYW = new Urun

            {

                UrunCategory = Kabanlar.CategoryName,

                UrunFiyat = "86.39 ₺",

                UrunIsim = "Fuşya Kemerli Desenli Bayan Kaşe Kaban 83218",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/fusya-kemerli-desenli-bayan-kase-kaban-83218-545567979.jpg",

            };

            urunler.Add(JCHRIZEMYW);


            Urun UBNPZPPDHL = new Urun

            {

                UrunCategory = Kabanlar.CategoryName,

                UrunFiyat = "151.19 ₺",

                UrunIsim = "Bej Dolumlu Bayan Şişme Kaban 85272",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/bej-dolumlu-bayan-sisme-kaban-85272-192980099.jpg",

            };

            urunler.Add(UBNPZPPDHL);


            Urun DQSALPZZSD = new Urun

            {

                UrunCategory = Kabanlar.CategoryName,

                UrunFiyat = "107.99 ₺",

                UrunIsim = "Mavi Kar Yıkama Tasarım Bayan Kot Ceket 108421",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/mavi-yirtik-tasarim-kar-yikama-kot-ceket-108421-999269133.jpg",

            };

            urunler.Add(DQSALPZZSD);


            Urun XADUULLKSL = new Urun

            {

                UrunCategory = Bluzlar.CategoryName,

                UrunFiyat = "16.19 ₺",

                UrunIsim = "Yeşil Çıt Çıt Düğmeli Bluz 97460",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/yesil-cit-cit-dugmeli-bluz-97460-1652256738.jpg",

            };

            urunler.Add(XADUULLKSL);


            Urun ZMVEBVMGYM = new Urun

            {

                UrunCategory = Bluzlar.CategoryName,

                UrunFiyat = "10.75 ₺",

                UrunIsim = "Mavi Çıt Çıt Düğmeli Bluz 97717",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/mavi-cit-cit-dugmeli-bluz-97717-191677796.jpg",

            };

            urunler.Add(ZMVEBVMGYM);


            Urun QHRRXZTIPD = new Urun

            {

                UrunCategory = Bluzlar.CategoryName,

                UrunFiyat = "16.19 ₺",

                UrunIsim = "Siyah Fermuarlı Zıbın Bluz 97404",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-fermuarli-zibin-bluz-97404-1262562158.jpg",

            };

            urunler.Add(QHRRXZTIPD);


            Urun MCCILOJJKA = new Urun

            {

                UrunCategory = Bluzlar.CategoryName,

                UrunFiyat = "16.19 ₺",

                UrunIsim = "Krem Fermuarlı Fitilli Bluz 97425",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/krem-fermuarli-fitilli-bluz-97425-424282925.jpg",

            };

            urunler.Add(MCCILOJJKA);


            Urun DDNHIQINVV = new Urun

            {

                UrunCategory = Bluzlar.CategoryName,

                UrunFiyat = "16.19 ₺",

                UrunIsim = "Krem Fitilli Zıbın Bluz 97393",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/krem-fitilli-zibin-bluz-97393-282079242.jpg",

            };

            urunler.Add(DDNHIQINVV);


            Urun AOWMCKAYHS = new Urun

            {

                UrunCategory = Tisortler.CategoryName,

                UrunFiyat = "37.79 ₺",

                UrunIsim = "Beyaz Duble Kol Yırtmaçlı Bayan Tişört 92487",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/beyaz-duble-kol-yirtmacli-bayan-tisort-92487-200810738.jpg",

            };

            urunler.Add(AOWMCKAYHS);


            Urun ABWSLHXJWC = new Urun

            {

                UrunCategory = Tisortler.CategoryName,

                UrunFiyat = "32.39 ₺",

                UrunIsim = "Siyah Duble Kol Yırtmaçlı Bayan Tişört 92482",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-duble-kol-yirtmacli-bayan-tisort-92482-1394930060.jpg",

            };

            urunler.Add(ABWSLHXJWC);


            Urun WMGGLPLSFG = new Urun

            {

                UrunCategory = Tisortler.CategoryName,

                UrunFiyat = "43.19 ₺",

                UrunIsim = "Siyah Polo Yaka Likralı Tişört 106231",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-polo-yaka-likrali-tisort-106231-487360255.jpg",

            };

            urunler.Add(WMGGLPLSFG);


            Urun YHTMKTGGDV = new Urun

            {

                UrunCategory = Tisortler.CategoryName,

                UrunFiyat = "32.39 ₺",

                UrunIsim = "Sarı Duble Kol Yırtmaçlı Bayan Tişört 92486",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/sari-duble-kol-yirtmacli-bayan-tisort-92486-1155094237.jpg",

            };

            urunler.Add(YHTMKTGGDV);


            Urun DRRDXPYGDD = new Urun

            {

                UrunCategory = Tisortler.CategoryName,

                UrunFiyat = "43.19 ₺",

                UrunIsim = "Füme Baskılı Yıkamalı Bayan Tişört 106807",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/fume-baskili-yikamali-bayan-tisort-106807-94717463.jpg",

            };

            urunler.Add(DRRDXPYGDD);


            Urun OYEAKCVQVI = new Urun

            {

                UrunCategory = Atletler.CategoryName,

                UrunFiyat = "14.03 ₺",

                UrunIsim = "Krem Fitilli Likralı Bayan Atlet 72882",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/krem-fitilli-likrali-bayan-atlet-72882-385285032.jpg",

            };

            urunler.Add(OYEAKCVQVI);


            Urun WLTYHCYNYL = new Urun

            {

                UrunCategory = Atletler.CategoryName,

                UrunFiyat = "16.19 ₺",

                UrunIsim = "Lacivert Askılı Likralı Bayan Atlet 75686",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/lacivert-askili-likrali-bayan-atlet-75686-1721848088.jpg",

            };

            urunler.Add(WLTYHCYNYL);


            Urun VILTMBBOGK = new Urun

            {

                UrunCategory = Atletler.CategoryName,

                UrunFiyat = "16.19 ₺",

                UrunIsim = "Sarı Askılı Fitilli Bayan Atlet 75692",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/sari-askili-fitilli-bayan-atlet-75692-55750367.jpg",

            };

            urunler.Add(VILTMBBOGK);


            Urun UBPUSRBDZT = new Urun

            {

                UrunCategory = Atletler.CategoryName,

                UrunFiyat = "32.39 ₺",

                UrunIsim = "Mavi Baskılı Şort Atlet Bayan Pijama Takımı 102713",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/mavi-baskili-sort-atlet-bayan-pijama-takimi-102713-920459656.jpg",

            };

            urunler.Add(UBPUSRBDZT);


            Urun ROYLMIEJAJ = new Urun

            {

                UrunCategory = Atletler.CategoryName,

                UrunFiyat = "12.95 ₺",

                UrunIsim = "Beyaz Likralı Bayan Fitilli Kısa Atlet 58780",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/beyaz-likrali-bayan-fitilli-kisa-atlet-58780-1029076274.jpg",

            };

            urunler.Add(ROYLMIEJAJ);


            Urun RQKFSBZLGR = new Urun

            {

                UrunCategory = Etekler.CategoryName,

                UrunFiyat = "53.99 ₺",

                UrunIsim = "Siyah Gümüş Simli Spor Ayakkabı 91199",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-gumus-simli-spor-ayakkabi-91199-1019799444.jpg",

            };

            urunler.Add(RQKFSBZLGR);


            Urun FOCLSSFZJW = new Urun

            {

                UrunCategory = Etekler.CategoryName,

                UrunFiyat = "53.99 ₺",

                UrunIsim = "Siyah Beyaz Spor Ayakkabı 91205",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-beyaz-spor-ayakkabi-91205-1094189357.jpg",

            };

            urunler.Add(FOCLSSFZJW);


            Urun JHVXELIICX = new Urun

            {

                UrunCategory = Etekler.CategoryName,

                UrunFiyat = "140.39 ₺",

                UrunIsim = "Siyah Triko Spor Ayakkabı 87602",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-triko-spor-ayakkabi-87602-2006265573.jpg",

            };

            urunler.Add(JHVXELIICX);


            Urun BYNZDKJLXW = new Urun

            {

                UrunCategory = Etekler.CategoryName,

                UrunFiyat = "140.39 ₺",

                UrunIsim = "Bej Triko Spor Ayakkabı 86526",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/bej-triko-spor-ayakkabi-86526-787998244.jpg",

            };

            urunler.Add(BYNZDKJLXW);


            Urun TETISPGKVQ = new Urun

            {

                UrunCategory = Etekler.CategoryName,

                UrunFiyat = "53.99 ₺",

                UrunIsim = "Siyah Spor Ayakkabı 101565",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-spor-ayakkabi-101565-1373653508.jpg",

            };

            urunler.Add(TETISPGKVQ);


            Urun BISSGDKURF = new Urun

            {

                UrunCategory = SporAyakkabi.CategoryName,

                UrunFiyat = "151.19 ₺",

                UrunIsim = "Siyah Kırışık Rugan Simli Kadın Günlük Ayakkabı 103609",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-kirisik-rugan-simli-kadin-gunluk-ayakkabi-103609-1429397013.jpg",

            };

            urunler.Add(BISSGDKURF);


            Urun XZCLLUAAJW = new Urun

            {

                UrunCategory = SporAyakkabi.CategoryName,

                UrunFiyat = "151.19 ₺",

                UrunIsim = "Siyah Kırışık Rugan Simli Kadın Günlük Ayakkabı 103639",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-kirisik-rugan-simli-kadin-gunluk-ayakkabi-103639-1673828814.jpg",

            };

            urunler.Add(XZCLLUAAJW);


            Urun PSYNQYHQPW = new Urun

            {

                UrunCategory = SporAyakkabi.CategoryName,

                UrunFiyat = "151.19 ₺",

                UrunIsim = "Siyah Rugan Simli Kadın Günlük Ayakkabı 103638",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-rugan-simli-kadin-gunluk-ayakkabi-103638-1678994533.jpg",

            };

            urunler.Add(PSYNQYHQPW);


            Urun VIHHKLBRHJ = new Urun

            {

                UrunCategory = SporAyakkabi.CategoryName,

                UrunFiyat = "53.99 ₺",

                UrunIsim = "Siyah Gümüş Simli Spor Ayakkabı 91199",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-gumus-simli-spor-ayakkabi-91199-1019799444.jpg",

            };

            urunler.Add(VIHHKLBRHJ);


            Urun DXPMRVYURW = new Urun

            {

                UrunCategory = SporAyakkabi.CategoryName,

                UrunFiyat = "53.99 ₺",

                UrunIsim = "Siyah Beyaz Spor Ayakkabı 91205",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-beyaz-spor-ayakkabi-91205-1094189357.jpg",

            };

            urunler.Add(DXPMRVYURW);


            Urun IMVLWHUPRF = new Urun

            {

                UrunCategory = GunlukAyakkabi.CategoryName,

                UrunFiyat = "140.39 ₺",

                UrunIsim = "Siyah Triko Sandalet 110490",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-triko-sandalet-110490-165441064.jpg",

            };

            urunler.Add(IMVLWHUPRF);


            Urun BQXURKZYDA = new Urun

            {

                UrunCategory = GunlukAyakkabi.CategoryName,

                UrunFiyat = "140.39 ₺",

                UrunIsim = "Siyah Beyaz Triko Sandalet 110496",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-beyaz-triko-sandalet-110496-1312480331.jpg",

            };

            urunler.Add(BQXURKZYDA);


            Urun NSSBIOWGVH = new Urun

            {

                UrunCategory = GunlukAyakkabi.CategoryName,

                UrunFiyat = "140.39 ₺",

                UrunIsim = "Siyah Triko Sandalet 110492",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-triko-sandalet-110492-884804386.jpg",

            };

            urunler.Add(NSSBIOWGVH);


            Urun AFZBVTYAHE = new Urun

            {

                UrunCategory = GunlukAyakkabi.CategoryName,

                UrunFiyat = "43.19 ₺",

                UrunIsim = "Somon Bantlı Örgü Tasarım Düz Taban Kadın Sandalet 112524",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/somon-bantli-orgu-tasarim-duz-taban-kadin-sandalet-112524-156005841.jpg",

            };

            urunler.Add(AFZBVTYAHE);


            Urun YGPLUZSYNI = new Urun

            {

                UrunCategory = GunlukAyakkabi.CategoryName,

                UrunFiyat = "53.99 ₺",

                UrunIsim = "Bisküvi Pofidik Bantlı Kadın Sandalet 109578",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/biskuvi-pofidik-bantli-kadin-sandalet-109578-1844940139.jpg",

            };

            urunler.Add(YGPLUZSYNI);


            Urun ENHNEGBYGT = new Urun

            {

                UrunCategory = Sandalet.CategoryName,

                UrunFiyat = "172.79 ₺",

                UrunIsim = "Siyah Bağlamalı Topuklu Ayakkabı 95759",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-baglamali-topuklu-ayakkabi-95759-926254251.jpg",

            };

            urunler.Add(ENHNEGBYGT);


            Urun IBUBQOTXAE = new Urun

            {

                UrunCategory = Sandalet.CategoryName,

                UrunFiyat = "161.99 ₺",

                UrunIsim = "Ten Kadın Topuklu Ayakkabı 94685",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/ten-kadin-topuklu-ayakkabi-94685-1252841172.jpg",

            };

            urunler.Add(IBUBQOTXAE);


            Urun BOIOOOHIKP = new Urun

            {

                UrunCategory = Sandalet.CategoryName,

                UrunFiyat = "86.39 ₺",

                UrunIsim = "Siyah Kadın Topuklu Ayakkabı 96120",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-kadin-topuklu-ayakkabi-96120-908123803.jpg",

            };

            urunler.Add(BOIOOOHIKP);


            Urun YIFSGCRDZR = new Urun

            {

                UrunCategory = Sandalet.CategoryName,

                UrunFiyat = "140.39 ₺",

                UrunIsim = "Siyah Topuklu Ayakkabı 107794",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-topuklu-ayakkabi-107794-660824216.jpg",

            };

            urunler.Add(YIFSGCRDZR);


            Urun LIAYNHSOOW = new Urun

            {

                UrunCategory = Sandalet.CategoryName,

                UrunFiyat = "140.39 ₺",

                UrunIsim = "Beyaz Rugan Topuklu Ayakkabı 106819",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/beyaz-rugan-topuklu-ayakkabi-106819-911008575.jpg",

            };

            urunler.Add(LIAYNHSOOW);


            Urun EZLIYZDNBQ = new Urun

            {

                UrunCategory = Topuklu.CategoryName,

                UrunFiyat = "75.59 ₺",

                UrunIsim = "Beyaz Bantlı Topuklu Terlik 96141",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/beyaz-bantli-topuklu-terlik-96141-1905233369.jpg",

            };

            urunler.Add(EZLIYZDNBQ);


            Urun GEUFXREOLR = new Urun

            {

                UrunCategory = Topuklu.CategoryName,

                UrunFiyat = "43.19 ₺",

                UrunIsim = "Su Yeşili Çapraz Bant Taş Tasarımlı Kadın Terlik 100809",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/su-yesili-capraz-bant-tas-tasarimli-kadin-terlik-100809-622367675.jpg",

            };

            urunler.Add(GEUFXREOLR);


            Urun WCPXNUUHPA = new Urun

            {

                UrunCategory = Topuklu.CategoryName,

                UrunFiyat = "75.59 ₺",

                UrunIsim = "Siyah Bantlı Topuklu Terlik 96139",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-bantli-topuklu-terlik-96139-607756637.jpg",

            };

            urunler.Add(WCPXNUUHPA);


            Urun IFCNXGIMGX = new Urun

            {

                UrunCategory = Topuklu.CategoryName,

                UrunFiyat = "97.19 ₺",

                UrunIsim = "Siyah Rugan Şeffaf Bantlı Topuklu Terlik 106112",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-rugan-seffaf-bantli-topuklu-terlik-106112-604091428.jpg",

            };

            urunler.Add(IFCNXGIMGX);


            Urun TUULGHFDYO = new Urun

            {

                UrunCategory = Topuklu.CategoryName,

                UrunFiyat = "59.39 ₺",

                UrunIsim = "Pudra Dört Bantlı Taşlı Kadın Terlik 100652",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/pudra-dort-bantli-tasli-kadin-terlik-100652-748374393.jpg",

            };

            urunler.Add(TUULGHFDYO);


            Urun YOKMOAKXQY = new Urun

            {

                UrunCategory = EvTerligi.CategoryName,

                UrunFiyat = "37.79 ₺",

                UrunIsim = "Antrasit H Tokalı Kadın Terlik 103319",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/antrasit-h-tokali-kadin-terlik-103319-1872167152.jpg",

            };

            urunler.Add(YOKMOAKXQY);


            Urun YZAYSXWYZW = new Urun

            {

                UrunCategory = EvTerligi.CategoryName,

                UrunFiyat = "37.79 ₺",

                UrunIsim = "Pudra Tokalı Kadın Terlik 110603",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/pudra-tokali-kadin-terlik-110603-476706152.jpg",

            };

            urunler.Add(YZAYSXWYZW);


            Urun MMKYOVSHHP = new Urun

            {

                UrunCategory = EvTerligi.CategoryName,

                UrunFiyat = "37.79 ₺",

                UrunIsim = "Kırmızı Kabartma Yazı Tasarım Omuz Çantası 104252",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/kirmizi-kabartma-yazi-tasarim-omuz-cantasi-104252-1257937867.jpg",

            };

            urunler.Add(MMKYOVSHHP);


            Urun IUFZIWLXIY = new Urun

            {

                UrunCategory = EvTerligi.CategoryName,

                UrunFiyat = "37.79 ₺",

                UrunIsim = "Kırmızı Çift Gözlü Omuz Çantası 89232",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/kirmizi-cift-gozlu-omuz-cantasi-89232-1309071073.jpg",

            };

            urunler.Add(IUFZIWLXIY);


            Urun ZDFTZMTGEX = new Urun

            {

                UrunCategory = EvTerligi.CategoryName,

                UrunFiyat = "75.59 ₺",

                UrunIsim = "Siyah Baklava Dilimli Kol Çantası 99525",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-baklava-dilimli-kol-cantasi-99525-819390628.jpg",

            };

            urunler.Add(ZDFTZMTGEX);


            Urun WIIXCOYFGD = new Urun

            {

                UrunCategory = AskiliCantalar.CategoryName,

                UrunFiyat = "37.79 ₺",

                UrunIsim = "Lacivert Bol Gözlü Kol ve Omuz Çantası 95673",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/lacivert-bol-gozlu-kol-ve-omuz-cantasi-95673-1150986699.jpg",

            };

            urunler.Add(WIIXCOYFGD);


            Urun ZUAIWYOGPS = new Urun

            {

                UrunCategory = AskiliCantalar.CategoryName,

                UrunFiyat = "37.79 ₺",

                UrunIsim = "Çapraz Askılı Taşlı Lacivert Omuz Çantası 20454Ç",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/capraz-askili-tasli-lacivert-omuz-cantas-cc5b.jpg",

            };

            urunler.Add(ZUAIWYOGPS);


            Urun MNYGLZQSLW = new Urun

            {

                UrunCategory = AskiliCantalar.CategoryName,

                UrunFiyat = "37.79 ₺",

                UrunIsim = "Çapraz Askılı Taşlı Lacivert Omuz Çantası 20454Ç",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/capraz-askili-tasli-lacivert-omuz-cantas-cc5b.jpg",

            };

            urunler.Add(MNYGLZQSLW);


            Urun CVWTVMDTHH = new Urun

            {

                UrunCategory = AskiliCantalar.CategoryName,

                UrunFiyat = "37.79 ₺",

                UrunIsim = "Haki Bayan Çift Gözlü Çanta 82942",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/haki-bayan-cift-gozlu-canta-82942-1473434008.jpg",

            };

            urunler.Add(CVWTVMDTHH);


            Urun EBKWFHBXBC = new Urun

            {

                UrunCategory = AskiliCantalar.CategoryName,

                UrunFiyat = "21.59 ₺",

                UrunIsim = "Taba Bayan Çantalı Deri Kemer 26627K",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/taba-bayan-cantali-deri-kemer-26627k-366a.jpg",

            };

            urunler.Add(EBKWFHBXBC);


            Urun LYVPWTOPHY = new Urun

            {

                UrunCategory = SirtCantalari.CategoryName,

                UrunFiyat = "37.79 ₺",

                UrunIsim = "Haki Kabartma Yazılı Şeffaf Detay Omuz Çantası 105762",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/haki-kabartma-yazili-seffaf-detay-omuz-cantasi-105762-352474801.jpg",

            };

            urunler.Add(LYVPWTOPHY);


            Urun JVPGLTJKVH = new Urun

            {

                UrunCategory = SirtCantalari.CategoryName,

                UrunFiyat = "59.39 ₺",

                UrunIsim = "Sarı El ve Kol Çantası 91884",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/sari-el-ve-kol-cantasi-91884-1885487423.jpg",

            };

            urunler.Add(JVPGLTJKVH);


            Urun VUNPOFKDBN = new Urun

            {

                UrunCategory = SirtCantalari.CategoryName,

                UrunFiyat = "86.39 ₺",

                UrunIsim = "Vizon Kemerli Cepli Bayan Tulum 87618",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/vizon-kemerli-cepli-bayan-tulum-87618-1859705721.jpg",

            };

            urunler.Add(VUNPOFKDBN);


            Urun YCOBMDYARX = new Urun

            {

                UrunCategory = SirtCantalari.CategoryName,

                UrunFiyat = "86.39 ₺",

                UrunIsim = "Kırmızı Kemerli Cepli Bayan Tulum 90590",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/kirmizi-kemerli-cepli-bayan-tulum-90590-275962380.jpg",

            };

            urunler.Add(YCOBMDYARX);


            Urun WSNXKMCPHE = new Urun

            {

                UrunCategory = SirtCantalari.CategoryName,

                UrunFiyat = "64.79 ₺",

                UrunIsim = "Siyah Kemerli Piliseli Mira Etek 102845",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-kemerli-piliseli-mira-etek-102845-34978952.jpg",

            };

            urunler.Add(WSNXKMCPHE);


            Urun YXNVDNQVAZ = new Urun

            {

                UrunCategory = Kemer.CategoryName,

                UrunFiyat = "118.79 ₺",

                UrunIsim = "Bordo Kemerli İthal Krep Bayan Tulum 99264",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/bordo-kemerli-ithal-krep-bayan-tulum-99264-2125173034.jpg",

            };

            urunler.Add(YXNVDNQVAZ);


            Urun WGWEVJLUMO = new Urun

            {

                UrunCategory = Kemer.CategoryName,

                UrunFiyat = "118.79 ₺",

                UrunIsim = "Siyah Kemerli İthal Krep Bayan Tulum 99262",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-kemerli-ithal-krep-bayan-tulum-99262-483610450.jpg",

            };

            urunler.Add(WGWEVJLUMO);


            Urun GWDIVHSMGM = new Urun

            {

                UrunCategory = Kemer.CategoryName,

                UrunFiyat = "64.79 ₺",

                UrunIsim = "Mavi (5-8 yaş) Mıckey Baskılı Erkek Çocuk Şapkalı Takım 111035",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/mavi-5-8-yas-mickey-baskili-erkek-cocuk-sapkali-takim-111035-1461364463.jpg",

            };

            urunler.Add(GWDIVHSMGM);


            Urun PYOOXYGUAM = new Urun

            {

                UrunCategory = Kemer.CategoryName,

                UrunFiyat = "64.79 ₺",

                UrunIsim = "Saks Mavisi (5-8 yaş) Şapkalı Ara Biyeli Erkek Çocuk Kaprili Takım 112391",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/saks-mavisi-5-8-yas-sapkali-ara-biyeli-erkek-cocuk-kaprili-takim-112391-29301346.jpg",

            };

            urunler.Add(PYOOXYGUAM);


            Urun COLFMPLOIC = new Urun

            {

                UrunCategory = Kemer.CategoryName,

                UrunFiyat = "64.79 ₺",

                UrunIsim = "Kırmızı (5-8 yaş) Mıckey Baskılı Erkek Çocuk Şapkalı Takım 111037",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/kirmizi-5-8-yas-mickey-baskili-erkek-cocuk-sapkali-takim-111037-2116124561.jpg",

            };

            urunler.Add(COLFMPLOIC);


            Urun IHTCFFDGRG = new Urun

            {

                UrunCategory = Sapka.CategoryName,

                UrunFiyat = "64.79 ₺",

                UrunIsim = "Saks Mavisi (5-8 yaş) Şapkalı Spıderman Baskılı Erkek Çocuk Kaprili Takım 112395",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/saks-mavisi-5-8-yas-sapkali-spiderman-baskili-erkek-cocuk-kaprili-takim-112395-1536556557.jpg",

            };

            urunler.Add(IHTCFFDGRG);


            Urun UXZCGKVLCG = new Urun

            {

                UrunCategory = Sapka.CategoryName,

                UrunFiyat = "64.79 ₺",

                UrunIsim = "Kırmızı (5-8 yaş) Şapkalı Ara Biyeli Erkek Çocuk Kaprili Takım 112389",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/kirmizi-5-8-yas-sapkali-ara-biyeli-erkek-cocuk-kaprili-takim-112389-406320127.jpg",

            };

            urunler.Add(UXZCGKVLCG);


            Urun XDVVAAAIVT = new Urun

            {

                UrunCategory = Sapka.CategoryName,

                UrunFiyat = "21.59 ₺",

                UrunIsim = "Renkli Üçlü Soket Çorap 100789",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/renkli-uclu-soket-corap-100789-188227636.jpg",

            };

            urunler.Add(XDVVAAAIVT);


            Urun QMWLKZOURS = new Urun

            {

                UrunCategory = Sapka.CategoryName,

                UrunFiyat = "21.59 ₺",

                UrunIsim = "Renkli Üçlü Soket Çorap 100786",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/renkli-uclu-soket-corap-100786-187949754.jpg",

            };

            urunler.Add(QMWLKZOURS);


            Urun TDCXKCCKMS = new Urun

            {

                UrunCategory = Sapka.CategoryName,

                UrunFiyat = "16.19 ₺",

                UrunIsim = "Pamuklu Üçlü Dikişsiz Bayan Çorap 45690",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/pamuklu-uclu-dikissiz-bayan-corap-45690-a127.jpg",

            };

            urunler.Add(TDCXKCCKMS);


            Urun QLDTSXMYVN = new Urun

            {

                UrunCategory = Corap.CategoryName,

                UrunFiyat = "14.03 ₺",

                UrunIsim = "Pamuklu Üçlü Bayan Kolej Çorap 39608",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/pamuklu-uclu-bayan-kolej-corap-39608-c142.jpg",

            };

            urunler.Add(QLDTSXMYVN);


            Urun CZXJLBVDHU = new Urun

            {

                UrunCategory = Corap.CategoryName,

                UrunFiyat = "21.59 ₺",

                UrunIsim = "Renkli Üçlü Soket Çorap 100789",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/renkli-uclu-soket-corap-100789-188227636.jpg",

            };

            urunler.Add(CZXJLBVDHU);


            Urun QIAXIROASP = new Urun

            {

                UrunCategory = Corap.CategoryName,

                UrunFiyat = "129.59 ₺",

                UrunIsim = "Buz Mavisi Lazer Kesim Bayan Kot Pantolon 102829",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/buz-mavisi-lazer-kesim-bayan-kot-pantolon-102829-905731037.jpg",

            };

            urunler.Add(QIAXIROASP);


            Urun XQNQFQTIUW = new Urun

            {

                UrunCategory = Corap.CategoryName,

                UrunFiyat = "43.19 ₺",

                UrunIsim = "Siyah Fitilli Bol Paça Bayan Pantolon 100988",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-fitilli-bol-paca-bayan-pantolon-100988-1558658406.jpg",

            };

            urunler.Add(XQNQFQTIUW);


            Urun HJKLDIJMOH = new Urun

            {

                UrunCategory = Corap.CategoryName,

                UrunFiyat = "43.19 ₺",

                UrunIsim = "Siyah Bol Paça Bayan Pantolon 108530",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-bol-paca-bayan-pantolon-108530-2111526822.jpg",

            };

            urunler.Add(HJKLDIJMOH);


            Urun USQLQZSIAU = new Urun

            {

                UrunCategory = DarPaca.CategoryName,

                UrunFiyat = "26.99 ₺",

                UrunIsim = "Lila Bol Paça Bayan Pantolon 108533",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/lila-bol-paca-bayan-pantolon-108533-975534422.jpg",

            };

            urunler.Add(USQLQZSIAU);


            Urun VRXWLUMJFV = new Urun

            {

                UrunCategory = DarPaca.CategoryName,

                UrunFiyat = "107.99 ₺",

                UrunIsim = "Siyah Yüksek Bel Likralı Bayan Kot Pantolon 109830",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-yuksek-bel-likrali-bayan-kot-pantolon-109830-1929078688.jpg",

            };

            urunler.Add(VRXWLUMJFV);


            Urun NQYTDNYRPO = new Urun

            {

                UrunCategory = DarPaca.CategoryName,

                UrunFiyat = "107.99 ₺",

                UrunIsim = "Siyah Yüksek Bel Likralı Bayan Kot Pantolon 95744",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-yuksek-bel-likrali-bayan-kot-pantolon-95744-1649980504.jpg",

            };

            urunler.Add(NQYTDNYRPO);


            Urun QENCYKJFID = new Urun

            {

                UrunCategory = DarPaca.CategoryName,

                UrunFiyat = "97.19 ₺",

                UrunIsim = "Beyaz Yüksek Bel Likralı Bayan Kot Pantolon 93017",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/beyaz-yuksek-bel-likrali-bayan-kot-pantolon-93017-184630416.jpg",

            };

            urunler.Add(QENCYKJFID);


            Urun IWFTEZIZOY = new Urun

            {

                UrunCategory = DarPaca.CategoryName,

                UrunFiyat = "48.59 ₺",

                UrunIsim = "Siyah ispanyol Paça Likralı Bayan Pantolon 111851",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-ispanyol-paca-likrali-bayan-pantolon-111851-687874802.jpg",

            };

            urunler.Add(IWFTEZIZOY);


            Urun BNJIVGMCGH = new Urun

            {

                UrunCategory = BoruPaca.CategoryName,

                UrunFiyat = "118.79 ₺",

                UrunIsim = "Mavi Likralı Lazer Kesim Yüksek Bel Kot Pantolon 95766",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/mavi-likrali-lazer-kesim-yuksek-bel-kot-pantolon-95766-1152513479.jpg",

            };

            urunler.Add(BNJIVGMCGH);


            Urun SXSLHTBHIT = new Urun

            {

                UrunCategory = BoruPaca.CategoryName,

                UrunFiyat = "80.99 ₺",

                UrunIsim = "Lacivert Belden Bağlamalı Tensel Kot Pantolon 102538",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/lacivert-belden-baglamali-tensel-kot-pantolon-102538-967995142.jpg",

            };

            urunler.Add(SXSLHTBHIT);


            Urun XWWWTDHVCI = new Urun

            {

                UrunCategory = BoruPaca.CategoryName,

                UrunFiyat = "97.19 ₺",

                UrunIsim = "Mavi Likralı Yırtık Detay Bayan Kot Pantolon 102819",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/mavi-likrali-yirtik-detay-bayan-kot-pantolon-102819-1234974986.jpg",

            };

            urunler.Add(XWWWTDHVCI);


            Urun NZRZFSFLUP = new Urun

            {

                UrunCategory = BoruPaca.CategoryName,

                UrunFiyat = "32.39 ₺",

                UrunIsim = "Yeşil Bol Paça Bayan Pantolon 108532",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/yesil-bol-paca-bayan-pantolon-108532-1327857900.jpg",

            };

            urunler.Add(NZRZFSFLUP);


            Urun SXEEEKFABE = new Urun

            {

                UrunCategory = BoruPaca.CategoryName,

                UrunFiyat = "53.99 ₺",

                UrunIsim = "Siyah Belden Bağlamalı Cepli Bayan Pantolon 88887",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-belden-baglamali-cepli-bayan-pantolon-88887-1482662936.jpg",

            };

            urunler.Add(SXEEEKFABE);


            Urun GIEEFHRBNH = new Urun

            {

                UrunCategory = ispanyolpaca.CategoryName,

                UrunFiyat = "59.39 ₺",

                UrunIsim = "Siyah Yırtmaçlı İspanyol Paça Tayt Pantolon 91786",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-yirtmacli-ispanyol-paca-tayt-pantolon-91786-415252492.jpg",

            };

            urunler.Add(GIEEFHRBNH);


            Urun SWCOQQDVLP = new Urun

            {

                UrunCategory = ispanyolpaca.CategoryName,

                UrunFiyat = "129.59 ₺",

                UrunIsim = "Koyu Füme Likralı Mom Kot Pantolon 95613",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/koyu-fume-likrali-mom-kot-pantolon-95613-1967255379.jpg",

            };

            urunler.Add(SWCOQQDVLP);


            Urun QZIFOWWCTT = new Urun

            {

                UrunCategory = ispanyolpaca.CategoryName,

                UrunFiyat = "97.19 ₺",

                UrunIsim = "Siyah Tokalı Bayan Pantolon 94500",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-tokali-bayan-pantolon-94500-1983488836.jpg",

            };

            urunler.Add(QZIFOWWCTT);


            Urun XNOSLXRAEE = new Urun

            {

                UrunCategory = ispanyolpaca.CategoryName,

                UrunFiyat = "161.99 ₺",

                UrunIsim = "Mavi ispanyol Paça Likralı Kot Pantolon 96344",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/mavi-ispanyol-paca-likrali-kot-pantolon-96344-389330597.jpg",

            };

            urunler.Add(XNOSLXRAEE);


            Urun ENBIUUYIKA = new Urun

            {

                UrunCategory = ispanyolpaca.CategoryName,

                UrunFiyat = "140.39 ₺",

                UrunIsim = "Yüksek Bel Likralı Mavi Bayan Kot Pantolon 95748",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/yuksek-bel-likrali-mavi-bayan-kot-pantolon-95748-1725907311.jpg",

            };

            urunler.Add(ENBIUUYIKA);


            Urun GIWASJBVDZ = new Urun

            {

                UrunCategory = BolPaca.CategoryName,

                UrunFiyat = "97.19 ₺",

                UrunIsim = "Kar Yıkama Likralı Açık Mavi Kot Pantolon 86607",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/kar-yikama-likrali-acik-mavi-kot-pantolon-86607-1782506790.jpg",

            };

            urunler.Add(GIWASJBVDZ);


            Urun QNHCUPQDYY = new Urun

            {

                UrunCategory = BolPaca.CategoryName,

                UrunFiyat = "129.59 ₺",

                UrunIsim = "Buz Mavisi İspanyol Paça Bayan Kot Pantolon 110701",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/buz-mavisi-ispanyol-paca-bayan-kot-pantolon-110701-782673626.jpg",

            };

            urunler.Add(QNHCUPQDYY);


            Urun ZVGCWWPUUS = new Urun

            {

                UrunCategory = BolPaca.CategoryName,

                UrunFiyat = "129.59 ₺",

                UrunIsim = "Siyah İspanyol Paça Bayan Kot Pantolon 110698",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-ispanyol-paca-bayan-kot-pantolon-110698-1896039734.jpg",

            };

            urunler.Add(ZVGCWWPUUS);


            Urun QAUNOGUFUA = new Urun

            {

                UrunCategory = BolPaca.CategoryName,

                UrunFiyat = "129.59 ₺",

                UrunIsim = "Koyu Füme Pençli Mom Kot Pantolon 111424",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/koyu-fume-pencli-mom-kot-pantolon-111424-1598699255.jpg",

            };

            urunler.Add(QAUNOGUFUA);


            Urun ROHGBVMZHG = new Urun

            {

                UrunCategory = BolPaca.CategoryName,

                UrunFiyat = "97.19 ₺",

                UrunIsim = "Siyah Likralı Yüksek Bel Bayan Kot Pantolon 86603",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-likrali-yuksek-bel-bayan-kot-pantolon-86603-1601821332.jpg",

            };

            urunler.Add(ROHGBVMZHG);


            Urun MTDSRCCNCY = new Urun

            {

                UrunCategory = KadifePantolon.CategoryName,

                UrunFiyat = "97.19 ₺",

                UrunIsim = "Mavi Rahat Kalıp Bayan Tensel Kot Pantolon 88799",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/mavi-rahat-kalip-bayan-tensel-kot-pantolon-88799-977637252.jpg",

            };

            urunler.Add(MTDSRCCNCY);


            Urun EWCEYHNNTM = new Urun

            {

                UrunCategory = KadifePantolon.CategoryName,

                UrunFiyat = "129.59 ₺",

                UrunIsim = "Mavi Pençli Mom Bayan Kot Pantolon 111423",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/mavi-pencli-mom-bayan-kot-pantolon-111423-534224368.jpg",

            };

            urunler.Add(EWCEYHNNTM);


            Urun WTWSIRMUVE = new Urun

            {

                UrunCategory = KadifePantolon.CategoryName,

                UrunFiyat = "30.23 ₺",

                UrunIsim = "Siyah Fitilli Lilralı Elbise 106570",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-fitilli-lilrali-elbise-106570-1893223993.jpg",

            };

            urunler.Add(WTWSIRMUVE);


            Urun FWWVXEMNZU = new Urun

            {

                UrunCategory = KadifePantolon.CategoryName,

                UrunFiyat = "53.99 ₺",

                UrunIsim = "Siyah Baskılı Tasarım Elbise 109316",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-baskili-tasarim-elbise-109316-1246818418.jpg",

            };

            urunler.Add(FWWVXEMNZU);


            Urun VQUHGVMYLH = new Urun

            {

                UrunCategory = KadifePantolon.CategoryName,

                UrunFiyat = "43.19 ₺",

                UrunIsim = "Siyah Büzgülü Fitilli Elbise 112164",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-buzgulu-fitilli-elbise-112164-2015082556.jpg",

            };

            urunler.Add(VQUHGVMYLH);


            Urun TOUYCLRDKW = new Urun

            {

                UrunCategory = KisaElbise.CategoryName,

                UrunFiyat = "30.23 ₺",

                UrunIsim = "Sarı Fitilli Lilralı Elbise 106573",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/sari-fitilli-lilrali-elbise-106573-1032063308.jpg",

            };

            urunler.Add(TOUYCLRDKW);


            Urun TXUYSFWSOY = new Urun

            {

                UrunCategory = KisaElbise.CategoryName,

                UrunFiyat = "30.23 ₺",

                UrunIsim = "Gri Fitilli Lilralı Elbise 106575",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/gri-fitilli-lilrali-elbise-106575-2101535346.jpg",

            };

            urunler.Add(TXUYSFWSOY);


            Urun UTIQVWOONX = new Urun

            {

                UrunCategory = KisaElbise.CategoryName,

                UrunFiyat = "43.19 ₺",

                UrunIsim = "Gri Büzgülü Fitilli Elbise 112167",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/gri-buzgulu-fitilli-elbise-112167-968214923.jpg",

            };

            urunler.Add(UTIQVWOONX);


            Urun HNAAQNGWKJ = new Urun

            {

                UrunCategory = KisaElbise.CategoryName,

                UrunFiyat = "43.19 ₺",

                UrunIsim = "Kahverengi Büzgülü Fitilli Elbise 112166",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/kahverengi-buzgulu-fitilli-elbise-112166-1036179442.jpg",

            };

            urunler.Add(HNAAQNGWKJ);


            Urun DBSEXSVMCQ = new Urun

            {

                UrunCategory = KisaElbise.CategoryName,

                UrunFiyat = "43.19 ₺",

                UrunIsim = "Renkli Çiçek Desenli Sendy Kumaş Elbise 111280",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/renkli-cicek-desenli-sendy-elbise-111280-429069774.jpg",

            };

            urunler.Add(DBSEXSVMCQ);


            Urun TIXULCSWSV = new Urun

            {

                UrunCategory = UzunElbise.CategoryName,

                UrunFiyat = "91.79 ₺",

                UrunIsim = "Siyah Ribanalı Tasarım İki İp Elbise 109257",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-ribanali-tasarim-iki-ip-elbise-109257-2130857509.jpg",

            };

            urunler.Add(TIXULCSWSV);


            Urun OCCDFHHIUM = new Urun

            {

                UrunCategory = UzunElbise.CategoryName,

                UrunFiyat = "151.19 ₺",

                UrunIsim = "Mavi Beli Gipeli Tensel Kot Elbise 105685",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/mavi-beli-gipeli-tensel-kot-elbise-105685-1445732408.jpg",

            };

            urunler.Add(OCCDFHHIUM);


            Urun UYJNHUSNOV = new Urun

            {

                UrunCategory = UzunElbise.CategoryName,

                UrunFiyat = "35.63 ₺",

                UrunIsim = "Pembe (2-5 Yaş) Düğmeli Çiçek Detay Kız Çocuk Elbise 100047",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/pembe-2-5-yas-dugmeli-cicek-detay-kiz-cocuk-elbise-100047-167678835.jpg",

            };

            urunler.Add(UYJNHUSNOV);


            Urun ZUAUSPORPF = new Urun

            {

                UrunCategory = UzunElbise.CategoryName,

                UrunFiyat = "53.99 ₺",

                UrunIsim = "Saks Mavisi Düğmeli Fitilli Elbise 111941",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/saks-mavisi-dugmeli-fitilli-elbise-111941-1073476757.jpg",

            };

            urunler.Add(ZUAUSPORPF);


            Urun NNVVPBRRIE = new Urun

            {

                UrunCategory = UzunElbise.CategoryName,

                UrunFiyat = "43.19 ₺",

                UrunIsim = "İndigo Dokuma Garnili Atlas Elbise 110805",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/indigo-dokuma-garnili-atlas-elbise-110805-2142911139.jpg",

            };

            urunler.Add(NNVVPBRRIE);


            Urun GUVNUMIMQS = new Urun

            {

                UrunCategory = KolluElbise.CategoryName,

                UrunFiyat = "140.39 ₺",

                UrunIsim = "Lacivert Çıt Çıtlı Tensel Kot Elbise 105684",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/lacivert-cit-citli-tensel-kot-elbise-105684-985088132.jpg",

            };

            urunler.Add(GUVNUMIMQS);


            Urun OEIRQBEVIV = new Urun

            {

                UrunCategory = KolluElbise.CategoryName,

                UrunFiyat = "35.63 ₺",

                UrunIsim = "Pudra (2-5 Yaş) Düğmeli Çiçek Detay Kız Çocuk Elbise 100046",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/pudra-2-5-yas-dugmeli-cicek-detay-kiz-cocuk-elbise-100046-900044370.jpg",

            };

            urunler.Add(OEIRQBEVIV);


            Urun RGWHLUDWRN = new Urun

            {

                UrunCategory = KolluElbise.CategoryName,

                UrunFiyat = "43.19 ₺",

                UrunIsim = "Yeşil Büzgülü Fitilli Elbise 112165",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/yesil-buzgulu-fitilli-elbise-112165-810701660.jpg",

            };

            urunler.Add(RGWHLUDWRN);


            Urun BSZHLYSVRO = new Urun

            {

                UrunCategory = KolluElbise.CategoryName,

                UrunFiyat = "35.63 ₺",

                UrunIsim = "Su Yeşili (2-5 Yaş) Düğmeli Çiçek Detay Kız Çocuk Elbise 100048",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/su-yesili-2-5-yas-dugmeli-cicek-detay-kiz-cocuk-elbise-100048-1545051526.jpg",

            };

            urunler.Add(BSZHLYSVRO);


            Urun VNVSTZBDXK = new Urun

            {

                UrunCategory = KolluElbise.CategoryName,

                UrunFiyat = "75.59 ₺",

                UrunIsim = "Antrasit Balon Kol Gipeli Aerobin Elbise 100299",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/antrasit-balon-kol-gipeli-aerobin-elbise-100299-1504460464.jpg",

            };

            urunler.Add(VNVSTZBDXK);


            Urun TANASOWWXW = new Urun

            {

                UrunCategory = DesenliElbise.CategoryName,

                UrunFiyat = "35.63 ₺",

                UrunIsim = "Nar Çiçeği (2-5 Yaş) Düğmeli Çiçek Detay Kız Çocuk Elbise 100049",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/nar-cicegi-2-5-yas-dugmeli-cicek-detay-kiz-cocuk-elbise-100049-946102380.jpg",

            };

            urunler.Add(TANASOWWXW);


            Urun EMIHXKQFIL = new Urun

            {

                UrunCategory = DesenliElbise.CategoryName,

                UrunFiyat = "70.19 ₺",

                UrunIsim = "Siyah Yırtmaçlı Zincir Askılı Elbise 109701",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-yirtmacli-zincir-askili-elbise-109701-1260481165.jpg",

            };

            urunler.Add(EMIHXKQFIL);


            Urun QHOICLMCOX = new Urun

            {

                UrunCategory = DesenliElbise.CategoryName,

                UrunFiyat = "43.19 ₺",

                UrunIsim = "Siyah Ön Arka V Yaka Triko Elbise 109499",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-on-arka-v-yaka-triko-elbise-109499-345575649.jpg",

            };

            urunler.Add(QHOICLMCOX);


            Urun MCTETXRKCK = new Urun

            {

                UrunCategory = DesenliElbise.CategoryName,

                UrunFiyat = "32.39 ₺",

                UrunIsim = "Kırmızı Fitilli Likralı Elbise 111189",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/kirmizi-fitilli-likrali-elbise-111189-85626132.jpg",

            };

            urunler.Add(MCTETXRKCK);


            Urun PNMYXUYHCA = new Urun

            {

                UrunCategory = DesenliElbise.CategoryName,

                UrunFiyat = "53.99 ₺",

                UrunIsim = "Pembe Baskılı Tasarım Elbise 109317",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/pembe-baskili-tasarim-elbise-109317-573228702.jpg",

            };

            urunler.Add(PNMYXUYHCA);


            Urun IOLEKGNNIE = new Urun

            {

                UrunCategory = DuzElbise.CategoryName,

                UrunFiyat = "64.79 ₺",

                UrunIsim = "Bej Beli Gipeli Dokuma Viskon Elbise 92014",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/bej-beli-gipeli-dokuma-viskon-elbise-92014-1892631711.jpg",

            };

            urunler.Add(IOLEKGNNIE);


            Urun FASCNAIMUD = new Urun

            {

                UrunCategory = DuzElbise.CategoryName,

                UrunFiyat = "53.99 ₺",

                UrunIsim = "Kırmızı Fitilli Tasarım Kolsuz Elbise 104782",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/kirmizi-fitilli-tasarim-kolsuz-elbise-104782-1221133445.jpg",

            };

            urunler.Add(FASCNAIMUD);


            Urun HEYDAVOMIT = new Urun

            {

                UrunCategory = DuzElbise.CategoryName,

                UrunFiyat = "64.79 ₺",

                UrunIsim = "Siyah Polo Yaka Likralı Elbise 110720",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/siyah-polo-yaka-likrali-elbise-110720-1426413940.jpg",

            };

            urunler.Add(HEYDAVOMIT);


            Urun OKFFZHJBWW = new Urun

            {

                UrunCategory = DuzElbise.CategoryName,

                UrunFiyat = "32.39 ₺",

                UrunIsim = "Bisküvi Dik Yaka Fitilli Elbise 100452",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/biskuvi-dik-yaka-fitilli-elbise-100452-135856492.jpg",

            };

            urunler.Add(OKFFZHJBWW);


            Urun FASCCNAIMUD = new Urun

            {

                UrunCategory = DuzElbise.CategoryName,

                UrunFiyat = "53.99 ₺",

                UrunIsim = "Kırmızı Fitilli Tasarım Kolsuz Elbise 104782",

                UrunUrl = "https://cdn.modamizbir.com/Uploads/UrunResimleri/buyuk/kirmizi-fitilli-tasarim-kolsuz-elbise-104782-1221133445.jpg",

            };

            urunler.Add(FASCCNAIMUD);



        }

        static internal Database Instance()
        {
            if (_instance == null)
            {
                _instance = new Database();
            }

            return _instance;
        }
        public async Task<Category> GetCategory(string username)
        {
            foreach (var item in categories)
            {
                if (item.CategoryName == username)
                {
                    return item;
                }
            }
            return null;
        }
        public async Task<List<Category>> GetAllCategory()
        {
            return categories;
        }

        public async Task<List<Urun>> ButunUrunleriGetir()
        {
            return urunler;
        }
        public async Task<List<Urun>> KategoriUrunGetir(string kategori)
        {
            List<Urun> uruns = new List<Urun>();

            foreach (var item in urunler)
            {
                if (item.UrunCategory == kategori)
                {
                    uruns.Add(item);
                }
            }
            return uruns;
        }
        public async Task<Urun> UrunGetir(string isim)
        {
            foreach (var item in urunler)
            {
                if (item.UrunIsim == isim)
                {
                    return item;
                }
            }
            return null;

        }
        public async Task<List<Urun>> FavorileriGetir()
        {
            return Loader.FavoriYukle();

        }
        public async Task<bool> FavorilereEkle(Urun urun)
        {
           List<Urun> urn = Loader.FavoriYukle();
            urn.Add(urun);
            Loader.FavoriKaydet(urn);
            return true;
        }
        public async Task FavoridenSil(string baslik)
        {
            List<Urun> urn = Loader.FavoriYukle();

            foreach (var item in urn.ToList())
            {
                if (item.UrunIsim == baslik)
                {
                    urn.Remove(item);
                }
            }
            Loader.FavoriKaydet(urn);

        }
        public async Task<List<Urun>> SepetiGetir()
        {
            return Loader.SepetYukle();
        }
        public async Task<bool> SepeteEkle(Urun urun)
        {
            List<Urun> urn = Loader.SepetYukle();

            urn.Add(urun);
           Loader.SepetKaydet(urn);
            return true;

        }
        public async Task SepettenSil(string baslik)
        {
            List<Urun> urn = Loader.SepetYukle();

            foreach (var item in urn.ToList())
            {
                if (item.UrunIsim == baslik)
                {
                    urn.Remove(item);
                }
            }
            Loader.SepetKaydet(urn);

        }
    }
    [Serializable]
    public class Urun
    {
        public string UrunUrl { get; set; }
        public string UrunIsim { get; set; }
        public string UrunFiyat { get; set; }
        public string UrunCategory { get; set; }
    }
    [Serializable]
    public class Category
    {
        public string CategoryImg { get; set; }
        public string CategoryName { get; set; }
        public bool childvarmi { get; set; }
        public Category ParentCategory { get; set; }
    }
}
