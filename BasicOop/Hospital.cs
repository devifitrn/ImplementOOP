using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOop
{
    class Hospital
    {
        public string[] dokter = { "1. Dr Anggraeni (umum)", "2. Dr Ferany (anak)" };
        public List<string> jamKedatangan = new List<string>() { "08.00 WIB", "12.00 WIB", "13.30 WIB" };
        public int hargaDokterUmum = 100000;
        public int hargaDokterAnak = 50000;
        public string a;
        public List<int> hargaObatt = new List<int>() { 10000, 20000, 5000 };
        public List<string> namaObat = new List<string>() { "1. Paracetamol", "2. Panadol", "3. Promaag" };

        public void jamPraktik()
        {
            Console.WriteLine("pilih jam praktik yang diinginkan sesuai no urut : (4 untuk lainnya)");
            //for (int i = 0; i < jamKedatangan.Length; i++)
            Console.WriteLine("1. 08.00 WIB");
            Console.WriteLine("2. 12.00 WIB");
            Console.WriteLine("3. 13.30 WIB");

            int x = Convert.ToInt32(Console.ReadLine());

            if (x >= 1 && x < 4)
            {
                Console.WriteLine("permintaan Anda sudah diproses");
            }
            else if (x == 4)
            {
                Console.WriteLine("tuliskan jam kedatangan yang Anda inginkan");
                string add = Console.ReadLine();
                jamKedatangan.Add(add);
                Console.WriteLine($"jam kedatangan Anda  {add} WIB");
                Console.WriteLine("permintaan Anda sudah diproses");
            }
            else
                Console.WriteLine("Permintaan anda tidak ditemukan");

        }
        public void obat()
        {
            Console.WriteLine("untuk pembelian obat silahkan pilih sesuai kebutuhan");
            Console.WriteLine("1. Tanpa resep");
            Console.WriteLine("2. Dengan resep");
            string choice = Console.ReadLine();
            Price pr = new Price();
            if (choice == "1")
            {
                pr.hargaObat();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Silahkan datang ke apotek untuk memastikan ketersediaan obat");
            }
            
        }

        
    }

    }

