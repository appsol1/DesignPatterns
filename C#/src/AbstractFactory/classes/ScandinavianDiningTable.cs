using AbstractFactoryTwoByStyle.interfaces;

namespace AbstractFactoryTwoByStyle.classes
{
    public class ScandinavianDiningTable : IFurniture
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("I'm used for eating meals");
        }
        public void ShowStyle()
        {
            Console.WriteLine("I'm a Scandinavian dining table ");
        }
    }
}