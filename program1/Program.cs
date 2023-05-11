namespace program1;

class Program {
    static void Main() {

        kamus kamus = new kamus();
        updatekata updatekata = new updatekata();
         
         kamus.tambahkata("water","air");
         

         updatekata.Update("anjing","babi");

         kamus.carikata("water");
         kamus.hapuskata("water");
    }
}