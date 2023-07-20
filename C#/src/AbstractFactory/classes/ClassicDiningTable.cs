using AbstractFactoryTwoByStyle.interfaces;

namespace AbstractFactoryTwoByStyle.classes
{
    public class ClassicDiningTable : IFurniture
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("I'm used for eating meals");
        }
        public void ShowStyle()
        {
            Console.WriteLine("I'm a Classic dining table ");
        }
    }
}