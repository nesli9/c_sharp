// /* Console.WriteLine(5000); //urunA
// Console.WriteLine(6000); //urunB
// Console.WriteLine(7000); //urunC */

// /* Console.WriteLine(5000 * 1.18); //urunA KDVsi
// Console.WriteLine(6000 * 1.18); //urunB KDVsi
// Console.WriteLine(7000 * 1.18); //urunC KDVsi */


// var kdvOrani = 1.08 ;
// var urunA = 5000;
// var urunB = 6000;
// var urunC = 7000;
// var urunD = 5500;



// Console.WriteLine(urunA * kdvOrani); //urunA KDVsi
// Console.WriteLine(urunB * kdvOrani); //urunB KDVsi
// Console.WriteLine(urunC * kdvOrani); //urunC KDVsi
// Console.WriteLine(urunD * kdvOrani); //urunD KDVsi


// var sayi = 20;
// var urunAdi = "Samsung S23";

// Console.WriteLine(sayi);
// Console.WriteLine(urunAdi);



/* 

   Uygulama 1 : bir öğrencini aşağıdaki bilgileri için gerekli deişkenleri oluşturunuz.

    öğrenci Adı
    öğrenci soyadı
    öğrenci ad ve soyad
    öğrencinin numarası 
    öğrenci cinsiyet
    öğrenci tc kimlik
    öğrenci doğum yılı
    öğrenci adres bilgisi
    öğrenci yaşı

   uygulama 2 : aşağıdaki ürünlerin toplam bilgisini hesaplayınız.

    ürün 1 --> 50 TL
    ürün 2 --> 60.5 TL
    ürün 3 --> 356.45 TL

*/

var ogrenciAdi = "Ahmet ";
var ogrenciSoyadi = "Turan";
var ogrenciAdsoyad = ogrenciAdi + ogrenciSoyadi;
var ogrenciNumara = "1025";
var ogrenciCinsiyeti=  true;
var ogrenciTcKimlikNo= "111111111";
var ogrenciDogumYili= 2005;
var ogrenciAdres="istanbul";
var ogrenciYas = 2024- ogrenciDogumYili;

Console.WriteLine(ogrenciAdi);
Console.WriteLine(ogrenciSoyadi);
Console.WriteLine(ogrenciAdsoyad);
Console.WriteLine(ogrenciNumara);
Console.WriteLine(ogrenciCinsiyeti);
Console.WriteLine(ogrenciTcKimlikNo);
Console.WriteLine(ogrenciDogumYili);
Console.WriteLine(ogrenciAdres);
Console.WriteLine(ogrenciYas);



var urun1_fiyat = 50;
var urun2_fiyat =  60.5;
var urun3_fiyat =   356.45;

var toplam = urun1_fiyat + urun2_fiyat + urun3_fiyat ;

Console.WriteLine(toplam);






