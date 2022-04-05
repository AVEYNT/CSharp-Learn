using System;

class Program
{
    static void Main(string[] args)
    {
        int harga = 150000;
        double diskon = 12.5D, ddiskon, hargab;
        
		ddiskon = harga*diskon/100;
        Console.WriteLine("\n=============================\nHarga Kaos Rp150.000 \nDiskon Akhir Tahun 12.5%\nDiskon Yang Diperoleh : Rp  "+ ddiskon);
		hargab = harga-ddiskon;
		Console.WriteLine("=============================\nHarga Bersih : Rp"+ hargab);
    }
}