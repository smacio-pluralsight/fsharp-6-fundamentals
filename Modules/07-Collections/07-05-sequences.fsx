
seq {1..10}
seq { for i in 1..10 -> i*i }

//================================================================================

let bigBadList = [1..100000000]

// this takes a while before output starts
for i in [1..100000000] do 
    if i < 10 then printfn "%A" i

// output starts immediately
for i in seq {1..100000000} do
    if i < 10 then printfn "%A" i

//================================================================================

let isprime n =
    let rec check i =
        i > n/2 || (n % i <> 0 && check (i + 1))
    check 2

let aSequence =  seq {
        for n in 1..100 do
            if isprime n then
                n
    }

for x in aSequence do
    printfn "%d" x

//================================================================================

let time f x =
    let timer = new System.Diagnostics.Stopwatch()
    timer.Start()
    try f x finally
    printfn "Took %dms" timer.ElapsedMilliseconds

time (fun () -> [1..100000000])()
time (fun () -> seq {1..100000000})()

