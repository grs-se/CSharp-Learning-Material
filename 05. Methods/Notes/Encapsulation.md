# Encapsulation

**Encapsulation is one of the important Object Oriented Programming features**.

The concept of encapsulation is all about: How do you group the data methods and fields together into a single unit of the class?

**What?**:
Encapsulation is a concept of:
- Bundling the data (fields) and operations (methods) that manipulate the data together. 
- Hides internal implementation details of ant object and privide the essential members to interacting with them.

**Benefits**:
- Modularity
- Hiding Implementation details
- Data Integrity

**Implemented using**:
- Private fields &
- Public properties or public methods


2 aspects to this: 
- 1 = group the data memebers
- 2 = hiding implementation details, i.e. the code from outside the class should be able to access the fields indirectly only through methods but not the fields directly. 

Data modularity - encapsulation encourages developers to write a class that contains two types of members mainly: fields and methods. 

1. 
Fields are the data. Person name, email, phone number.
And also there can be some manipulations that can be performed on these data, for example storing or setting a value intot he field, returning those details later, while printing the values to the user, supplying the details to another class, and also performing the validations, i.e. checking that the values are correct or not before storing them into the field. 
- Also there may be some calculation logic. 
- So to perform operations on the fields you are required to create methods. 
- So you have the data in the form of fields, and you have operations in the form of methods. 
- A class encapsulates, that means groups together as a single unit. So this is the first part of the encapsulation. 

2. 
- The other aspect of encapsulation is to hide the implementation details. That means you will have to create the private fields with public methods so it encourages the "data integrity", that means the code that is outside the class will be able to access the fields only through methods, but not directly. 

```csharp
Class {
    //Private fields
    //Public properties or methods: code that exists outside this class can access
}
```

#### Set and Get Methods. 

Set method is used to assign a value into the field.
Get method is used to retrieve the value from the field. 


Instead of assignign the value directly into the field, it is better to pass that value to the method, and inside the method we assing the value into the field. In that way methods allow you to access the fields indirectly. This is the better way of programming in real0time projects because isnide the method we can write some code for validattions or caluclations which are necessary every time you access a particular field. 

For each field you can create two types of methods: Set method, and Get method.

The Get method simply return the exisitng value of the field. If required it is able to perfomr some simpe caluclatuons such as calculating ther tax based on the cost. 

Inside the SetProductId() method we receive a parameter from the calling portion, that means from the place where you call this method you can pass a value as an argument, that argument value will be issued in this place, so here you are required to create a parameter. The parameter is nothing more than a local variable which is able to receive the value from the calling portion. The parameters are short lived, they will be allocated exactly when you call the method and the parameters will be deleted at the end of the execution of the method. So parameters are very short lived. They exist until the end of the execution of the method in which they are declared. But fields are long-lived because they exist until the end of the object and generally objects are deleted at the end of the application. So this parameter will not be stored inside the object directly. The parameters are stored inside the stack. So that is the reason we have to copy the value from the parameter into the respective field, that is ProductId in this case. So read the value from the parameter called value, and assign the same into the field called ProductId. So this is the Set method for ProductId field. You can follow the same syntax for all the subsequent Set methods.

```csharp
public class Product
{
    //fields
    public int productID;

    //Set method for productId
    public void SetProductId(int value)
    {
        productID = value;
    }
}

```

- Generally the Get method returns the value of the field. 
- the type of the field is int, so the return type of the Get method will also be int.
- Naming convention: first create a prefix called Get, and then followed by the field name which is ProductId in this case: GetProductId. 
- So it will read the value of the field and return the same to the calling portion where this method is called. 

```csharp
public class Product
{
    //fields
    public int productID;

    //Get method for productID
    public int GetProductID()
    {
        return productID;
    }
}

```

So here we have implemented encapsulation in such a way that we have declared a set of fields and a corresponding manipulative methods in the same unit that is called Product Class. So whenever you create a set of fields and a set of methods that manipulate those fields as a single unit that concept is called "encapsulation". 

- So here instead of settign the value directly intot he field, we are going to call the SetPRoductId() method and pass in the vlaue as an argument. 
- So how does this method get executed? When you call the method the execution sequence jumps tot he particular method. So for this method a seperate stack will be created. In that stack the parameter variable gets stored. And also the parameter will issue the vlaue that you pass while calling the method. So the value of 1001 will be issued into the parameter int'value', and the same value that is 1001 will be assigned into the field which is productId. So overall by calling this method you are inititlising 1001 intot he productId. That is why we can say that the Set method is used to assing a value into the field. For Realtime programming using the methods is a better way necause inside the method we can add some logic for calulcaiton or checking some conditions, to validate the value before assigning it to field. 


```csharp
//Program.cs
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
```

While printing the value of the field, instead of accessing the field directly it is better to call the Get method, so the get method returns the value of the field, and that value can be printed by using Console.Writeline method.
- This is the better and recommended wya of programming in Object Oriented Programming, because the methods must be used to manipulate the fields. 

---

Suppose a class has a set of fields and methods but from outside the class all the fields and methods should not be accessible, only it should provide a set of fields and methods that are essential to outside the class. That means some fields and methods are hidden in the same class itself without allowing them to be visible outside the class. For example a person has a lot of thoughts in his mind, but he may not reveal all of his thoughts to outside world, he reveals only some of his thoughts to others so that the remaining thoughts are hidden. 

The code that exists outside the class can access only the public fields and methods, but cannot access the private fields and methods. But these private methods can be called as part of the public methods indirectly, and even these private fields can be accesseible inside the public methods or in the private methods also. And when you create an object it will allocate the memory for private fields also.   
