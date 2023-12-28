using System;

namespace algoritma;

class Program
{
    static void Main(string[] args)
    {
        Basla:
        Console.WriteLine();
        Console.WriteLine("***************************************************************");
        Console.WriteLine("Bir metin giriniz! \n Not: Girdiğiniz metin içerisindeki sayılar silinecektir");
        Console.WriteLine("---------------------------------------------------------------");
        Kontrol.Degistir(Console.ReadLine());
        // Kontrol.Degistir("Input: Algoritma,3 Algoritma,5 Algoritma,22 Algoritma,0");

        Console.WriteLine("Devam etmek için [Enter] tuşuna basın!"); 
        Console.ReadLine();
        goto Basla;
    }
}
