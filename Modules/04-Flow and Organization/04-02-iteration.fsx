// all output 1 2 3, each on a new line
for i in [1; 2; 3] do // iterate across all items
    printfn "%A" i
for i = 1 to 3 do // iterate integers from 1 to 3
    printfn "%A" i
for i in [1..3] do // iterate integers from 1 to 3
    printfn "%A" i
let mutable i = 0;
while i < 3 do // keep doing this until i is 3
    printfn "%A" i
    i <- i + 1 // this is a «side effect»

//================================================================================

// sum the items in a list, imperative / old school
let data = [1; 2; 3]
let mutable mutableSum = 0;
for value in data do mutableSum <- mutableSum + value
// functional / expression way to sum
let sum = List.sum(data)

// instead of a for loop to print
List.iter (fun x -> printfn "%A" x) data 

// functional / fold form of sum
List.fold (+) 0 [1;2;3]
// val it: int = 6
//================================================================================

[for x in 1..5 do yield x*x] 
// val it: int list = [1; 4; 9; 16; 25]

[for x in 1..5 -> x*x] // short cut for above

[
    for r in 1..8 do
        for c in 1..8 do
            if r <> c then yield (r,c)
] 
// val it: (int * int) list = [(1,2); (1,3); ...]

