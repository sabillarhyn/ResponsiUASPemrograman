using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih menu Aplikasi");
            Console.WriteLine("\n1. Tambah Customer");
            Console.WriteLine("2. Hapus Customer");
            Console.WriteLine("3. Tampilkan Customer");
            Console.WriteLine("4. Keluar");
        }

        static void TambahCustomer()
        {
            Console.Clear();

            Customer customer = new Customer();
            Console.WriteLine("Tambah Data Customer");
            Console.Write("\nKode Customer : ");
            customer.KodeCustomer = Console.ReadLine();
            Console.Write("Nama Customer : ");
            customer.NamaCustomer = Console.ReadLine();
            Console.Write("Total Piutang : ");
            customer.Piutang = Convert.ToDouble(Console.ReadLine());
            daftarCustomer.Add(customer);


            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            int no = -1, hapus = -1;
            Console.WriteLine("Hapus Data Customer");
            Console.Write("Kode Customer : ");
            string kode = Console.ReadLine();
            foreach (Customer customer in daftarCustomer)
            {
                no++;
                if (customer.KodeCustomer == kode)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                daftarCustomer.RemoveAt(hapus);
                Console.WriteLine("\nData customer berhasil di hapus");
            }
            else
            {
                Console.WriteLine("\nKode customer tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();
            Console.Clear();
            Console.WriteLine("Data Customer\n");
            int noUrut = 0;

            foreach (Customer customer in daftarCustomer)
            {
                noUrut++;
                Console.WriteLine("{0}. Kode Customer : {1} | Nama Customer : {2} | Total Piutang : {3:N0}", noUrut, customer.KodeCustomer, customer.NamaCustomer, customer.Piutang);
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
