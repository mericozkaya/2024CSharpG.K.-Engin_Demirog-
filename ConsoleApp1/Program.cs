using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Degiskenler();

            Vatandas vatandas1=new Vatandas();
            
            Console.ReadLine();
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
        public   string Ad { get; set; }
        public string Soyad {  get; set; }
        public int  DogumYili { get; set; }
        public long TcNo { get; set;}

    }
}
