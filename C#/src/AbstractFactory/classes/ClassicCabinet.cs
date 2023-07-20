using AbstractFactoryTwoByStyle.interfaces;

namespace AbstractFactoryTwoByStyle.classes
{
    public class ClassicCabinet : IFurniture
    {
        public void FurnitureFunction()
        {
            Console.WriteLine("I'm used for storing item");
        }
        public void ShowStyle()
        {
            Console.WriteLine("I'm a Classic cabinet ");
        }
    }
}