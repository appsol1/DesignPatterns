using AbstractFactoryTwoByStyle.interfaces;

namespace AbstractFactoryTwoByStyle.classes
{
    public class ContemporaryDiningTable : IFurniture
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("I'm used for eating meals");
        }
        public void ShowStyle()
        {
            Console.WriteLine("I'm a Contemporary dining table ");
        }
    }
}