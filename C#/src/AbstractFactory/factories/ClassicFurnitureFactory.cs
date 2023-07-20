using AbstractFactoryTwoByStyle.classes;
using AbstractFactoryTwoByStyle.interfaces;

namespace AbstractFactoryTwoByStyle.factories
{
public class ClassicFurnitureFactory: IFurnitureFactory {
    public IFurniture CreateCabinet() {
        return new ClassicCabinet();
    }
    public IFurniture CreateChair() {
        return new ClassicChair();
    }
    public IFurniture CreateDiningTable() {
        return new ClassicDiningTable();
    }
}
}