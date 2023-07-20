using AbstractFactoryTwoByStyle.classes;
using AbstractFactoryTwoByStyle.interfaces;

namespace AbstractFactoryTwoByStyle.factories
{
    public class ScandinavianFurnitureFactory : IFurnitureFactory
    {
        public IFurniture CreateCabinet()
        {
            return new ScandinavianCabinet();
        }
        public IFurniture CreateChair()
        {
            return new ScandinavianChair();
        }
        public IFurniture CreateDiningTable()
        {
            return new ScandinavianDiningTable();
        }
    }
}