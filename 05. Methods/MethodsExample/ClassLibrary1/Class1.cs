public class Product
{
    //fields
    private int productID;
    private string productName;
    private double cost;
    private double tax;
    private int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    private readonly string dateOfPurchase;

    //constructor
    //outside of constructor readonly field cannot be modified
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }

    //Set method for productID
    public void SetProductId(int value)
    {
        this.productID = value;
    }

    //Get method for productID
    public int GetProductID()
    {
        return productID;
    }

    //Set method for productName
    public void SetProductName(string value)
    {
        productName = value;
    }

    //Get method for productName
    public string GetProductName()
    {
        return productName;
    }

    //Set method for cost
    public void SetCost(double value)
    {
        cost = value;
    }

    //Get method for cost
    public double GetCost()
    {
        return cost;
    }

    //Set method for quantityInStock
    public void SetQuantityInStock(int value)
    {
        quantityInStock = value;
    }

    //Get method for quantityInStock
    public int GetQuantityInStock()
    {
        return quantityInStock;
    }

    // No set method for dateOfPurchase as readonly field.
    //Get method for dateOfPurchase
    public string GetDateOfPurcase()
    {
        return dateOfPurchase;
    }

    //static method: Set method TotalNoOfProducts
    public static void SetTotalNoOfProducts(int value)
    {
        TotalNoProducts = value;
    }

    //static method: Get method TotalNoOfProducts
    public static int GetTotalNoOfProducts()
    {
        return TotalNoProducts;
    }

    //Set method for tax
    public void SetTax(double value)
    {
        tax = value;
    }

    //Get method for tax
    public double GetTax()
    {
        return tax;
    }

    //Calculate tax method
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


    //static method: Calculates Total Quantity
    public static int GetTotalQuantity(Product product1, Product product2, Product product3)
    {
        int total;
        total = product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();
        return total;
    }
}

