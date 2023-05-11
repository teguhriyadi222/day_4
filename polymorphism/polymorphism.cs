namespace polymororphism
{
class Animal  
{
  public virtual void animalSound() 
  {
    Console.WriteLine("suara hewan");
  }
}

class babi : Animal  
{
  public override void animalSound() 
  {
    Console.WriteLine("babi bersuara : ini babi");
  }
}



class anjing : Animal  
{
  public override void animalSound() 
  {
    Console.WriteLine("babi bersuara : ini anjing");
  }
}

class monyet : Animal 
{
    public new void animalSound() 
    {
        Console.WriteLine("monyet bersuara : ini onyet");
    }
}

namespace manusia {

    class manusia {

        public void suaramanusia () 
        {
            Console.WriteLine("manusia");
        }
    }
}

}

