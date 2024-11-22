using System;

class Ogrenci
{
    private int ogrenciNo;
    private string isim;

    public Ogrenci(int ogrenciNo, string isim)
    {
        this.SetOgrenciNo(ogrenciNo);
        this.SetIsim(isim);
    }

    public int GetOgrenciNo()
    {
        return ogrenciNo;
    }

    public void SetOgrenciNo(int ogrenciNo)
    {
        this.ogrenciNo = ogrenciNo;
    }

    public string GetIsim()
    {
        return isim;
    }

    public void SetIsim(string isim)
    {
        this.isim = isim;
    }

    public static bool Ekle(Ogrenci[] ogrenciler, Ogrenci ogrenci)
    {
        // TODO: Öğrenciyi dizideki ilk boş yere ekle
        // Eğer dizi null veya doluysa false döndür
        return false;
    }

    public static Ogrenci[] EkleVeYeniDiziOlustur(ref Ogrenci[] ogrenciler, Ogrenci ogrenci)
    {
        // TODO: Eğer dizi null veya uzunluğu 0'sa yeni bir dizi oluştur ve öğrenci ekle
        return ogrenciler;
    }

    public static void Sifrele(Ogrenci[] ogrenciler, int ogrenciNo)
    {
        // TODO: Verilen öğrenci numarasına sahip öğrencinin ismini "XXX" yap
    }

    public static Ogrenci Sifrele2(Ogrenci[] ogrenciler, int ogrenciNo)
    {
        // TODO: Verilen öğrenci numarasına sahip öğrencinin anonimleştirilmiş bir kopyasını döndür
        return null;
    }

    public static void Yazdir(Ogrenci[] ogrenciler)
    {
        if (ogrenciler != null)
        {
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                if (ogrenciler[i] != null)
                {
                    Console.WriteLine(ogrenciler[i].ToString());
                }
            }
        }
    }

    public override string ToString()
    {
        return "Öğrenci No: " + this.GetOgrenciNo() + ", İsmi: " + this.GetIsim();
    }

    public static void Main(string[] args)
    {
        Ogrenci[] ogrenciler = new Ogrenci[4];
        Console.WriteLine(">>>> İlk Çıktı");
        Ekle(ogrenciler, new Ogrenci(1, "Ahmet Yılmaz"));
        Ekle(ogrenciler, new Ogrenci(2, "Fatma Demir"));
        Yazdir(ogrenciler);

        Console.WriteLine("\n>>>> İkinci Çıktı");
        Ekle(null, new Ogrenci(3, "Ali Veli"));
        Ekle(ogrenciler, new Ogrenci(4, "Zeynep Şen"));
        Yazdir(ogrenciler);

        Console.WriteLine("\n>>>> Üçüncü Çıktı");
        Ogrenci ogrenciKopya = Sifrele2(ogrenciler, 4);
        Sifrele(ogrenciler, 1);
        Yazdir(ogrenciler);

        Console.WriteLine("\n>>>> Dördüncü Çıktı");
        Console.WriteLine(ogrenciKopya.ToString());
    }
}
