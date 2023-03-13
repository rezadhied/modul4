// See https://aka.ms/new-console-template for more information

class main
{
    static void Main(string[] args)
    {

        Console.WriteLine("==========Memanggil Kode Buah==========");
        KodeBuah.Buah b = KodeBuah.Buah.Apel;
        Console.WriteLine("Kode buah "+b+" adalah "+KodeBuah.getKodeBuah(b));
        KodeBuah.Buah b2 = KodeBuah.Buah.Aprikot;
        Console.WriteLine("Kode buah " + b2 + " adalah " + KodeBuah.getKodeBuah(b2));
        KodeBuah.Buah b3 = KodeBuah.Buah.Alpukat;
        Console.WriteLine("Kode buah " + b3 + " adalah " + KodeBuah.getKodeBuah(b3));
        KodeBuah.Buah b4 = KodeBuah.Buah.Pisang;
        Console.WriteLine("Kode buah " + b4 + " adalah " + KodeBuah.getKodeBuah(b4));
        KodeBuah.Buah b5 = KodeBuah.Buah.Paprika;
        Console.WriteLine("Kode buah " + b5 + " adalah " + KodeBuah.getKodeBuah(b5));
        KodeBuah.Buah b6 = KodeBuah.Buah.Blackberry;
        Console.WriteLine("Kode buah " + b6 + " adalah " + KodeBuah.getKodeBuah(b6));
        KodeBuah.Buah b7 = KodeBuah.Buah.Ceri;
        Console.WriteLine("Kode buah " + b7 + " adalah " + KodeBuah.getKodeBuah(b7));
        KodeBuah.Buah b8 = KodeBuah.Buah.Kelapa;
        Console.WriteLine("Kode buah " + b8 + " adalah " + KodeBuah.getKodeBuah(b8));
        KodeBuah.Buah b9 = KodeBuah.Buah.Jagung;
        Console.WriteLine("Kode buah " + b9 + " adalah " + KodeBuah.getKodeBuah(b9));
        KodeBuah.Buah b10 = KodeBuah.Buah.Kurma;
        Console.WriteLine("Kode buah " + b10 + " adalah " + KodeBuah.getKodeBuah(b10));
        KodeBuah.Buah b11 = KodeBuah.Buah.Durian;
        Console.WriteLine("Kode buah " + b11 + " adalah " + KodeBuah.getKodeBuah(b11));
        KodeBuah.Buah b12 = KodeBuah.Buah.Anggur;
        Console.WriteLine("Kode buah " + b12 + " adalah " + KodeBuah.getKodeBuah(b12));
        KodeBuah.Buah b13 = KodeBuah.Buah.Melon;
        Console.WriteLine("Kode buah " + b13 + " adalah " + KodeBuah.getKodeBuah(b13));
        KodeBuah.Buah b14 = KodeBuah.Buah.Semangka;
        Console.WriteLine("Kode buah " + b14 + " adalah " + KodeBuah.getKodeBuah(b14));

        Console.WriteLine("\n==========Posisi Karakter Game==========");
        Console.WriteLine("==========NIM % 3 == 1==========");

        PosisiKarakterGame P = new PosisiKarakterGame();
        Console.WriteLine("Posisi awal Berdiri\nBerakhir di posisi Tengkurap\n\n" +
            "bangun->turun->bangun->bangun->\nturun->turun->turun");
        P.Bangun();
        P.Turun();
        P.Bangun();
        P.Bangun();
        P.Turun();
        P.Turun();
        P.Turun();
    }
    
}

public class KodeBuah
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

public class PosisiKarakterGame
{
    public enum State { Berdiri, Terbang, Jongkok, Tengkurap};
    private State state = State.Berdiri;

    public void Bangun()
    {
        switch (state)
        {
            case State.Terbang:
                state = State.Terbang;
                Console.WriteLine("Posisi melayang");
                break;
            case State.Jongkok:
                state = State.Berdiri;
                Console.WriteLine("Posisi standby");
                break;
            case State.Tengkurap:
                state = State.Jongkok;
                Console.WriteLine("Posisi jongkok");
                break;
            case State.Berdiri:
                state = State.Terbang;
                Console.WriteLine("Posisi melayang");
                break;
        }
    }

    public void Turun()
    {
        switch (state)
        {
            case State.Berdiri:
                state = State.Jongkok;
                Console.WriteLine("Posisi jongkok");
                break;
            case State.Terbang:
                state = State.Berdiri;
                Console.WriteLine("Posisi standby");
                break;
            case State.Tengkurap:
                state = State.Tengkurap;
                Console.WriteLine("Posisi istirahat");
                break;
            case State.Jongkok:
                state = State.Tengkurap;
                Console.WriteLine("Posisi istirahat");
                break;
        }
    }
}