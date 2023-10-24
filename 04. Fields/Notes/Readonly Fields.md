# Readonly Fields

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
