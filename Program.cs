using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatianClassDanObject
{
    class Program 
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs = new Mahasiswa();

            Console.Write("Masukkan Nim Anda = ");
            mhs.Nim = Console.ReadLine();
            Console.Write("Masukkan Nama Anda = ");
            mhs.Nama = Console.ReadLine();
            Console.Write("Masukkan IPK Anda = ");
            mhs.Ipk = float.Parse(Console.ReadLine());

            mhs.Registrasi();
            mhs.IsiKrs();

            Console.ReadKey();
        }
    }
}
