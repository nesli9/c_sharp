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

// var ogrenciAdi = "Ahmet ";
// var ogrenciSoyadi = "Turan";
// var ogrenciAdsoyad = ogrenciAdi + ogrenciSoyadi;
// var ogrenciNumara = "1025";
// var ogrenciCinsiyeti=  true;
// var ogrenciTcKimlikNo= "111111111";
// var ogrenciDogumYili= 2005;
// var ogrenciAdres="istanbul";
// var ogrenciYas = 2024- ogrenciDogumYili;

// Console.WriteLine(ogrenciAdi);
// Console.WriteLine(ogrenciSoyadi);
// Console.WriteLine(ogrenciAdsoyad);
// Console.WriteLine(ogrenciNumara);
// Console.WriteLine(ogrenciCinsiyeti);
// Console.WriteLine(ogrenciTcKimlikNo);
// Console.WriteLine(ogrenciDogumYili);
// Console.WriteLine(ogrenciAdres);
// Console.WriteLine(ogrenciYas);



// var urun1_fiyat = 50;
// var urun2_fiyat =  60.5;
// var urun3_fiyat =   356.45;

// var toplam = urun1_fiyat + urun2_fiyat + urun3_fiyat ;

// Console.WriteLine(toplam);


// int sayi = 10;
// double kdvOrani = 1.18;
// char cinsiyet = 'K';
// string cinsiyet2 = "Kadın";
// string urunAdi = "samsung s23";
// var satisDurumu = true;


// Console.Write("1. sayı : ");
// var sayi1 = Convert.ToInt32(Console.ReadLine()); //string to int

// Console.Write("2. sayı : ");
// var sayi2 = Convert.ToInt32(Console.ReadLine());

// var toplam = sayi1 + sayi2 ;

// Console.WriteLine(toplam);


// int a = 10;
// long b = a;

// long d = 20;
// int e = (int)d;

// double f = 20.5;
// float g =(float )f;

// double h = 10.5;
// int i = (int)h;

// Console.WriteLine(i);

// int x = 10;
// string z =x.ToString();



// int? maas = null; //
// bool? isActive = null;

// Console.WriteLine(maas.HasValue);
// Console.WriteLine(maas.GetValueOrDefault());
// Console.WriteLine(isActive.GetValueOrDefault());


// char cinsiyet = 'E';
// string cinsiyet2 = "Erkek";

// Console.Write("adı : ");
// var ad = Console.ReadLine();

// Console.Write("soyadı: ");
// var soyad= Console.ReadLine();

// Console.Write("yas : ");
// var yas= Console.ReadLine();

// //string mesaj = ad + " " + soyad + " isimli kişi" + " " + yas + " yaşındadır.";

// string mesaj = $"{ad} {soyad} isimli kişi {yas} yaşındadır";


// Console.WriteLine(mesaj);



//string mesaj =  "Ahmet TURAN isimli kişi 20 yaşındadır.";

//var sonuc = mesaj.Length;
//var sonuc = mesaj.ToLower();
//var sonuc = mesaj.ToUpper();
//var sonuc = mesaj.Trim(); //string kümesinin başındaki ve sonundaki boşluklar silinir.
//var sonuc = mesaj.Split(" ");
//var sonuc = mesaj[3];
//var sonuc = mesaj.Split(" ")[0];
//var sonuc = mesaj.StartsWith("A");
//var sonuc = mesaj.EndsWith(".");
//var sonuc = mesaj.Contains("isimli");
//var sonuc = mesaj.IndexOf("kişi");
// var sonuc = mesaj.Substring(10);
// var sonuc = mesaj.Substring(6,5);

// Console.WriteLine(sonuc);



// --- Uygulama----

//string kursAdi = ".NET ile C# Programlama Dili";

//Kaç karaktere sahip
//var sonuc = kursAdi.Length;

//hepsini küçük harf yapınız.
//var sonuc = kursAdi.ToLower();

//'.'ile mi başlamaktadır.
//var sonuc = kursAdi.StartsWith(".");

//C# bilgisi hangi konumda bulunmaktadır?
//var sonuc = kursAdi.StartsWith(".");

//C# içeriyor mu?
//var sonuc = kursAdi.Contains('C#');

//dili kelimesi yerine dersleri yazınız (replace)
//kursAdi = kursAdi.Replace("Dili","Dersler:");


//Console.WriteLine(sonuc);


//-- DateTime---

// var simdi = DateTime.Now;


// Console.WriteLine(simdi);
// Console.WriteLine(simdi.Year);
// Console.WriteLine(simdi.Month);
// Console.WriteLine(simdi.Day);
// Console.WriteLine(simdi.DayOfWeek);

// DateTime dt = new DateTime(2018,6,10);
// DateTime dt2 = dt.AddYears(1);

// Console.WriteLine(dt);
// Console.WriteLine(dt2);

// var fark = simdi - dt;

// Console.WriteLine(fark.TotalDays);


//----diziler----

// var kursAdi = ".NET ile C# Programlama Dili".Split(' ');

// string[] isimler = new string[5];

// isimler[0] = "ahmet";
// isimler[1] = "mehmet";
// isimler[2] = "ali";
// isimler[3] = "veli";
// isimler[4] = "fatma";
//isimler[4] = null;//boş değer atanabilir bir veri tipidir.

// string[] isimler = {"ahmet","veli","canan","ayşe","fatma"};


// int[] numaralar = new int[5];

// numaralar[0]= 123;
// numaralar[1]=978 ;
// numaralar[2]=  654;
// numaralar[3]=   321;
// numaralar[4]=    987;


// Console.WriteLine($"{isimler[1]}: {numaralar[1]}");



//-----dizi metodları----

// string[] sehirler = {"istanbul","rize","kocaeli"};
// int[] plakalar = {34,53,41};


// // sehirler[0]= "sakarya";
// sehirler.SetValue("sakarya",1);



// Console.WriteLine(sehirler[1]);
// Console.WriteLine(sehirler.GetValue(2));
// Console.WriteLine(sehirler.Length);
// Console.WriteLine(Array.IndexOf(sehirler , "rize"));


// Array.Sort(sehirler);//sort --> dizidekileri alfabetik sıralar (büyükten küçüğe)
// Array.Sort(plakalar);



// Array.Reverse(plakalar);
// Array.Clear(sehirler);
// //Array.Clear(plakalar);
// Array.Clear(plakalar ,0,1);

// Console.WriteLine(plakalar.GetValue(0));

// // Console.WriteLine(sehirler.GetValue(0));
// // Console.WriteLine(sehirler.GetValue(1));
// // Console.WriteLine(sehirler.GetValue(2));


// Console.WriteLine(plakalar.GetValue(0));
// Console.WriteLine(plakalar.GetValue(1));
// Console.WriteLine(plakalar.GetValue(2));



//----- array slicing -----

// string[] sehirler = {"zonguldak" , "rize","kocaeli", "istanbul","ankara"};


//Console.WriteLine(sonuc.Length);

// foreach (var sehir in sehirler[0..3])
// {
//     Console.WriteLine(sehir);
// }

// foreach (var sehir in sehirler[..3])
// {
//     Console.WriteLine(sehir);
// }

// foreach (var sehir in sehirler[2..])
// {
//     Console.WriteLine(sehir);
// }

// string il = "kocaeli";

// Console.WriteLine(il[(..5)]);




// --- Dizi Uygulama ---

// ogrenciler ve notlar isminde 2 tane dizi oluşturunuz ve dizi elemanlarını kullanıcıdan aldığınız değerlerle doldurunuz. (3 öğrenci)

// ogrenciler dizisi kaç elemanlıdır, yazdırınız.
// ilk 2 öğrencinin ad ve not bilgisini yazdırınız.
// tüm öğrencilerin not ortalaması nedir? 





// Çok Boyutlu Diziler

// Ali   => 50, 60, 70
// Ahmet => 60, 80, 90
// Canan => 50, 70, 30

// Her öğrencinin not ortalamasını hesaplayınız.

// string[] ogrenciler = {"ahmet","ali","canan"};
// int[,] notlar = new int[3,3];


// //ali 
// notlar[0,0] =50;
// notlar[0,1] =60;
// notlar[0,2] =70;

// //ahmet 
// notlar[1,0] =60;
// notlar[1,1] =80;
// notlar[1,2] =90;

// //canan 
// notlar[2,0] =50;
// notlar[2,1] =70;
// notlar[2,2] =30;


// var ortalama_1 = (notlar[0,0] + notlar[0,1] + notlar[0,2] ) /3;
// var ortalama_2 = (notlar[1,0] + notlar[1,1] + notlar[1,2] ) /3;
// var ortalama_3 = (notlar[2,0] + notlar[2,1] + notlar[2,2] ) /3;

// Console.WriteLine($"{ogrenciler[0]} isimli öğrencinin not ortalaması : {ortalama_1}");
// Console.WriteLine($"{ogrenciler[1]} isimli öğrencinin not ortalaması : {ortalama_2}");
// Console.WriteLine($"{ogrenciler[2]} isimli öğrencinin not ortalaması : {ortalama_3}");


//--- referans tipler

// int x = 10;
// int y = x;

// int[] x = {10,20};
// int[] y = x;

// Console.WriteLine(x[0]);
// Console.WriteLine(y[0]);

// x[0]=20;

// Console.WriteLine(x[0]);
// Console.WriteLine(y[0]);


//-------- operatörler -------


// var a = 10;
// var b = 5;
// var c = 2;

// var sonuc = a+b;
// var sonuc2 = a-b;
// var sonuc3 = a/b;
// var sonuc4 = a*b;
// var sonuc5 = (a+b)*c;
// var sonuc6 = a%b;


// Console.WriteLine(sonuc);
// Console.WriteLine(sonuc2);
// Console.WriteLine(sonuc3);
// Console.WriteLine(sonuc4);
// Console.WriteLine(sonuc5);
// Console.WriteLine(sonuc6);




// Aritmetik Operatör Uygulamaları

// a = 10, b = 5, c = 20 ise c - a farkının b katı kaçtır?

// int? a = 50; int b = 20; ise a + b değerini hesaplayınız. (eğer a null ise sonuç nedir?)

// a=10 b=20 ise a=b--; atamasından sonra a ve b değerleri ne olur?

// Klavyeden girilen bir sayının tek / çift kontrolünü yapınız.


// int a = 10 ; 
// int b = 5;
// int c = 20;

// var sonuc = (c - a)*b ;

// Console.WriteLine(sonuc);

// int? = 50;
// int? a = null ; 
// int b = 20;

// var sonuc = (a ?? 0) + b ; //a null bir değerese 0 değerini at ve işlemi yap.


// Console.WriteLine(sonuc);


// int a = 10;
// int b = 20;

// a = b--;

// Console.WriteLine(a);
// Console.WriteLine(b);


// Console.Write("sayı : ");

// int sayi = int.Parse(Console.ReadLine() ?? "0");

// var sonuc = sayi % 2;

// Console.WriteLine(sonuc); 



// Atama Operatörleri

// var a = 5;
// var b = 10;

// a += b; // a = a + b;
// a += 5; // a = a + 5;
// a -= b; // a = a - b;
// a *= b; // a = a * b;
// a /= b; // a = a / b;
// a %= b; // a = a / b;


//math

// double sonuc ;

// sonuc = Math.Pow(2,3);
// sonuc = Math.Sqrt(25);
// sonuc = Math.Abs(-10);
// sonuc = Math.Round(4.5);
// sonuc = Math.Round(4.6); //sayıyı yuvarlar
// sonuc = Math.Round(4.4);
// sonuc = Math.Ceiling(4.4); //her zaman yukarı yuvarlar
// sonuc = Math.Floor(4.6); //her zaman aşağı yuvarlar
// sonuc = Math.Max(10,20);
// sonuc = Math.Min(10,20);

// Console.WriteLine(sonuc);



// Karşılaştırma Operatörleri


// int a = 5, b=5 , c=10,d=3;
// string username = "sadikturan";
// string password = "1234";


// var sonuc = (a==b);
// sonuc = (c ==d);
// sonuc = (username == "sadikturan");
// sonuc = (password == "12345");

// sonuc = (a!=b);
// sonuc = (a>c);
// sonuc = (a<c);
// sonuc = (a>=b);

// ternary
// var sonuc2 = (a > b) ? "a büyük": (a == b) ? "a b eşit": "b büyük"; //iç içe ternary

// Console.WriteLine(sonuc);




// Karşılaştırma Operatör Uygulamaları

// Klavyeden girilen yaş bilgisine göre oy kullanabilme durumunu inceleyiniz.


// Console.Write("yaşınız: ");
// var yas = Convert.ToInt32(Console.ReadLine());
// var sonuc = (yas >= 18) ? "ehliyet alabilirsiniz" : "ehliyet için yaşınız tutmuyor";
//Console.WriteLine("ehliyet alabilme durumu : " + sonuc);
// Console.WriteLine(sonuc);



// Girilen bir sayının işaretini kontrol ediniz.

// Console.Write("sayı :");
// var sayi = Convert.ToInt32(Console.ReadLine());
// var sonuc = (sayi >0) ? "sayı pozitif" : "sayı negatif";
// Console.WriteLine(sonuc);



// Girilen bir sayının tek/çift durumunu kontrol ediniz.

Console.Write("sayı: ");
var sayi = Convert.ToInt32(Console.ReadLine());
var sonuc = (sayi % 2 == 1) ? "sayı tek": "sayı çift";
Console.WriteLine(sonuc);









