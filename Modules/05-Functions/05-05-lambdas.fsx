fun x -> x * x

(fun x -> x * x) 5


(fun (x:float) -> x * x) 5

let square = (fun x -> x * x)
square 5

List.map (fun x -> x * x) [1;2;3;4]

List.map (fun x -> x = x * x; x + 1) [1;2;3;4]
