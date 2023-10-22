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


