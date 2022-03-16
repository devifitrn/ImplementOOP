using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOop
{
    class Price : Hospital
    {
    
        int total;

        public void bpjs(int value)
        {
            //Hospital hsp = new Hospital();
            Console.WriteLine("apakah memiliki bpjs? (y/n) ");
            a = Console.ReadLine();
            if (a == "y")
            {
                Console.WriteLine("Terima Kasih permintaan Anda telah diproses, Berikut rinciannya: ");
                total = value * 20 / 100;
                Console.WriteLine();
            
                Console.WriteLine($"total harga = Rp  {total}");

            }
            else if (a == "n")
            {
                Console.WriteLine("Terima Kasih permintaan Anda telah diproses, Berikut rinciannya: ");
                Console.WriteLine($"Total harga = Rp  {hargaDokterUmum}");
            }
        }
        public void hargaObat()
        {
            Console.WriteLine("Silahkan pilih (tuliskan angka)");
            foreach (string obat in namaObat)
            {
                Console.WriteLine(obat);
            }
            string c = Console.ReadLine();

            if (c == "1")
            {
                obatHarga(hargaObatt[0]);

            }
            else if (c == "2")
            {
                obatHarga(hargaObatt[1]);
            }
            else if (c == "3")
            {
                obatHarga(hargaObatt[2]);
            }

        
        }
        public void obatHarga(int harga)
        {
            Console.WriteLine("tuliskan berapa jumlah nya: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("total belanja obat Anda = ");
            Console.WriteLine($"{harga} x {quantity} = {harga * (quantity)}");
        }
       
    }
}
