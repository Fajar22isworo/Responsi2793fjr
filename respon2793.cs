using System;
namespace fajariswororespon27932 
{
    class Program 
    {
        static void Main(string[] args)
        { Console.WriteLine("Nama : fajar"); 
            Console.WriteLine("NIM :19.11.2793");
            

            Console.WriteLine("\n"); 

            Karyawan karyawanA = new Karyawan(2204, "romi", 2350000);
            Karyawan karyawanB = new Karyawan(2001, "harisjon", 2100000); 
            

            Console.WriteLine("*********************************");
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |"); 
            Console.WriteLine("*********************************"); 
            Console.WriteLine(" A. |{0}{1}\t |{2}\t |",NIK.karyawan, Nama.karyawan, karyawan.GajiBulanan);
            Console.WriteLine(" B. |{0}{1}\t |{2}\t |",NIK.karyawan, Nama.karyawan, karyawan.GajiBulanan);
        

            Console.WriteLine("\nAlhamdulillah\n"); 

            Console.WriteLine("*********************************");
            Console.WriteLine(" NO | NIK/NAMA\t | Gaji Bulanan\t |");
            Console.WriteLine("*********************************");
            Console.WriteLine(" A. |{0}{1}\t |{2}\t |", NIK.karyawan, Nama.karyawan, karyawan.Gajitambahan);
            Console.WriteLine(" B. |{0}{1}\t |{2}\t |", NIK.karyawan, Nama.karyawan, karyawan.Gajihtambahan);

            Console.ReadKey();
        }
    
   }
}
