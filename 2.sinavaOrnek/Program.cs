using _2.sinavaOrnek;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.sinavaOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Bilgisayar bilgisayar = new Bilgisayar();
            bilgisayar.marka = "Lenovo";
            bilgisayar.model = "Desktop";
            bilgisayar.fiyat = 1500;
            double kdvliFiyat = bilgisayar.KDVliFiyat(bilgisayar.fiyat);
            Console.WriteLine("KDV li fiyat:" + kdvliFiyat);
            Console.WriteLine("=====================================");
            Laptop laptop = new Laptop();
            laptop.HEKarti = true;
            laptop.BataryaSuresi = 30;
            laptop.fiyat = 2000;
            double laptopkdvlifiyat = laptop.KDVliFiyat(laptop.fiyat);
            Console.WriteLine("Laptop KDV li Fiyat:" + laptopkdvlifiyat);
            Console.WriteLine("=====================================");
        }
    }
    public class Bilgisayar
    {
        public string marka;
        public string model;
        public uint fiyat;
        public uint RAM { get; set; }
        public bool HEKarti { get; set; }
        public ulong SSD { get; set; }
        public virtual double KDVliFiyat(double asilFiyat)
        {
            return asilFiyat + asilFiyat * 18 / 100;
        }
    }
    public class Laptop : Bilgisayar
    {
        public uint Agirlik { get; set; }
        public uint BataryaSuresi { get;  set; }
        public override double KDVliFiyat (double asilFiyat)
        {
            return asilFiyat + asilFiyat * 18 / 100;
        }
    }
}