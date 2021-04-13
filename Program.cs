using System;

namespace ResponsiPemrograman3376
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan kar1 = new Karyawan(201122333, "Paijo", 3500000);
            Karyawan kar2 = new Karyawan(201122333, "Jono", 2500000);

            Karyawan.Show(kar1, kar2);
            Karyawan.NaikGaji(kar1, kar2);
            Karyawan.Show(kar1, kar2);
        }
    }
}
