using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi 
{
    internal class OBS : Form
    {
        static List<Ogrenci> ogrenciListesi = new List<Ogrenci>();
        static List<int> notlist = new List<int>();


        static void Main(string[] args)
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçin");
            Menu();
        }
        public static void Menu()
        {
            int girdi;
            bool isValid = int.TryParse(Console.ReadLine(), out girdi);

            switch (girdi)
            {
                case 1:
                    Console.WriteLine("Öğrenci Adı: ");
                    string isim = Console.ReadLine();
                    Console.WriteLine("Öğrenci Soyadı: ");
                    string soyisim = Console.ReadLine();
                    Console.WriteLine("Öğrenci Numarası: ");
                    int no = Convert.ToInt32(Console.ReadLine());
                    Ogrenci ogrenci = new Ogrenci(isim, soyisim, no);
                    ogrenciListesi.Add(ogrenci);
                    Console.WriteLine($"Öğrenci Eklendi: {ogrenci.isim} {ogrenci.soyisim}, No: {ogrenci.ID}");
                    Menu();
                    break;
                case 2:
                    int count = 0;
                    Console.WriteLine("Öğrenci Listesi:");
                    foreach (var o in ogrenciListesi)
                    {
                        count++;
                        Console.WriteLine($"{count}. {o.Ad},{o.Soyad},{o.No}");
                        Console.WriteLine();
                    }
                    Menu();
                    break;
                case 3:
                    Console.WriteLine("Not eklemek istediğiniz öğrencinin numarasını girin:");
                    int ogrenciNo = Convert.ToInt32(Console.ReadLine());
                    Ogrenci secilenOgrenci = null;
                    foreach (var o in ogrenciListesi)
                    {
                        if (o.No == ogrenciNo)
                        {
                            secilenOgrenci = o;
                            break;
                        }
                    }
                    Console.WriteLine(
                        secilenOgrenci != null
                            ? $"Öğrenci bulundu: {secilenOgrenci.Ad} {secilenOgrenci.Soyad}, No: {secilenOgrenci.No}"
                            : "Öğrenci bulunamadı.");
                    if (secilenOgrenci != null)
                    {
                        Console.WriteLine("Eklemek istediğiniz notu girin:");
                        int notDegeri;
                        bool notValid = int.TryParse(Console.ReadLine(), out notDegeri);
                        if (!notValid)
                        {
                            Console.WriteLine("Geçersiz not girişi, lütfen bir sayı girin.");
                        }
                        else
                        {
                            secilenOgrenci.NotEkle(notDegeri);
                            Console.WriteLine($"Not eklendi: {notDegeri}");
                        }
                    }
                    Menu();
                    break;
                case 4:
                    Console.WriteLine("Notları görüntülemek istediğiniz öğrencinin numarasını girin:");
                    int notOgrenciNo = Convert.ToInt32(Console.ReadLine());
                    Ogrenci notOgrenci = null;
                    foreach (var o in ogrenciListesi)
                    {
                        if (o.No == notOgrenciNo)
                        {
                            notOgrenci = o;
                            break;
                        }
                    }
                    foreach (var o in ogrenciListesi)
                    {
                        Console.WriteLine($"Öğrenci: {o.Ad} {o.Soyad}, No: {o.No}");
                        if (o.notlist.Count > 0)
                        {
                            Console.WriteLine("Notlar: " + string.Join(", ", o.notlist));
                        }
                        else
                        {
                            Console.WriteLine("Not bulunamadı.");
                        }
                        Console.WriteLine();
                    }
                    Menu();
                    break;
                case 5:
                    Console.WriteLine("Aramak istediğiniz öğrencinin numarasını girin:");
                    int aramaOgrenciNo = Convert.ToInt32(Console.ReadLine());
                    Ogrenci aramaOgrenci = null;
                    foreach (var o in ogrenciListesi)
                    {
                        if (o.No == aramaOgrenciNo)
                        {
                            aramaOgrenci = o;
                            break;
                        }
                    }
                    if (aramaOgrenci != null)
                    {
                        Console.WriteLine($"Öğrenci bulundu: {aramaOgrenci.Ad} {aramaOgrenci.Soyad}, No: {aramaOgrenci.No}");
                    }
                    else
                    {
                        Console.WriteLine("Öğrenci bulunamadı.");
                    }
                    Menu();
                    break;
                case 6:
                    Console.WriteLine("Silmek istediğiniz öğrencinin numarasını girin:");
                    int silOgrenciNo = Convert.ToInt32(Console.ReadLine());
                    Ogrenci silOgrenci = null;
                    foreach (var o in ogrenciListesi)
                    {
                        if (o.No == silOgrenciNo)
                        {
                            silOgrenci = o;
                            break;
                        }
                    }
                    if (silOgrenci != null)
                    {
                        ogrenciListesi.Remove(silOgrenci);
                        Console.WriteLine($"Öğrenci silindi: {silOgrenci.Ad} {silOgrenci.Soyad}, No: {silOgrenci.No}");
                    }
                    else
                    {
                        Console.WriteLine("Öğrenci bulunamadı.");
                    }
                    Menu();
                    break;
                case 7:
                    Console.WriteLine("Ortalama hesaplamak istediğiniz öğrencinin numarasını girin:");
                    int ortOgrenciNo = Convert.ToInt32(Console.ReadLine());
                    Ogrenci ortOgrenci = null;
                    foreach (var o in ogrenciListesi)
                    {
                        if (o.No == ortOgrenciNo)
                        {
                            ortOgrenci = o;
                            break;
                        }
                    }
                    if (ortOgrenci != null)
                    {
                        double ortalama = ortOgrenci.OrtalamaHesapla();
                        Console.WriteLine($"Öğrencinin ortalaması: {ortalama}");
                    }
                    else
                    {
                        Console.WriteLine("Öğrenci bulunamadı.");
                    }
                    Menu();
                    break;
                case 0:
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                    Environment.Exit(0);

            }
        }
    }
}

    }
}
