using RentACar.Classes;
using RentACar.Interfaces;
using RentACar.Prints;

public class Program
{
    public static void Main(string[] args)
    {
        IReceiptOnEmail receiptToEmail = Factory.CreateReceiptOnEmail();
        ICarRentInfo listOfCars = Factory.CreateCarRentInfo();
        IReceiptInfo receiptInConsole = Factory.CreateReceiptInfo();

        ICar car1 = Factory.CreatePremiumCar("Audi", "A4", "2015", 10000);
        ICar car2 = Factory.CreatePremiumCar("Lamborghini", "Urus", "2023", 100000);
        ICar car3 = Factory.CreateStandardCar("Wolksvagen", "Polo", "2010", 200);
        ICar car4 = Factory.CreateStandardCar("Yugo", "Koral", "1980", 500);

        List<ICar> RentableCars = new List<ICar>();
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