// See https://aka.ms/new-console-template for more information

BakeryItem[] order = new BakeryItem[] {new PizzaFactory().Create(), new CakeFactory().Create()};

for(int i = 0; i < order.Length; i++ ){
    Console.WriteLine($"{order[i].ItemType()}: {order[i].GetPrice()}");
}
