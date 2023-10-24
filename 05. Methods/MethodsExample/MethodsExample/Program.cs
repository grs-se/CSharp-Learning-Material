class Sample
{
    static void Main()
    {
        //create reference variables
        Product product1, product2, product3;

        //create objects
        product1 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1);//1
        //Product.TotalNoProducts++;//1
        product2 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 2);//2
        //Product.TotalNoProducts++;//2
        product3 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 3);//3
        //Product.TotalNoProducts++;//3

        // convert all statements that assign values to the fields as methods
        //initalize fields
        product1.SetProductId(1001);
        //product1.productID = 1001;
        product1.SetProductName("Mobile");
        //product1.productName = "Mobile";
        product1.SetCost(20000);
        //product1.cost = 20000;
        product1.SetQuantityInStock(1200);
        //product1.quantityInStock = 1200;
        product2.SetProductId(1003);
        product2.SetProductName("Laptop");
        product2.SetCost(45000);
        product2.SetQuantityInStock(3400);
        product3.SetProductId(1004);
        product3.SetProductName("Speakers");
        product3.SetCost(36000);
        product3.SetQuantityInStock(800);

        //call methods
        //doens't return any value so cannot print anything to console with Console.WriteLine()
        product1.CalculateTax(9.2);
        product2.CalculateTax(7.4);
        product3.CalculateTax();

        //get values from fields
        System.Console.WriteLine("Product 1:");
        System.Console.WriteLine("Product ID: " + product1.GetProductID());
        System.Console.WriteLine("Product Name: " + product1.GetProductName());
        System.Console.WriteLine("Cost: " + product1.GetCost());
        System.Console.WriteLine("Quantity in Stock: " + product1.GetQuantityInStock());
        System.Console.WriteLine("Date of Purchase: " + product1.GetDateOfPurcase());
        System.Console.WriteLine("Tax: " + product1.GetTax());

        System.Console.WriteLine("\nProduct 2:");
        System.Console.WriteLine("Product ID: " + product2.GetProductID());
        System.Console.WriteLine("Product Name: " + product2.GetProductName());
        System.Console.WriteLine("Cost: " + product2.GetCost());
        System.Console.WriteLine("Quantity in Stock: " + product2.GetQuantityInStock());
        System.Console.WriteLine("Date of Purchase: " + product2.GetDateOfPurcase());
        System.Console.WriteLine("Tax: " + product2.GetTax());

        System.Console.WriteLine("\nProduct 3:");
        System.Console.WriteLine("Product ID: " + product3.GetProductID());
        System.Console.WriteLine("Product Name: " + product3.GetProductName());
        System.Console.WriteLine("Cost: " + product3.GetCost());
        System.Console.WriteLine("Quantity in Stock: " + product3.GetQuantityInStock());
        System.Console.WriteLine("Date of Purchase: " + product3.GetDateOfPurcase());
        System.Console.WriteLine("Tax: " + product3.GetTax());

        //total Quantity
        int totalQuantity = Product.GetTotalQuantity(product1, product2, product3);

        //product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();

        //display totals
        System.Console.WriteLine("Total Quantity: " + totalQuantity);
        System.Console.WriteLine("Total no. of products: " + Product.GetTotalNoOfProducts());  //Output: 3
        System.Console.WriteLine("Category of products: " + Product.CategoryName);  //Output: Electronics

        //TO DO: Findout the highest cost of all three products.
        System.Console.ReadKey();
    }
}

