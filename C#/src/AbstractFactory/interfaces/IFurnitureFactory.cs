
namespace AbstractFactoryTwoByStyle.interfaces
{
    public interface IFurnitureFactory
    {
        IFurniture CreateCabinet();
        IFurniture CreateChair();
        IFurniture CreateDiningTable();
    }
}