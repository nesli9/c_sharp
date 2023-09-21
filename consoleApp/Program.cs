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

// Console.Write("sayı: ");
// var sayi = Convert.ToInt32(Console.ReadLine());
// var sonuc = (sayi % 2 == 1) ? "sayı tek": "sayı çift";
// Console.WriteLine(sonuc);


// Mantıksal Operatörler

// var a = true;
// var b = true;
// var c = false;
// var d = false;

// // 1- Ve - &&
// var sonuc = (a && b); 
// sonuc = (a && c);
// sonuc = (c && d);

// // 2- Veya - ||
// sonuc = (a || b);
// sonuc = (c || b);
// sonuc = (c || d);

// // 3- Değil - !
// sonuc = !c;
// Console.WriteLine(sonuc);   



// Mantıksal Operatörler Uygulamaları

// 1- Yaşı 18' den büyük ya da veli izni varsa bir işte çalışabilir durumunu kontrol ediniz.

// int yas = 17;
// bool veli_izni = false;
// var sonuc = (yas >= 18 || veli_izni) ? "çalışabilir": "çalışamaz";
// Console.WriteLine(sonuc);

// 2- Ders notu 50-100 arasındaysa geçti değilse kalsın bilgisini yazdırınız.

// int not = 40;
// var sonuc = (not >= 50 && not <= 100) ? "geçti":"kaldı";
// Console.WriteLine(sonuc);

// 3- Ders ortalaması en az 70 puan ve zayıfı yoksa teşekkür belgesi alabilme durumunu kontrol ediniz.

// int ortalama = 65;
// int zayif = 0;

// var sonuc = (ortalama >= 70) ? 
//                 ((zayif == 0) ? "teşekkür alabilir":"zayıfınız olmaması gerekiyor.") :
//                 "notunuz en az 70 olmalıdır.";

// Console.WriteLine(sonuc);

// 4- İşe girmek için en az önlisans ya da lisans mezunu olma durumunu kontrol ediniz. Sigara kullanmama koşulu.

// string egitim = "lise";
// bool sigara_icme = false;
// var sonuc = ((egitim == "lisans" || egitim == "önlisans") && (!sigara_icme)) ? "işe girebilir": "işe giremez";
// Console.WriteLine(sonuc);

// 5- Uygulamaya giriş kontrolünü username ya da parola için yapalım.

// string email = "info@sadikturan.com";
// string username = "sadikturan";
// string password = "12345";

// var sonuc = ((email == "info@sadikturan" || username=="sadikturan2") && (password == "12345")) ? "başarılı":"başarısız";
// Console.WriteLine(sonuc);


//random 

// var rnd = new Random();
// int sayi = rnd.Next(50,100);

// string[] takimlar = {"beşiktaş","fenerbahçe","galatasaray"};
// var rnd = new Random();
// int sayi = rnd.Next(3);

// Console.WriteLine(takimlar[sayi]);



// if/else bloğu

// string username = "sadikturan";
// string password = "12345";


// if (username == "sadikturan"){
//     if (password == "12345"){
//         Console.WriteLine("merhaba BTK");
//     }else{
//         Console.WriteLine("parola yanlış");
//     }
    
// }else{
//     Console.WriteLine("username yanlış");
// }



//if/else if


// string username = "sadikturan";
// string password = "12345";


// if (username != "sadikturan"){
//         Console.WriteLine("username yanlış");
// }else if(password !="12345"){
//     Console.WriteLine("parola yanlış");
// }else{
//     Console.WriteLine("merhaba BTK");
// }

// int x = 10;
// int y = 20;

// if (x>y){
//     Console.WriteLine("x y den büyük");
// }else if (x == y){
//     Console.WriteLine("x ve y eşit");
// }else
// {
//     Console.WriteLine ("x y den küçük") ;    // else if koşulu sağlanmazsa bu kod çalışır
// }




// if/else Uygulamaları

// 1- Kullanıcıya sunulan bir menü içinden seçilecek olan 4 işlem tipine göre hesaplama yapınız.
// Console.Write("1.sayı: ");
// var sayi1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("2.sayı: ");
// var sayi2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Toplama için: +");
// Console.WriteLine("Çıkarma için: -");
// Console.WriteLine("Çarpma için:  *");
// Console.WriteLine("Bölme için:   /");

// Console.Write("Seçiminiz: ");
// var secim = Console.ReadLine();

// double sonuc = 0;
// bool ok = true;

// if(secim == "+") {
//     sonuc = sayi1 + sayi2;
// } else if(secim == "-") {
//     sonuc = sayi1 - sayi2;
// } else if(secim == "*") {
//     sonuc = sayi1 * sayi2;
// } else if(secim == "/") {
    
//     if(sayi2 == 0) {
//         ok = false;
//         Console.WriteLine("bölen 0 olamaz.");
//     } else {
//         sonuc = sayi1 / sayi2;
//     }

// } else {
//     ok = false;
//     Console.WriteLine("yanlış seçim");
// }
// if(ok) {
//  Console.WriteLine($"işlem sonucu: {sayi1} {secim} {sayi2} = {sonuc}");
// }


// 2- Bir öğrencinin 2 yazılı 1 sözlü notunu alıp hesaplanan ortalamaya göre not aralığına karşılık gelen not bilgisini yazınız.

    // 0  -  24  => 0
    // 25 -  44  => 1
    // 45 -  54  => 2
    // 55 -  69  => 3
    // 70 -  84  => 4
    // 85 -  100 => 5


// Console.Write("1.yazılı : ");
// int not1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("2.yazılı : ");
// int not2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("sözlü : ");
// int sozlu = Convert.ToInt32(Console.ReadLine());

// var ortalama = (not1 + not2 + sozlu)/3;
// int not=-1;
// bool ok = true;

// if (ortalama>0 && ortalama<25){
//     not = 0;
// }else if (ortalama>=25 && ortalama<44){
//     not = 1;
// }else if (ortalama>=45 && ortalama<54){
//     not = 2;
// }else if (ortalama>=55 && ortalama<69){
//     not = 3;
// }else if (ortalama>=70 && ortalama<84){
//     not = 4;
// }else if (ortalama>=85 && ortalama<=100){
//     not = 5;
// }else{
//     ok=false ;
//     Console.WriteLine("yanlış not girdiniz");
// }

// Console.WriteLine($"not ortalamanız : {ortalama} ve notunuz : {not}");


// 3- Girilen 3 sayıdan en büyüğünü bulunuz.

// Console.Write("a : ");
// int a = Convert.ToInt32(Console.ReadLine()) ;

// Console.Write("b : ");
// int b = Convert.ToInt32(Console.ReadLine()) ;

// Console.Write("c : ");
// int c = Convert.ToInt32(Console.ReadLine()) ;

// int enbuyuk = a;

// if (a > b && a>c){
//     enbuyuk = a;
// }else if (b>a && b>c){
//     enbuyuk = b;
// }else{
//     enbuyuk = c;
// }

// Console.WriteLine($"en büyük : {enbuyuk}");



// Switch-Case

// int gun = (int)DateTime.Now.DayOfWeek; // 0=> pazar, 1=> pazartesi ... 6=> cumartesi

// switch (gun){
//     case 0:
//         Console.WriteLine("pazar");
//         break;
//     case 1:
//         Console.WriteLine("pazartesi");
//         break;
//     case 2:
//         Console.WriteLine("salı");
//         break;
//     case 3:
//         Console.WriteLine("çarşamba");
//         break;
//     case 4:
//         Console.WriteLine("perşembe");
//         break;
//     case 5:
//         Console.WriteLine("cuma");
//         break;
//     case 6:
//         Console.WriteLine("cumartesi");
//         break;

//     default:
//         Console.WriteLine("hatalı gün");
//         break;
// } 



// int ay =12;

// switch (ay)
// {
//     case 12:
//     case 1:
//     case 2:
//         Console.WriteLine("Kış");
//         break;
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("İlkbahar");
//         break;
//     case 6:
//     case 7:
//     case 8:
//         Console.WriteLine("yaz");
//         break;
//     case 9:
//     case 10:
//     case 11:
//         Console.WriteLine("sonbahar");
//         break;
    
//     default:
//         Console.WriteLine("Hatalı ay bilgisi");
//         break;
// }



//ternary

// int sayi = -9;

// var sonuc = (sayi % 2 == 0) ? 
//                 (sayi > 0) ? "sayı pozitif çift": "sayı negatif çift": 
//                 (sayi > 0) ? "sayı pozitif tek": "sayı negatif tek";

// Console.WriteLine(sonuc);


//döngüler

//for

// for (int i = 0; i <= 10; i++) // for(kontrol değişkeni ; kontrol ; güncellemesi)
// {
//     Console.WriteLine(i);
// }


// For Döngüsü Uygulamaları

// 1- "1-100" arasındaki sayıların toplamını hesaplayınız.

// var toplam = 0;
// for (int i = 1; i < 100; i++){
//     if(i % 2 == 1) {
//         toplam += i;
//     }
//     toplam += i;
// }
// Console.WriteLine(toplam);

// 2- Klavyeden girilen başlangıç ve bitiş değerleri arasındaki tüm sayıların toplamını hesaplayınız.
// Console.Write("başlangıç : ");
// var baslangıc = Convert.ToInt32(Console.ReadLine());

// Console.Write("bitiş   : ");
// var bitis    = Convert.ToInt32(Console.ReadLine());

// Console.Write("artış   : ");
// var artıs    = Convert.ToInt32(Console.ReadLine());

// var toplam = 0;
// for (int i = baslangıc ; i < bitis; i= i + artıs){
//     toplam += i ;
// }

// Console.WriteLine(toplam);


//3- {"ali","ahmet","can","yelda","seda"} dizindeki tüm elemanları ekrana yazdırın.

// string[] isimler = {"ahmet","ali","can","yelda","seda"};

// for (int i = 0; i < isimler.Length; i++){
//     Console.WriteLine(isimler[i]);
// }



// 4- {1,3,4,34,41,56,89} dizisindeki sayılardan hangisileri 3' ün katıdır?

// int[] sayilar = {1,3,4,34,41,56,89} ;

// for (int i = 0; i < sayilar.Length; i++){
//     if (sayilar[i]%3 == 0){
//         Console.WriteLine(sayilar[i]);
//     }
// }


//while döngüsü

// for (var i = 0; i < 10; i++){
//     Console.WriteLine(i);
// }

// var i=0;

// while (i<10){
//     Console.WriteLine(i);
//     i++;
// }


// string[] isimler = {"ali","ahmet","canan"};

// var i = 0;

// while (i < isimler.Length){
//     Console.WriteLine(isimler[i]);
//     i++;
// }


// var secim = "e";
// var sayac = 1;
// var toplam = 0;

// while (secim == "e"){
//     Console.Write($"{sayac}. sayı : ");
//     toplam += Convert.ToInt32(Console.ReadLine());

//     Console.Write("devam etmek istiyor musunuz? (e/h)");
//     secim = Console.ReadLine();

//     sayac++;
// }

// Console.WriteLine($"{sayac-1} adet sayının toplamı : {toplam}");


//break && continue

// string isim = "sadık turan";

// for (var i = 0; i < isim.Length; i++){
//     // if (isim[i] == 'ı'){
//     //     continue;
//     // }
//     if (isim[i] == 'ı'){
//         break;
//     }
//     Console.WriteLine(isim[i]);
// }


// int x = 0;

// while(x < 5) {
//     x++;
//     if(x == 3) 
//         continue;
//     Console.WriteLine(x);
// }


// While Döngüsü Uygulama

// Sayı Tahmin
// 1-100 arasında rastgele tutulan bir sayıyı buldurmaya çalışın.
// Tanımlanan hak bittiğinde oyun bitmeli.

// var rnd = new Random();
// int tutulan = rnd.Next(1, 100);
// int hak = 3;

// while(hak > 0) {
//     Console.WriteLine(tutulan);

//     Console.Write("sayı: ");
//     int sayi = Convert.ToInt32(Console.ReadLine());

//     hak--;

//     if(sayi == tutulan) {
//         Console.WriteLine("tebrikler bildiniz");
//         break;
//     } 
//     else {
//         if(hak == 0) {
//             Console.WriteLine("oyun bitti");
//             break;
//         }
//         if(tutulan > sayi) {
//             Console.WriteLine("yukarı");
//         } else {
//             Console.WriteLine("aşağı");
//         }
//     }
// }



//do-while döngüsü

// int i = 1;

// do {
//     Console.WriteLine(i);
//     i++;
// }while (i<10);

// Console.Write("adet : ");
// int adet = Convert.ToInt32(Console.ReadLine());

// string[] urunler = new string[adet];

// int i = 0;

// do{
//     Console.Write("ürün adı : ");
//     urunler[i] = Console.ReadLine() ?? "";
//     i++;
// }while(adet != i);

// Console.WriteLine("ürünler listeleniyor ....");

// for (int a = 0; a < urunler.Length; a++){
//     Console.WriteLine(urunler[a]);
// }


//foreach

// string ad = "ahmet";

// for (int i = 0; i < ad.Length; i++){
//     Console.WriteLine(ad[i]);
// }

// foreach (var harf in ad){
//     Console.WriteLine(harf);
// }


// int[] sayilar = {10,20,40,45};

// foreach (var sayi in sayilar){
//     if (sayi ==20){
//         continue;
//     }
//     Console.WriteLine(sayi);
// }

// foreach (var sayi in sayilar){
//     if (sayi == 40){
//         break;
//     }
//     Console.WriteLine(sayi);
// }



// dosya okuma


// StreamReader sr =  File.OpenText("deneme.txt");
// var s = "";

// while ((s = sr.ReadLine()) != null){
//     Console.WriteLine(s);
// }


// string sonuc = File.ReadAllText("deneme.txt");
// string[] sonuc2 = File.ReadAllLines("deneme.txt");

// Console.WriteLine(sonuc);
// Console.WriteLine(sonuc2[0]);


// using(StreamWriter sw = File.CreateText("deneme.txt")){
//     sw.WriteLine("MERHABA");
//     sw.WriteLine("BTK");
//     sw.WriteLine("AKADEMİ");
// }

// using(StreamWriter sw = File.AppendText("deneme.txt")){
//     sw.WriteLine("dersleri");
//     sw.WriteLine("btk");
//     sw.WriteLine("c#");
// }

// File.WriteAllText("deneme.txt","merhaba "); //dosya üzerindeki verileri silip üzerine yazar . işi bitince kapatma işini kendi yapr.
// File.AppendAllText("deneme.txt","btk akademi");


// using(StreamReader sr = File.OpenText("deneme.txt")) {
//     var s = "";

//     while((s = sr.ReadLine()) != null) {
//         Console.WriteLine(s);
//     }
// }


// Directory.CreateDirectory("temp");
// Directory.CreateDirectory("temp/deneme");
// Directory.CreateDirectory("temp/deneme2");

// if (Directory.Exists("temp/deneme2")){
//     Directory.Delete("temp/deneme2");
// }else{
//     Console.WriteLine("silmek istediğiniz klasör yok!"); 
// }

//string path = @"D:\SİSTEM-SAKIN-SİLME\Desktop\temp";
// string path = Directory.GetCurrentDirectory() +"/temp"; //proje dosya konumu

// Console.WriteLine(path);
// Directory.CreateDirectory(path);


// string rootPath = Directory.GetCurrentDirectory();

// string[] dirs = Directory.GetDirectories(rootPath,"*",SearchOption.TopDirectoryOnly);

// foreach (var dir in dirs){
//     Console.WriteLine(dir);
// }


// string source_path = @"D:\SİSTEM-SAKIN-SİLME\Desktop\Codes\Proje\c_sharp\consoleApp\img";
// string dest_path = @"D:\SİSTEM-SAKIN-SİLME\Desktop\Codes\Proje\c_sharp\consoleApp\images\";

// string[] files = Directory.GetFiles(source_path,"*",SearchOption.AllDirectories);

// foreach (var file in files){
//     Console.WriteLine(file);
//     Console.WriteLine(Path.GetExtension(file));
//     Console.WriteLine(Path.GetFileNameWithoutExtension(file));
//     Console.WriteLine(Path.GetFileName(file));

//     var info = new FileInfo(file);
//     Console.WriteLine($"{Path.GetFileName(file)}: {info.Length}");

//     if (!Directory.Exists(dest_path)){
//         Directory.CreateDirectory(dest_path);
//     }

//     string name = Path.GetRandomFileName()+ Path.GetExtension(file);
//     File.Copy(file, $"{dest_path}{name}");

// }



//class

// namespace ConsolApp{
//     class Program{
//         static void Main(string[] args){
//             Console.WriteLine("Merhaba BTK");

//             //class => object (ogr1,ogr2)
//             Ogrenci ogr1=new Ogrenci(){OgrenciNo = "100",AdSoyad = "Ada bilgi",Sube = "6/A"};
//             Ogrenci ogr2=new Ogrenci(){OgrenciNo = "200",AdSoyad = "Yiğit bilgi",Sube = "7/A"};
//             Ogrenci ogr3=new Ogrenci(){OgrenciNo = "300", AdSoyad = "Çınar turan",Sube = "1/A"};
//             Ogrenci ogr4=new Ogrenci(){OgrenciNo = "400", AdSoyad = "Ahmet turan",Sube = "3/A"};

//             Ogrenci[] ogrenciler = new Ogrenci[4]{ogr1,ogr2,ogr3,ogr4};

//             foreach (var ogrenci in ogrenciler){
//                 Console.WriteLine(ogrenci.BilgileriYazdir());
//             }

//         }
//     class Ogrenci{
//         //property => string,int
//         public string OgrenciNo { get; set; }
//         public string AdSoyad { get; set; }
//         public string Sube { get; set; }


//         //methods => bilgileriyazdir()
//         public string BilgileriYazdir(){
//             return $"{this.OgrenciNo} numaralı öğrencinin adı {this.AdSoyad} ve şubesi {this.Sube}";
//         }
//     }
//     }
// }

// ConsoleApp => Program, Ogrenci
// System => Console
// System.IO => File, Directory, Path




// class - uygulama

// using System;

// namespace ConsoleApp{

//     class Program{
//         static void Main(string[] args){

//             var soru1 = new Soru(){
//                 SoruMetni = "Hangisi programlama dili değildir?",
//                 Secenekler = new string[4]{"python","c#","java","html"},
//                 Cevap ="html"
//             };
//             var soru2 = new Soru(){
//                 SoruMetni = "Hangisi en popüler programlama dilidir?",
//                 Secenekler = new string[4]{"python","c#","java","html"},
//                 Cevap ="c#"
//             };
//             var soru3 = new Soru(){
//                 SoruMetni = "Hangisi web programlama platformu değildir?",
//                 Secenekler = new string[4]{"django","Asp.net","spring","pyhton"},
//                 Cevap ="pyhton"
//             };

//             var sorular = new Soru[] {soru1,soru2,soru3};

//             foreach (var soru in sorular){
//                 Console.WriteLine(soru.SoruMetni);
//                 foreach (var secenek in soru.Secenekler){
//                     Console.WriteLine(secenek);
//                 }

//                 //kullanıcıdan cevap alma
//                 Console.Write("cevabınız : ");
//                 var cevap = Console.ReadLine();

//                 if (soru.cevapKontrol(cevap)){
//                     Console.WriteLine("doğru cevap");
//                 }else{
//                     Console.WriteLine("yanlış cevap");
//                 }
//             }
//         }
//     }
//     class Soru{
//         //properties (sınıfın özellikleri)
//         public string  SoruMetni { get; set; }
//         public string[]  Secenekler { get; set; }
//         public string  Cevap { get; set; }


//         //methods (cevap kontrol için)
//         public bool cevapKontrol(string cevap){
//             return this.Cevap.ToLower() == cevap.ToLower();
//         }
//     }
// }



// constructors

// using System;

// namespace ConsoleApp {

//     class Program {

//         static void Main(string[] args) 
//         {
//             var soru1 = new Soru(1, "Hangisi programlama dili değildir?", new string[4] { "Python", "C#", "Java", "Html" }, "Html");
//             var soru2 = new Soru(2, "Hangisi en popüler programlama dilidir?", new string[4] { "Python", "C#", "Java", "Html" }, "C#");
//             var soru3 = new Soru(3, "Hangisi web programlama platformu değildir ?", new string[4] { "Django", "Asp.net", "Spring", "Python" }, "Python");

//         }
//     }

//     class Soru {
//         //constructor
//         public Soru(int soruId, string soruMetni, string[] secenekler, string cevap){
//             this.SoruId = soruId;
//             this.SoruMetni = soruMetni;
//             this.Secenekler = secenekler;
//             this.Cevap = cevap;
//         }
//         public int SoruId { get; set; }
//         public string SoruMetni { get; set; }
//         public string[] Secenekler { get; set; }
//         public string Cevap { get; set; }
        
//         public bool cevapKontrol(string cevap) {
//             return this.Cevap.ToLower() == cevap.ToLower();
//         }
//     }
// }



//access modifiers (erişim belirteçleri)

// using System;

// namespace ConsoleApp {

//     class Program {

//         static void Main(string[] args) 
//         {
//             var soru1 = new Soru(1, "Hangisi programlama dili değildir?", new string[4] { "Python", "C#", "Java", "Html" }, "Html");
//             var soru2 = new Soru(2, "Hangisi en popüler programlama dilidir?", new string[4] { "Python", "C#", "Java", "Html" }, "C#");
//             var soru3 = new Soru(3, "Hangisi web programlama platformu değildir ?", new string[4] { "Django", "Asp.net", "Spring", "Python" }, "Python");

//             Console.WriteLine(soru1.SoruYazdir());
//             Console.WriteLine(soru1.cevapKontrol("html"));

//             Console.WriteLine(soru2.SoruYazdir());
//             Console.WriteLine(soru2.cevapKontrol("c#"));

//             Console.WriteLine(soru3.SoruYazdir());
//             Console.WriteLine(soru3.cevapKontrol("python"));
//         }
//     }
//     class Soru {
//         //constructor
//         public Soru(int soruId, string soruMetni, string[] secenekler, string cevap){
//             this.SoruId = soruId;
//             this.SoruMetni = soruMetni;
//             this.Secenekler = secenekler;
//             this.Cevap = cevap;
//         }
//         private int SoruId { get; set; }
//         private string SoruMetni { get; set; }
//         private string[] Secenekler { get; set; }
//         private string Cevap { get; set; }
        
//         public string SoruYazdir() {
//             string soru = "";
//             soru += this.SoruMetni + "\n";
//             foreach (var secenek in this.Secenekler){
//                 soru += secenek + "\n";
//             }

//             return soru;
//         }
//         public bool cevapKontrol(string cevap) {
//             return this.Cevap.ToLower() == cevap.ToLower();
//         }
//     }
// }



// static methods

// using System;

// namespace ConsoleApp{
    
//     class Program{
//         static void Main(string[] args){
//             //instance metod (nesne oluşturulup erişilir.nesne üzerinden erişilir.)
//             // Random rnd = new Random();
//             // Console.WriteLine(rnd.Next(1,100));

//             //static metod (doğrudan sınıf üzerinden erişilen metottur.)
//             // Math.Min(10,30);
//             var sonuc = HelperMethods.KarakterDuzelt("ölçme ve değerlendirme");
//             Console.WriteLine(sonuc);

//         }
//     }
//     class HelperMethods{
//         public static string KarakterDuzelt(string str){
//             return
//                 str.Replace("ö","o")
//                 .Replace("ü","u")
//                 .Replace("ı","i")
//                 .Replace("ğ","g")
//                 .Replace("ç","c")
//                 .Replace(" ", "-");
//         }
//     }
// }



// collections

// using System;

// namespace ConsoleApp{
//     class Program{
        
//         static void Mani(string[] args){
//             // array (sabit kapasiteye sahiptirler , sadece belirli bir veri tipine bağımlı kalınır (tanımlanan değere))
//             // int [] sayilar = new int[5];
//             // sayilar[0] = 10;

//             // Soru[] sorular = new Soru[5];
//             // sorular[0]=new Soru();

//             //collections (farklı veri tipleri saklanabilir ,dinamik kapasitelidir)

//             //non-generic collections (herhangi bir tipe bağlı kalınmaz)
//             //array list => int,string



//             //generic collections (tip tanımlaması gerekir)
//             //=> int ,string



            
//         }
//     }
// }


//array list

// using System;
// using System.Collections;

// namespace ConsoleApp{
//     class Program{
        
//         static void Main(string[] args){
//                 //arrayList
//                 ArrayList liste = new ArrayList();
//                 liste.Add(10);
//                 liste.Add("10");
//                 liste.Add("ali");
//                 liste.Add(null);
//                 liste.Add(true);

//                 var liste2 = new ArrayList(){
//                     5, "ahmet",false,4.5,null
//                 };

//                 int[] sayilar = {10,20,30};

//                 liste.AddRange(sayilar);

//                 var eleman = (int)liste[0];
//                 var isim = liste[2].ToString();

//                 //insert (listeye veri ekleme)
//                 liste.Insert(1,"sadık");
//                 liste.InsertRange(2,liste2);

//                 //remove (listeden veri silme)
//                 liste.Remove(null);
//                 liste.RemoveAt(2);
//                 liste.RemoveRange(2,3);

//                 //contains - indexof
//                 Console.WriteLine(liste.Contains(100));
//                 Console.WriteLine(liste.IndexOf(10));

                
//                 // foreach (var item in liste){
//                 //     Console.WriteLine(item);
//                 // }
//         }
//     }
// }



//GENERİC LİST

using System;
using System.Collections.Generic;

namespace ConsoleApp{
    
    class Program{
        static void Main(string[] args){
            
            //generic list
            List<int> sayilar = new List<int>();
            sayilar.Add(10);
            sayilar.Add(20);

            List<string> isimler = new List<string>(){"ali","ahmet","ayşe"};

            List<Product> urunler = new List<Product>();

            urunler.Add(new Product(){ID = 1, Title = "iphone 14",Price = 40000});
            urunler.Add(new Product(){ID = 2, Title = "iphone 15",Price = 50000});
            urunler.Add(new Product(){ID = 3, Title = "iphone 16",Price = 60000});

            urunler.Insert(urunler.Count , new Product(){ID = 4, Title = "iphone 17",Price = 70000});
            urunler.Insert(urunler.Count , new Product(){ID = 5, Title = "iphone 18",Price = 80000});

            // urunler.RemoveAt(4);
            // urunler.Remove(urunler[0]);


            foreach (var urun in urunler){
                Console.WriteLine(urun.Title + " " + urun.Price);
            }

        }           

    }
    
    class Product{
        public int ID { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
    }

}





























