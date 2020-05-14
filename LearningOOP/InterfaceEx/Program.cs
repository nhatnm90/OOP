using System;

namespace InterfaceEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //var frog = new Frog("Uncle of Haven");
            //frog.Move();
            //(frog as IWaterAnimal).Move();
            var amazon = new Jungles("Amazon", 4);
            foreach (var frog in amazon.GetFrogs(2))
            {
                frog.Showinfo();
            }
        }
    }
}
