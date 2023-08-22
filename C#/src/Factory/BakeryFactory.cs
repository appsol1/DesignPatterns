abstract class BakeryFactory {
    public abstract BakeryItem Create();
}

class PizzaFactory : BakeryFactory {
    override public BakeryItem Create() => new Pizza();
}

class CakeFactory : BakeryFactory {
    override public BakeryItem Create() => new Cake();
}