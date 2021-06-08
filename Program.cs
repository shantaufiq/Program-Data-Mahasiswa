using System;

namespace Project_Assessment_3
{
    class Program
    {
        struct Mahasiswa
		{
			public string Absen;
			public string Nama;
			public string NIM;
		}
        static void Main(string[] args)
        {
            

Mahasiswa[] a2 = new Mahasiswa[3];
			
			
			string pilih;
			int masukan;
			menu :
			Console.Clear();
            Console.WriteLine("      ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("      |               	PROGRAM DAFTAR ABSEN MAHASISWA                       |");
            Console.WriteLine("      |                    	KELAS D4SM-44-03                             |");
            Console.WriteLine("      |           KELOMPOK :	1. MUHAMMAD TAUFIQ SHIDIQ                    |");
            Console.WriteLine("      |              		2. muhammad Ainur Rafiq                      |");
            Console.WriteLine("      |              		3. Muhammad Gilang Radhitya Permana          |");
            Console.WriteLine("      |              			                                     |");
            Console.WriteLine("      |              Ketikan Angk Untuk Memilih Salah 1 Menu                 |");
            Console.WriteLine("      |_____________________________________________________________________ |");
            Console.WriteLine("      | 1. Menambahkan Data Mahasiswa (max 30 anak)   	                     |");
            Console.WriteLine("      | 2. Menampilkan Data Mahasiswa      				     |");
            Console.WriteLine("      | 3. Mengupdate Data Mahasiswa      				     |");
            Console.WriteLine("      | 4. Mendelete Data Mahasiswa     			             |");
            Console.WriteLine("      |>>>>>>>>>>>>>>>>>>>>>>>>>>>  0.Keluar  <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<|");
			
            
    Console.Write("\nInsert Number Of Menu : ");
    pilih = Console.ReadLine();
    masukan = Convert.ToInt16(pilih);
    switch(masukan)
    {
        case 1:
            
            Console.WriteLine("Tuliskan Absen ke ");//Menampilkan isian user
            a2[1].Absen = (Console.ReadLine()); //Inisialisasi data dari user ke dalam array dengan indeks tertentu
            Console.WriteLine("Tuliskan Nama Mahasiswa ");//Menampilkan isian user
            a2[1].Nama = (Console.ReadLine()); //Inisialisasi data dari user ke dalam array dengan indeks tertentu
            Console.WriteLine("Tuliskan NIM ");
            a2[1].NIM = (Console.ReadLine()); //Inisialisasi data dari user ke dalam array dengan indeks tertentu
            
            goto menu;

        case 2:
            Console.WriteLine(" Nomor absen mahasiswa ke " +a2[1].Absen);
            Console.WriteLine(" Nomor absen mahasiswa ke " +a2[1].Nama);
            Console.WriteLine(" Nomor absen mahasiswa ke " +a2[1].NIM);
            Console.WriteLine("\n    Succesfully Saved ! \nPress Any Key To Select Other Menu");
            Console.ReadKey();
            goto menu;

        case 0:
        break;
    } 

        }
    }
}
