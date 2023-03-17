using RentACar.Classes;
using RentACar.Prints;

public class Program
{
    public static void Main(string[] args)
    {
        ReceiptOnEmail receiptToEmail = new ReceiptOnEmail();
        CarRentInfo listOfCars = new CarRentInfo();
        ReceiptInfo receiptInConsole = new ReceiptInfo();

        Car car1 = new PremiumCar("Audi", "A4", "2015", 10000);
        Car car2 = new PremiumCar("Lamborghini", "Urus", "2023", 100000);
        Car car3 = new StandardCar("Wolksvagen", "Polo", "2010", 200);
        Car car4 = new StandardCar("Yugo", "Koral", "1980", 500);

        List<Car> RentableCars = new List<Car>();
        RentableCars.Add(car1);
        RentableCars.Add(car2);
        RentableCars.Add(car3);
        RentableCars.Add(car4);

        foreach (var item in RentableCars)
        {
            listOfCars.printInfo(item);
        }

        receiptToEmail.ReceiptSentToEmail();

        receiptInConsole.printReceipt(car1);

    }
}