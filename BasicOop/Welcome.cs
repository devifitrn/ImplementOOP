using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOop
{
    class Welcome
    {
        private string name;

        public void welcome()
        {
            Console.WriteLine("RS. Permata Indonesia");
            Console.WriteLine("Selamat Datang di Aplikasi RS. Permata Indonesia");
            Console.WriteLine("Ketikan nama Anda dibawah ini: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Halo {name} ! Silahkan pilih menu dibawah ini. Cukup tuliskan nomernya saja.");
            Console.WriteLine("1. Pemeriksaan Kesehatan");
            Console.WriteLine("2. Pembelian Obat");

            
        }
    }
}
