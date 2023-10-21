public class Product
{
    //fields
    public int productID;
    public string productName;
    public double cost;
    public int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;

    //constructor
    //outside of constructor readonly field cannot be modified
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }
}

