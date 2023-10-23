# Local Variables & Parameters

- Every method, that may be instance method or static method, can have local variables and parameters. All the variables that are created inside the method body are called local variables. 
- Local variables are initialised and used within the same method itself. 
- Whenever you declare a variable inside the parameters of a method that is called 'parameter'. 
- The parameters are the variables that can issue the values from the calling portion of the method. That means while calling the method you can pass in an argument value, that value will be issued into the parameter automatically.
- A method can have multiple parameters. So while calling the method you must supply the value for all those parameters. At htat time the 1st value will be assigned into the 1st parameter, 2nd value assigned into the 2nd parameter, and so on. SO based on the sequence, the argument values will be assigned into the parameters respectively. 
- Both local variables and parameters are short-lived. They are stored inside the stack. So everytime when you call the method a new stack will be created for that method. In that stack all the local variables and parameters of that particular method will be stored. 
- And once the method execution is completed the stack will be delteed automatically. That means all the local variables and parameters that are stored inside that stack will be deleted automatically. In that way the local variables and parameters are short-lived. They can exist to the end of method execution only. 
- For every parameter you are required to specify the type, the type of the parameter can be anyhting, it can be any primitive or non-primitive type. Primitive types are int, float, decimal etc, and non-primitive types can be structure, class, interface, etc. 
