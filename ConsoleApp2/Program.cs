using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            SelamVer(isim:"Engin");
            SelamVer(isim:"Ahmet");
            SelamVer(isim:"Ayşe");
            SelamVer();

            int sonuc = Topla(6,58);

            //Diziler /Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3]; //tanımladığımız tipte array
            ogrenciler[0] = "Engin";             //new string[3] demeseydik hata alırdık çünkü referans tipleri kullanabilmek için bellekte(heapte) yer açmamız gerekiyor 
            ogrenciler[1] = "Kerem";                                                          //Array,Class,Abstract referans tiplerdir                          
            ogrenciler[2] = "Berkay";
            //ogrenciler[3] = "İlker"; //bu işlemden dolayı array sınırları aşıldı hatası verir

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker"; //bu yapıdan kaynaklı sadece ilker yazar
                                     //bu yapı yeni bir alan tanımladı ve ilkeri yerleştirdi yeni bir alan açıldığı için öğrenciler yeni yeri tutmaya başladı
                                     // garbage collecter heapte önce ki alanı tutan bir şey olmadığı için bellekten atacak
            for(int i = 0; i < ogrenciler.Length; i++)
                //sayac       şart                 sayacın artış değeri
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler1 = sehirler2; //Bu değer atama değil!! Biz burada sehirler1'in referansı sehirler2'nin referansıdır dedik
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            /*
            int sayi1 = 10;  //int,double,float,bool veri tipleri değer tiplerdir olay tamamen stackte gerçekleşir
            int sayi2 = 20;
            sayi2 = sayi1; //sayi2=10
            sayi1 = 30;
            //sayi2=?? ----> sayi2=10
            */
            
            
            Person person1 = new Person();
            person1.FirstName = "Engin";
            person1.LastName = "DEMİROĞ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 123;  //Kendi doğru bilgilerimi yazıp maskemi aldım :)
                                             //ikisi de person olmasına rağmen bellekte farklı yerler açtık ve kullanıcaz 
            Person person2 = new Person();
            person2.FirstName = "Murat";
            
            //stringlerde aslında bir referans tiptir ama insanlar bir değer tip gibi kullandığı için öyle çalışır temelinde bir char arraydir

            foreach(string sehir in sehirler1)
            {
                //foreach ile dizi formatında ki yapıları dönüyoruz
                //in sehirler1 'i dolaş burada ki şehir her bir elemanı dönerken kullandığımız isim
                Console.WriteLine(sehir);
            }

            //yukarıda tanımladığımız array formatı artık çok az kullanılıyor aşağıda ki formatta kullanacağız
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1"); //Artık 4 elemanlı bir dizi
            foreach(var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }
            //bunlara jenerik koleksiyon deniyor referans probleminden kurtarıyor
            //bu add eski verileri cebe atıyor newleyince yeniliyor cebe atılanları yerine koyup yeni elemanı sona ekliyor

            foreach(var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);






            Console.ReadLine();
        }

        static void SelamVer(string isim="isimsiz") //void metotlar sadece işi yapar herhangi bir şey kaydetmez
        {                                           //buna default parametre denir biz söylemedikçe merhaba isimsiz yazdıracak
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1=5, int sayi2=10) //topla fonskiyonunu parametresiz kullanırsak burada ki sayıları kabul eder
        {                                 //metot=fonksiyon
            int sonuc= sayi1 + sayi2; //bu bir lokal değişkendir ve sadece tanımlandığı blokta geçerlidir başka yerden erişemezsin o yüzden başka blokların içine istersek tekrar lokal sonuc değişkenini tanımlayabiliriz
                                      //class static olduğu için sonuc fonksiyonunu bloklar dışında bir yere tanımlayabildik ama aslında tanımlayamayız 
            Console.WriteLine("Toplam:"+ sonuc);
            return sonuc; //return atanan değişkene verilecek değerdir
        }

        private static void Degiskenler()
        {
            string mesaj = "Selam";
            double tutar = 100000; //db den gelir
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Engin";
            string soyad = "Demiroğ";
            int dogumYili = 1985;
            long tcNo = 12345678910; //int sınırından kaynaklı long kullanıyoruz

            Console.WriteLine(mesaj);

            Console.WriteLine(tutar * 1.18);
        }
    }

    //pascal casing = public olan propertylerin baş harfi büyük
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

    }
}
