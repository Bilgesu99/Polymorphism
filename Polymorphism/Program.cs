using System;

class Program
{
    static void Main(string[] args)
    {
        Kare kare = new Kare(5);
        Dikdortgen dikdortgen = new Dikdortgen(4, 6);
        DikUcgen dikUcgen = new DikUcgen(3, 4);

        Console.WriteLine("Karenin Alanı: " + kare.AlanHesapla());
        Console.WriteLine("Dikdörtgenin Alanı: " + dikdortgen.AlanHesapla());
        Console.WriteLine("Dik Üçgenin Alanı: " + dikUcgen.AlanHesapla());
    }
}

abstract class BaseGeometrikSekil
{
    public double Genislik { get; set; }
    public double Yukseklik { get; set; }

    public BaseGeometrikSekil(double genislik, double yukseklik)
    {
        Genislik = genislik;
        Yukseklik = yukseklik;
    }

    public abstract double AlanHesapla();
}

class Kare : BaseGeometrikSekil
{
    public Kare(double kenar) : base(kenar, kenar) { }

    public override double AlanHesapla()
    {
        return Genislik * Yukseklik;
    }
}

class Dikdortgen : BaseGeometrikSekil
{
    public Dikdortgen(double genislik, double yukseklik) : base(genislik, yukseklik) { }

    public override double AlanHesapla()
    {
        return Genislik * Yukseklik;
    }
}

class DikUcgen : BaseGeometrikSekil
{
    public DikUcgen(double taban, double yukseklik) : base(taban, yukseklik) { }

    public override double AlanHesapla()
    {
        return (Genislik * Yukseklik) / 2;
    }
}
