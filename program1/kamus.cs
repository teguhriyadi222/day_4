namespace program1;

class kamus
{
    public Dictionary <string, string> _kamus ;

    public kamus()
        {
            _kamus = new Dictionary<string, string>() ;
        }

    public void tambahkata(string kata, string arti)
        {
            _kamus.Add(kata, arti);

            Console.WriteLine("kata berhasil ditambahkan");
        }

    public void hapuskata(string kata)
    {
        if (_kamus.ContainsKey(kata))
        {
            _kamus.Remove(kata);
            Console.WriteLine("kata berhasil dihapus");
        } else {
            Console.WriteLine("kata tidak ditemukan");
        }
    }

    public void carikata(string kata) {

        if (_kamus.ContainsKey(kata))
            {
                Console.WriteLine("{0} : {1}", kata, _kamus[kata]);
            }

        else {
            Console.WriteLine("kata tidak ditemukan");;
        }
    }
}

class updatekata : kamus {

    public void Update(string kata, string arti) {

        if (_kamus.ContainsKey(kata))
        {
            _kamus[kata] = arti;

            Console.WriteLine("arti berhasil diperbarui");
        }else {
            Console.WriteLine("kata tidak ditemukan");;
        }

    }

}