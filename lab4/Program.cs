using SaladFactory;

class Program
{
    static void Main(string[] args)
    {
        // Создаем фабрики
        VegetableFactory leafyGreenFactory = new LeafyGreenFactory();
        VegetableFactory rootVegetableFactory = new RootVegetableFactory();
        VegetableFactory fruitVegetableFactory = new CucubmerFactory();

        // Создаем салат
        Salad salad = new Salad();
        salad.AddVegetable(leafyGreenFactory.CreateVegetable("Spinach", 23, "Flat"));
        salad.AddVegetable(rootVegetableFactory.CreateVegetable("Carrot", 41, "Loamy"));
        salad.AddVegetable(fruitVegetableFactory.CreateVegetable("Cucumber", 18, true));

        // Отображаем салат и подсчитываем калории
        salad.DisplaySalad();
        Console.WriteLine($"\nTotal Calories in Salad: {salad.CalculateTotalCalories()}");
    }
}