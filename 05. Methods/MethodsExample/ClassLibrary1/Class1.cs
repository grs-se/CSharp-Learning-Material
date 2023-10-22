public class Product
{
    //fields
    public int productID;
    public string productName;
    public double cost;
    public double tax;
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

    //method
    /*const <= 20000 then tax = 10%
    const > 20000 then tax = 12.5%*/
    public void CalculateTax()
    {
        //create local variable
        double t;

        //calculate tax
        if (cost <= 20000)
        {
            t = cost * 10 / 100;
        }
        else
        {
            t = cost * 12.5 / 100; 
        }
        tax = t;
    }
}

