let list0 = []

let list2 = [ // multi-line list<int>
    1
    2
    3
]
let list1 = [1; 2; 3] 
let list3 : float list = [1.; 2; 3.] 
let list4 = [1..5] 

//================================================================================

let list1 = [1;2;3]
let list2 = [4;5;6]
list1[1] // 2 (i+1 element in 0 based list)
list1.[1] // 2 (i+1 element in 0 based list)
list2[2] = 6
list2[0] <- 0 // error

//================================================================================

let list1 = [1;2;3;4]
let head :: tail = list1

//================================================================================

let list1 = [1;2;3]
let list2 = [4;5;6]

10 :: list1 // [19;1;2;3]
list1 :: 10  // can't do this

// but you can do this
list1 @ [10]
list1 @ list2 // [1;2;3;4;5;6]

//================================================================================

let list = [1..100] 
list[10..14] // bounded on both ends
list[..4] // first five
list[96..] // last five

//================================================================================

let list = [ 1; 2; 3 ]
list.IsEmpty 
list.Length
list.Head
list.Tail
list.Tail.Head
list.Tail.Tail.Head
list.Item(1)

//================================================================================

// comprehensions
[for x in 1..5 do yield x*x]
[for x in 1..5 -> x*x]
[
    for r in 1..8 do
        for c in 1..8 do
            if r <> c then yield (r,c)
]

//================================================================================


let list = List.init 5 (fun x -> x*2)

// list of random numbers
let list = let r = System.Random() in List.init 10 (fun x -> r.Next(0, 10));;

List.sort [5..-1..0]
List.sortDescending [1..5]
List.rev ["a"; "b"; "c"]

List.exists (fun x -> x > 2) [1..5]
List.where (fun x -> x <3) [1..5]

List.findIndex (fun x -> x = "b") ["z"; "e"; "a"; "b"; "4"]
List.find (fun x -> x%2=0) [1; -1; 9; 4; 3]

let list1d = [1; 3; 7; 9; 11; 13; 15; 19; 22; 29; 36]
let isEven x = x % 2 = 0
match List.tryFind isEven list1d with
| Some value -> printfn "The first even value is %d." value
| None -> printfn "There is no even value in the list."

match List.tryFindIndex isEven list1d with
| Some value -> printfn "The first even value is at position %d." value
| None -> printfn "There is no even value in the list."

List.zip ["a"; "b"; "c"] [1..3]
List.unzip [("a",  1); ("b", 2); ("c", 3)]

let list = [1.; 2.; 10.; 3.; 2.; 5.]
List.sum list, List.average list, List.min list, List.max list

// calculate a sum using a fold
List.fold (fun accum x -> accum + x) 0 [1..5]
// sum of greater element at each position in the list
List.fold2 (fun acc elem1 elem2 ->
            acc + max elem1 elem2) 0 list1 list2

let sum = sumGreatest [1; 2; 3] [3; 2; 1]

let list = [1..3]
[for x in list -> x * 2]
List.iter (fun x -> printfn "%A" x) list
List.map (fun x -> x * x) list

let list = [1..100] // val array: int[] = [|1; 2; ...; 100 |]

// bounded on both ends
list[10..14] // val it: int[] = [|11; 12; 13; 14; 15|]
// first five
list[..4] // val it: int[] = [|1; 2; 3; 4; 5|]

// last five
list[96..] // val it: int[] = [|97; 98; 99; 100|]

List.concat [[1..3]; [4..6]; [7..9]]

List.append [1..3] [4..6]

List.removeAt 1 [1..3] 

List.take 2 [1..5]
List.takeWhile (fun x -> x < 0) [-1; -2; 3; 4; -10]
List.skip 3 [1..6]
[1..10] |> List.skip 3 |> List.take 2
List.skipWhile (fun x -> x<0) [-1; -2; 3; 4; -10]