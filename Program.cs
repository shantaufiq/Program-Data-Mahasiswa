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
            Console.WriteLine("      | 3. Mencari Data Mahasiswa      				             |");
            Console.WriteLine("      | 4. Mendelete Data Mahasiswa     			             |");
            Console.WriteLine("      |>>>>>>>>>>>>>>>>>>>>>>>>>>>  0.Keluar  <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<|");
			
            
    Console.Write("\nInsert Number Of Menu : ");
    pilih = Console.ReadLine();
    masukan = Convert.ToInt16(pilih);
    switch(masukan)
    {
        case 1:
            int u;

            Console.WriteLine("jumlah anggota yang akan diinput");
            u = int.Parse(Console.ReadLine());

            for(int i=0; i <= u-1; i++){
                
            Console.WriteLine("Tuliskan Absen ke ");//Menampilkan isian user
            a2[i].Absen =  (Console.ReadLine()); //Inisialisasi data dari user ke dalam array dengan indeks tertentu
            Console.WriteLine("Tuliskan Nama Mahasiswa ");//Menampilkan isian user
            a2[i].Nama = (Console.ReadLine()); //Inisialisasi data dari user ke dalam array dengan indeks tertentu
            Console.WriteLine("Tuliskan NIM ");
            a2[i].NIM = (Console.ReadLine()); //Inisialisasi data dari user ke dalam array dengan indeks tertentu
            }

            
            
            goto menu;

        case 2:

            for(int i=0; i <= a2.Length; i++){
            Console.WriteLine(" Nomor absen mahasiswa ke " +a2[i].Absen);
            Console.WriteLine(" Nomor absen mahasiswa ke " +a2[i].Nama);
            Console.WriteLine(" Nomor absen mahasiswa ke " +a2[i].NIM);
            }
            Console.WriteLine("\n    Succesfully Saved ! \nPress Any Key To Select Other Menu");
            Console.ReadKey();
            goto menu;

        case 0:
        break;
    } 

        }
    }
}
