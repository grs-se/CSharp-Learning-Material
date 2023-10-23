
# "this" Keyword

- The "this" keyword refers to the "current object", which method has invoked the method. Every time when you call the instance method there must be a current object and the same current object is by default represented as "this" keyword. 
- The "this" keyword is only available for "instance methods", that means non-static methods, but not static methods, because for the static methods there will not be any curent object. For example there is an instance method and we have two objcets for the same class. You must use either of the two objcets in order to call the method, so either based on Object1 you can call the method, or based on Object2 you can call the method, without based on any one object you cannot call the instance method. Here instance method is a non-static method that is the normal method. If you call that method through Object1 at this time the "this" keyword refers tot he 1st object, so you can call the fields and values of the 1st object. For example you can write this.field or this.method. 
- Next time you call the same method with reference of Object2, that means based on the reference vairable of object2 you're calling the method, at that moment the same this keyword refers to object2, because the method is called based on object2 so the this keyword referes to object2, and then by using the this keyword you can call the fields and methods of object2, so this.field an this.method refers to the fields and methods of object2. At that time the this keyword never refers to object1. 
- by default

```csharp
    //Set method for productID
    public void SetProductId(int value)
    {
        this.productID = value;
        //or
        //productId = value;
        //either are fine in this case

    }

    // but when parameter name and field name are the same
    // "this" keyword becomes compulsory becuase by just refering to 
    // productId you by default are referencing the parameter but 
    // not the field, and by writing this.productId you are referencing
    // the field but not the parameter.

        //Set method for productID
    public void SetProductId(int productId)
    {
        this.productID = productId;
    }
```

- So whenever you have a parameter or local vairable with the same name as a field, at that time you must use the "this" keyword in order to access the field of the current object. But on the other hand if the parameter name does not match with any of the field, at that time the this keyword is optional. 
- And overall you can use the "this" keyword in any isntance methods, that is in all the Set methods and Get methods in this current working class.
