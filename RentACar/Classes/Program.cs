using RentACar.Classes;
using RentACar.Prints;

public class Program
{
    public static void Main(string[] args)
    {
        ReceiptOnEmail rc = new ReceiptOnEmail();
        PrintRentInfo pi = new PrintRentInfo();
        PrintReceiptInfo pri = new PrintReceiptInfo();

        Car c1 = new PremiumCar("Audi", "A4", "2015", 10000);
        Car c2 = new PremiumCar("Lamborghini", "Urus", "2023", 100000);
        Car c3 = new StandardCar("Wolksvagen", "Polo", "2010", 200);
        Car c4 = new StandardCar("Yugo", "Koral", "1980", 500);

        List<Car> RentableCars = new List<Car>();
        RentableCars.Add(c1);
        RentableCars.Add(c2);
        RentableCars.Add(c3);
        RentableCars.Add(c4);

        foreach (var item in RentableCars)
        {
            pi.printInfo(item);
        }

        rc.Receipt();

        pri.printReceipt(c1);

    }
}