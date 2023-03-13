// See https://aka.ms/new-console-template for more information

class main
{
    static void Main(string[] args)
    {
        KodeBuah.Buah b = KodeBuah.Buah.Apel;
        Console.WriteLine("Kode buah "+b+" adalah "+KodeBuah.getKodeBuah(b));
        KodeBuah.Buah b2 = KodeBuah.Buah.Pisang;
        Console.WriteLine("Kode buah " + b2 + " adalah " + KodeBuah.getKodeBuah(b2));
        KodeBuah.Buah b3 = KodeBuah.Buah.Melon;
        Console.WriteLine("Kode buah " + b3 + " adalah " + KodeBuah.getKodeBuah(b3));
    }
    
}

class KodeBuah
{
    public enum Buah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, 
        Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka}

    public static string getKodeBuah(Buah B)
    {
        string[] kode = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", 
            "I00", "J00", "K00", "L00", "M00", "N00", "O00"};

        return kode[(int)B];
    }
}