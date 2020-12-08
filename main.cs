using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Önerme sayısını giriniz:"); //önerme sayısını aldırdık örnek r,p gibi.
    double onerme;
    onerme = Convert.ToDouble(Console.ReadLine()); // math kullanimi için double çevirdik
    double top;
    top= Math.Pow(2,onerme); // math sınıfı kullanarak üssü aldırdık.
    
    Console.WriteLine("Toplam önerme : "+top); // ekrana yazdırdık.
  }
}