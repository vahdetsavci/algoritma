using System;
using System.Text.RegularExpressions;

namespace algoritma;

class Kontrol
{
    internal static void Degistir(string metin)
    {
        Console.WriteLine(Regex.Replace(metin, "[0-9]", ""));
    }
}