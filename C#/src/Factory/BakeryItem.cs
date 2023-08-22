abstract class BakeryItem {
    public abstract string ItemType();

    public abstract decimal GetPrice();
}

class Pizza : BakeryItem {
    public override string ItemType() => "Pizza";

    public override decimal GetPrice() => 80;
}

class Cake : BakeryItem {
    public override string ItemType() => "Cake";

    public override decimal GetPrice() => 50;
}