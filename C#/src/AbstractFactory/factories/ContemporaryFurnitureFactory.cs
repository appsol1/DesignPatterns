using AbstractFactoryTwoByStyle.classes;
using AbstractFactoryTwoByStyle.interfaces;

namespace AbstractFactoryTwoByStyle.factories
{
    public class ContemporaryFurnitureFactory : IFurnitureFactory
    {
        public IFurniture CreateCabinet()
        {
            return new ContemporaryCabinet();
        }
        public IFurniture CreateChair()
        {
            return new ContemporaryChair();
        }
        public IFurniture CreateDiningTable()
        {
            return new ContemporaryDiningTable();
        }
    }
}