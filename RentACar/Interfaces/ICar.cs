namespace RentACar.Interfaces
{
    public interface ICar
    {
        string Make { get; set; }
        string Model { get; set; }
        char Offer { get; set; }
        decimal Price { get; set; }
        decimal RentalPrice { get; set; }
        string Year { get; set; }

        decimal CalculateRent();
    }
}