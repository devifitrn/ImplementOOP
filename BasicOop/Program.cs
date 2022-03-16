using System;
using System.Collections.Generic;

namespace BasicOop
{
    class Program : Hospital
    {
        static void Main(string[] args)
        {
            string pilihan;
            do
            {
                Welcome who = new Welcome();
                who.welcome();
                Hospital hosp = new Hospital();
                Price price = new Price();

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Pilih dokter yang diinginkan : ");
                        foreach (string i in hosp.dokter)
                        {
                            Console.WriteLine(i);
                        }

                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1:
                                hosp.jamPraktik();
                                price.bpjs(hosp.hargaDokterUmum);
                                break;
                            case 2:
                                hosp.jamPraktik();
                                price.bpjs(hosp.hargaDokterAnak);
                                break;
                        }
                        break;

                    case 2:
                        hosp.obat();
                        break;
                    default:
                        Console.WriteLine("permintaan Anda tidak dapat diproses");
                        break;

                }
                Console.WriteLine("Ulangi Proses? 1. ya & 2. tidak ");
                pilihan = Console.ReadLine();

            } while (pilihan == "1");

            Console.WriteLine("selesai");
        }
    }
}

