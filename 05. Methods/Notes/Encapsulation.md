How do you group the data methods and fields together into a single unit of the class?

Encapsulation is a concept of:
- Bundling the data (fields) and operations (methods) that manipulate the data together. 
- Hides internal implementation details of ant object and privide the essential members to interacting with them.

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
