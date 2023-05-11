
namespace PolymorphismApplication
{
    abstract class bangun
    {
        public abstract int luas();
    }

    class kotak : bangun
    {
        private int panjang;
        private int lebar;

        public kotak(int a, int b)
        {
            panjang = a;
            lebar = b;
        }
        public override int luas()
        {
            return (panjang * lebar);
        }
    }

    class segitiga : bangun
    {
        private int panjang;
        private int tinggi;

        public segitiga(int a, int b)
        {
            panjang = a;
            tinggi = b;
        }
        public override int luas()
        {
            return (2 * panjang * tinggi);
        }
    }
    class program
    {
        static void Main()
        {
            Console.WriteLine("======== Selamat Datang Di Program perhitungan luas ========");
            Console.WriteLine("1. Hitung Luas Persegi");
            Console.WriteLine("2. Hitung Luas segitiga");
            Console.WriteLine("3. Keluar Program");

            Console.WriteLine("masukkan pilihan anda : ");  
            int pilihan = int.Parse(Console.ReadLine());

            while(pilihan != 3) {
                 if (pilihan == 1)
            {
                Console.WriteLine("masukkan tinggi kotak : ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("masukkan lebar kotak : ");
                int y = int.Parse(Console.ReadLine());
                kotak kotak = new kotak(x, y);
                Console.WriteLine("luas persegi adalah : " + kotak.luas());
            }
            else if (pilihan == 2)
            {
                Console.WriteLine("masukkan tinggi segitiga : ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("masukkan lebar segitiga : ");
                int b = int.Parse(Console.ReadLine());
                segitiga segitiga = new segitiga(a, b);
                Console.WriteLine("luas segitiga adalah : " + segitiga.luas());

            }



            }

           
            





        }
    }
}