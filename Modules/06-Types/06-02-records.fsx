type Person = {
        FirstName: string;
        LastName: string;
        Age: int;
    }
let person1 = { FirstName = "John"; LastName = "Doe"; Age = 30 }
person1.FirstName // val it: string = "John"

//================================================================================

let person2 = { FirstName = "John"; LastName = "Doe"; Age = 30 }
let person3 = { FirstName = "John"; LastName = "Doe"; Age = 65 }
person1 = person2 // true
person1 = person3 // false

type Person = 
    {
        FirstName: string;
        LastName: string;
        Age: int;
    }
    with member this.FullName = $"{this.FirstName} {this.LastName}"
         member this.IsSenior = this.Age >= 65
         
{ FirstName = "John"; LastName = "Doe"; Age = 65 }.FullName // John Doe
{ FirstName = "Jane"; LastName = "Doe"; Age = 55 }.IsSenior // false
{ FirstName = "John"; LastName = "Doe"; Age = 65 }.IsSenior // true

//================================================================================

let person1 = { FirstName = "John"; LastName = "Doe"; Age = 30 }
let person2 = { person1 with Age = 31 }

//================================================================================

let person1 = { FirstName = "John"; LastName = "Doe"; Age = 30 }
let person2 = { FirstName = "John"; LastName = "Doe"; Age = 30 }
let person3 = { FirstName = "John"; LastName = "Doe"; Age = 65 }
person1 = person2 // true
person1 = person3 // false