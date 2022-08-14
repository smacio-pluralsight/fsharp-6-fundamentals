let parts : System.Collections.Generic.IDictionary<_,_> =
    [ "Nuts", 15; "Bolts", 25; "Washers", 7 ]
    |> dict

let nuts = parts["Nuts"]

// these are errors
parts["Nuts"] <- 27
parts.Add("Screws", 5)
parts.Remove("Nuts")

//================================================================================

open System.Collections.Generic
let dictionary = new Dictionary<string, int>()

dictionary["a"] <- 1 // val it: unit = ()
dictionary["b"] <- 2 // val it: unit = ()
dictionary

dictionary["a"] = 1

//================================================================================

let capitals = ["USA", "Washington D.C"; "Canada", "Ottawa"; "France", "Paris"] |> Map.ofList

let usa = capitals["USA"] // val usa: string = "Washington D.C"
let canada = capitals["Canada"] // val canada: string = "Ottawa“

let newCapitals = 
    capitals
    |> Map.add "Japan" "Tokyo"
    |> Map.remove "France"

//================================================================================

let set1 = ["A"; "B"; "A"; "A"; "C"] |> Set.ofList  
let set2 = [| "C"; "D"; "A"; "E"; "C" |] |> Set.ofArray 
let set3 = [| "B"; "C"|] |> Set.ofArray 

let set4 = set1.Add("Z") 
let set5 = set2.Remove("F") 

let union = set1 + set2 + set3 
let intersect = set1 |> Set.intersect set2 
let isSubset = set1 |> Set.isSubset set3 
