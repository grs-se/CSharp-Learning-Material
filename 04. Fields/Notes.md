## STATIC FIELDS

- static fields are stored outside the object, in the class memory. 
- static fileds are common to all objects of a class.
- static fields are common to all objects of the class
- whenever you want to store some common data that belongs to all objects of the class then required to use static fieds. 
- e.g: bankname is common for all BankAccount objects so it is a static field, but accountNumber and accountHolderName are not, they are called isolated objects.


|     Instance fields (non-static fields):                                                                     |     Static Fields:                                                                                                                     |
|--------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------|
|     Stored in Objects                                                                                        |     Sotre in Class's memory                                                                                                            |
|     represents data related to objects                                                                       |     represents common data that belongs to all   objects                                                                               |
|     Accessible with Object (through reference   variable)                                                    |     declared with static keyword                                                                                                       |
|     allocated seperately for each obkect,   because instance fields are stored "inside" the objcets          |     Accessibke with class name                                                                                                         |
|                                                                                                              |     Allocated inly once for the entire program,   i.e. when the class is used for the first time while executing the program.          |
|                                                                                                              |     static fields are not constants - they can   be changed.                                                                           |
|                                                                                                              |                                                                                                                                        |

---
## Constant Fields

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

---
## Readonly Fields

- Much ike instance fields, except that the value of a readonly cannot be modified. 
- Isolated for every object, because stored in the object only. So when you create an object it includes the readonly fields also. 
- Readonly fileds are acceisble with reference variable [ with object ]
- Readonly fields must be initialised, either "in-line iwth declaration" [or] "In the constructor".
- the prupsoe of itniailising the readonly field inside the constructor is you can call another method or perform some calculation and store the result inside the readonly field, but once the constructor execution has been completed with the value of the readonly field cannot be changed. 

AccessModifier const type FieldName=value;

```csharp
public readonly string CategoryName = "Electronics"
```

- SYntax is almost same as static field.
- overall, when you want store some common data that belongs to all objects of the class use the static field. when you have common data that belongs to all objects and at same time it is fixed value you dont want to change it later, then use constant. On other hand, if oyu have some data that is isolated to every object, that means the value of that particular field is immutable for every object, but at the same time you don't want to allow the value to be changed, in that case, go for readonly field. 
- readonly fields cannot be delcared as 'local' inside a method, they can only be delcared inside the class. 

