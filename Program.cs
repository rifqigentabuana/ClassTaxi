using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek dari class Taxi
            Taxi Driver1 = new Taxi();
            Taxi Driver2 = new Taxi();

            // setting nilai properties objek aing dan koe
            Driver1.Nama = "SUPRIADI";
            Driver1.Status = "AVAILABLE";
            Driver1.Jml_Penumpang = 42;
            Driver1.Jml_Penumpang1 = 0;

            Driver2.Nama = "BAMBANG";
            Driver2.Status2 = "NOT AVAILABLE";
            Driver2.Jml_Penumpang = 54;
            Driver2.Jml_Penumpang1 = 0;

            // memanggil method registrasi dan isi krs
            Driver1.Info_Driver();
            Driver1.Status_Driver();

            Driver2.Info_Driver2();
            Driver2.Status_Driver2();

            Console.ReadKey();
        }
    }
}
