## Static Constructor
1. If a constructor is explicitly declared using a static modifier we call that constructor as static constructor.
2. It is invoked automaticaly before first instance is created or any static member is referenced.
3. C# static __constructor cannot have any modifier or parameter__.
4. C# static construcor is invoked implicityly. It can't be called explicitly.

## Static Class
- Static means something which cannob be instatated.
- Static class contain only static member.
- We cannot create object of static member.
- We cannot access static member using an object.
- Static member are accessed by the class name followed by the member name.

## Destructor
+ A destructor word opposite to constructor , it destruct the object of classes.
+ It can be defined only once in a class.

## Abstract Method
+ Abstract method are those type of method that don't require implemmentation for its declaration.
+ These mehtod don't have a body which means no implementation.

### Properties of Abstract Method
* Abstract mehtod in C# declared through the keyword  "abstract"

### Abstract class
* Partially implemented class is known as  absract class.

## Sealed Class
- sealed class are used to restrict the inheritance feature of object oriented programming.
- Once a class is defined as a sealed class this class cannot be inherited.

## Virtual Method
* Virtual method is a method that can be overriden in a derived class.
* When a mehtod is declared as virtual in a base class, it allows a derived class to provide its own implementation of the method.

## Protterties in C#
* Private variable can only be accessed within the same class (outside class has no access to it).
* Sometime we need to access them and it can be done with properties.
* Properties is like a bombination of variable and method it has two method __get, set__.

### Type of properties in C#
* Read_Write (Accessors : get,set;)
    - Contains both get and set accessor. 
        - Read-Write property allow you to read and modify the value of the property.

* Read_Only (Accessors : get ;)
    - Contains a get accessor Only.
        - Read-Only property typically used when you want to provide read-only access to a property.

* Write-Only (Accessors : set): 
    - Contains a set accessor only.
        - Write-Only property is useful when you need set a property value but don't want to allow reading.

* Auto-Implemented (Accessors : get, set):
    - Contains both get and set accessors without logic.
        - Auto implemented property is a consice way to define properties without writing explicit getter and setter methods.


## this keyword 
* The this keyword __can be used to refer current class instance variable.__
* If there is ambiguity between the instance variable and parameters, this keyword resolves the problem of ambiguity

## Interface

## Namespace 
* Namespaces in c# are used to organize too many classes so that it can be easy to handle the application.
* In a simple c# program, we use __System.Console__ where System is the __namespace__ and __Console__ is the class
* A namespace can have :
    - Class
    - Interface
    - Structure
    - delegates
        * __namespace__ namespace_name{
            // body of namespace 
        }
    ### Why Namespacce is used?
    * __Organization__ : organize large project code by __grouping related class, interface, enum.__
    * __Avoiding name confilice__ : revent nameing conflicts by differentiating between items that have the same name but reside in different namespaces.
    * __Readablility and maintenance__ : makes code more readable and easier to maintain.

## Parameter
* Defines the set of argument that must be provided for method.
```c#
    static void MyMethod(string fname){
        Console.WriteLine(fname + "REfsnes");
    }
```
## Out modifieer 
    is used to get multiple return value back from the method.

    * Ref : pass the variable by reference 
            Allows return by ref(ref return)
    * Out : pass uninitialized variable to a method
            Must be initialized in the called method

    

## Generics
* __C# Generics__  all us to create a single class or method that can be used with different types of data.
* Make classes and method type independent and type safe.
* This help us to reuse our code.
* __System.Collection.Generic__

    ### Generics classes
    * The generic class can be defined by outtin hte <T> sign after the class name.
    * The collections framework uses the concept of Generics in C#.


## Queue
* Are special type of container that ensures the item are being accessed in FIFO manner
    * Enqueue() : Add and object to end of queue
    * Dequeue() : Removes the object from the beginning of queue
    * Peek() : Return the object at the beginning of queue without removing it.
    
## Dictionary
* Also known as map or hash table.
* Dictionary is a generic collection which is generally used to store key/value pairs.
* In Dictionary , the key cannot 

## Boxing nd UnBoxing 
* Boxing is the act of converting value type instance to reerence type instance
``` c#
int a =3;
Object obj = a;
Console.WriteLine(obj);
```

* UnBoxing reverse the operation , by casting the object back to the original value type.
* Requres explicit cast.
``` C#
int a =3;
Object obj = a
int y= (int)obj;
Console.WriteLine(y)
```

#### Memory Allocation
```
    stack memory            Heap Memory
        x
    ------------
    |   20      |
    ------------
        obj                 0x10000001
    ------------            ----------
    |0x10000001| --------->|    20    |
    ------------            ----------
        y                        |
    ------------                 | 
    |    20     |<------------------  
    ------------
        
```

## Structure 
* Structure are used to hold data of various data type into single variable
* struct keyword is used for creating structure.
* Structure cannot inherit other structure.
* Structure cannot inherit other structure.
* Structure member cannot be specified as abstract ,sealed ,virtual.

````
# Note :
classes are reference types and structs are value types structures don't support inheritance structures cannot have default constructor.
````
| *STRUCT*                                             | *Class*                                                                 |
|--------------------------------------------------------|----------------------------------------------------------------------------|
| Lightweight data structures, simple objects            | Complex objects, behavior, inheritance                                     |
| Members are public by default                          | Members are private by default                                             |
| Does not support inheritance                           | Supports single and multiple inheritance                                   |
| Creates a copy of the entire struct                    | Copies the reference, not the object                                       |
| Efficient for small, frequently used objects           | Overhead due to heap allocation and reference handling                     |
| Can be made nullable                                   | Nullable by default                                                        |

## Exception Handling
* The exception handling in C# is one of the powerful mechanisms to handle the runtime errors so that normal flow of the application can be maintained.
* EH define alternative ways so that the program can execute successfully.
* Java EH is managed via five keywords: __try, catch, throw, throws__ and __final.__

## Generic Delegate
* The Generic Delegates in c# were introduced as part of .NET Framework 3.5 which doesnt require defining the delegate instance in order to invoke the ethods.
* C# has 3 built in generic Delgate
    1. Func Delegate
    2. Action Delegate
    3. Predicate Delegate


## Anonymous Method
* As the name suggests, an enonymous method is a method without a name.
* Anonymous methods in C# can be defined using the delegate keyword and can be assigned to a variable of delegate typep.
``
    1. Anynomous method can be defined using the delegate keyword.
    2. Anonymous method must be assigned to a delegate.
    3. Anonymous method can be passed as parameter.
    4. Anonymous method can access outer vairables or functions.
    5. Anonymous mehtod can be used as event handlers.
``


