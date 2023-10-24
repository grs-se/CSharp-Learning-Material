# Static Fields
- Static fields are the fields that are declared inside the class, along with the static keyword, but static fields will not be stored inside the object.
- Static fuelds are stored outside the object, that is in the class memory.As in the heap seperately the class memory will be created, inside the class memory all the static fields are stored, because static fields are common to all the objects of a class.
- So whenever you want to store some common data that belongs to all objects of the class then you are required to use the static fields. 
- e.g: bankname is common for all BankAccount objects so it is a static field, but accountNumber and accountHolderName are not, they are called isolated objects.


|                            |                              Instance fields (non-static fields):                             |                                                      Static Fields:                                                     |   |   |   |
|----------------------------|:---------------------------------------------------------------------------------------------:|:-----------------------------------------------------------------------------------------------------------------------:|---|---|---|
| Storage                    | Stored in Objects                                                                             | Sotre in Class's memory                                                                                                 |   |   |   |
| Related To                 | represents data related to objects                                                            | represents common data that belongs to all objects                                                                      |   |   |   |
| Declaration                | Declared without "static" keyword.                                                            | declared with static keyword                                                                                            |   |   |   |
| Accessible with            | Accessible with Object (through reference variable)                                           | Accessible with class name                                                                                              |   |   |   |
| When memory gets allocated | allocated seperately for each obkect, because instance fields are stored "inside" the objcets | Allocated inly once for the entire program, i.e. when the class is used for the first time while executing the program. |   |   |   |
