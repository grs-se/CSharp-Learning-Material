# Understanding Methods

- Method is a function (group of statements), to do some process based on fields. 
- Methods are parts ot eh calss. 
- Methods can receive one or more input values as "paramateres" and treutnr a alue as "return". 
- parameter is input / incomingv value to method
- at end of method, method can give back result value which is called "return"
- this return value will be passed to the method caller where the method is invoked
- generally we call the method in the "Main" method. 

---

### Syntax of Method: 

```csharp
MethodName(parameter1, parameter2, ...)
// starting point of method body
{
 //method body: executable set of statements


// ending point of method body
}
```

- parameters can be of any type. Primitive (int, double, float, etc) or non-primitive types (struct, class, interface, etc)
- method will not be executed on its own. Outside the method you must call the method, only then the method will execute. 
- accessModifiers of methods are the same as field: private, protected, private protected, internal, protected internal, public. 
- accessibility of all accessmodifiers is same as fields. 
- after accessModifier, optional modifier. 
- csharp supports 7 modifiers: static, virtual, abstract, override, new, partial, sealed - all optional, no default.
- default accessmodifier is private for methods. 
- in case return type doesn't return any value then return type will be "void". Return type "void" indicates that the method doesn't return any value to the caller.
- 

```csharp
accessModifier modifier returnType MethodName(parameter1, parameter2, ...) 
{ 
   //Method body here
}
```

---
### Access Modifiers of Methods

Access Modifiers (a.k.a "Access Specifier" or "Visibility Modifier") of methods, are same as access modifiers of fields. 


| Access Modifier    | In the same class | In the child classes at the same assembly | In the other classes at the same assembly | Child classes at other assembly | Other classes at other assembly |
|--------------------|-------------------|-------------------------------------------|-------------------------------------------|---------------------------------|---------------------------------|
| private            | Y                 | N                                         | N                                         | N                               | N                               |
| protected          | Y                 | Y                                         | N                                         | Y                               | N                               |
| private protected  | Y                 | Y                                         | N                                         | N                               | N                               |
| internal           | Y                 | Y                                         | Y                                         | N                               | N                               |
| protected internal | Y                 | Y                                         | Y                                         | Y                               | N                               |
| public             | Y                 | Y                                         | Y                                         | Y                               | Y                               |

---

#### Class Library
- Class library compiled as DLL file, and we are required to add reference to that DLL file into the console applicaiton, so that all the classes that are accessible unde the class lbrary project are accesible under the console application.
- In realtime projects good practice to add reusable classes into class library, and reference them / access them in console project. 
---
Fro instance methods there must be a current object, otherwise it can't be called.
- doens't return any value so cannot print anything to console with Console.WriteLine()

