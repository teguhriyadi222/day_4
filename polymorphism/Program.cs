
using polymororphism;
using polymororphism.manusia;

class Program 
{
  static void Main() 
  {
    Animal hewan = new Animal();  
    Animal babi = new babi();  
    Animal anjing2 = new anjing(); 
    Animal anjing = new anjing(); 
    Animal mony = new monyet();

    Animal animal2 = mony;

    hewan.animalSound();
    babi.animalSound();
    anjing.animalSound();
    mony.animalSound();
    animal2.animalSound();

    manusia manusia = new manusia();
    manusia.suaramanusia();
  }
}