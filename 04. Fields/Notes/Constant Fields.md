# Constant Fields

- Like static fields, that are common to all obkects of the class.
- can't change the value of a constnat field - fixed values.
- accessible with class name [not with obkect]
- not stored in object, not stored anywhere. 
- each tiem access constant x it's value will be replaced, so after compilation the constant is not present in the program
- that is the reason constants are common to all objects because its memory is not allocated inside the object. 
- constant fields are not stored anywhere because constant fields are replaced with actual value always. 
- constant fields must be initialised, in line with declaration (with a literal value only)
- can also bedelcared as 'local constants' (in a method)

AccessModifier const type FieldName=value;

```csharp
public const string CategoryName = "Electronics"
```

Whenever you find some common and fixed data of all objects of the partcular class then use constant, on the otherhand if you find a common but not fixed data then required to use the static field. 

Access constant: Product.CategoryName;