using AbstractFactoryTwoByStyle.interfaces;

namespace AbstractFactoryTwoByStyle.classes
{
    public class ScandinavianChair : IFurniture
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("I'm used to sit on");
        }
        public void ShowStyle()
        {
            Console.WriteLine("I'm a Scandinavian chair ");
        }
    }
}