using System;

public class DVD
{
    private int catalogNumberValue;
    private decimal rentalValue;
    public string Title { get; set; }

    public int CatalogNumber
    {
        get
        {
            return catalogNumberValue;
        }
        set
        {
            if (value > 999999 || value < 100000)
                throw new Exception("Catalog number must be between 100000 and 999999!");
            catalogNumberValue = value;
        }
    }
    public decimal Rental
    {
        get
        {
            return rentalValue;
        }
        set
        {
            if (value > 49.99M || value < .99M)
                throw new Exception("Daily rental must be between $0.99 and $49.99!");
            rentalValue = value;
        }
    }

    override public string ToString()
    {
        return CatalogNumber + ": " + Title + ", " + Rental.ToString("C") + "/day";
    }
}
