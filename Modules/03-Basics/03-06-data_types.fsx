let a:float = 1
let square (x: float) = x * x
let square x : float = x * x

//================================================================================

open System.Collections.Generic
let dictionary = new Dictionary<string, int>()

dictionary["a"] <- 1
dictionary["b"] <- 2
dictionary

dictionary["a"] = 1

//================================================================================

let atuple = (1, 2., "HI!")
let (a, b, c) = atuple
a 
b 
c 

//================================================================================

type Person = 
    {
        FirstName: string;
        LastName: string;
        Age: int;
    }

let person1 = { FirstName = "John"; LastName = "Doe"; Age = 30 }
person1.FirstName // val it: string = "John"
