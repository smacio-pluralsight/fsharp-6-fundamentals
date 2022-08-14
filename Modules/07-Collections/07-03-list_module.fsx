// generate a five item list
let list = List.init 5 (fun x -> x*2)

// list of random numbers
let list = let r = System.Random() in List.init 10 (fun x -> r.Next(0, 10));;

//================================================================================

List.sort [5..-1..0]
List.sortDescending [1..5]
List.rev ["a"; "b"; "c"]

//================================================================================

List.exists (fun x -> x > 2) [1..5]
List.where (fun x -> x <3) [1..5]

//================================================================================

List.findIndex (fun x -> x = "b") ["z"; "e"; "a"; "b"; "4"]
List.find (fun x -> x%2=0) [1; -1; 9; 4; 3]

//================================================================================

let list1d = [1; 3; 7; 9; 11; 13; 15; 19; 22; 29; 36]
let isEven x = x % 2 = 0
match List.tryFind isEven list1d with
| Some value -> printfn "The first even value is %d." value
| None -> printfn "There is no even value in the list."

match List.tryFindIndex isEven list1d with
| Some value -> printfn "The first even value is at position %d." value
| None -> printfn "There is no even value in the list."

//================================================================================

List.zip ["a"; "b"; "c"] [1..3]
List.unzip [("a",  1); ("b", 2); ("c", 3)]

//================================================================================

let list = [1.; 2.; 10.; 3.; 2.; 5.]
List.sum list, List.average list, List.min list, List.max list

//================================================================================

List.concat [[1..3]; [4..6]; [7..9]]
List.append [1..3] [4..6]
List.removeAt 1 [1..3] 

//================================================================================

List.take 2 [1..5]
List.takeWhile (fun x -> x < 0) [-1; -2; 3; 4; -10]
List.skip 3 [1..6]
List.skipWhile (fun x -> x<0) [-1; -2; 3; 4; -10]

//================================================================================

[1..10] |> List.skip 3 |> List.take 2

