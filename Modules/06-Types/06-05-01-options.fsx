
let someInt = Some 1
let noneInt = None

//================================================================================

let isItSomething = function
    | Some i -> "$Yes, it is something {i}"
    | None -> "Nope, it's nothing"


isItSomething (Some 1) 
isItSomething None 

//================================================================================

let addIntsAsOptions x y =
    match x with
        | Some xv -> 
            match y with 
                | Some yv -> Some (xv + yv)
                | None -> None
        | None -> None

addIntsAsOptions (Some 1) (Some 2)
addIntsAsOptions None (Some 2)
addIntsAsOptions (Some 1) None
addIntsAsOptions None None

let addInts xo yo =
    xo |> Option.map (fun xv -> yo |> Option.map (fun yv -> yv + xv))
addInts (Some 1) (Some 2)
addInts (Some 1) None



let describe = function
    | Some x -> $"The value is {x}"
    | None -> $"There is no value"

"42.0" |> parse |> describe
"foo" |> parse |> describe


"42.0" |> parse |> Option.map (fun x ->  x*2.) |> describe
"foo" |> parse |> Option.map (fun (x:float) ->  x*2.) |> describe

let double xo = 
   
let parse s = // ‘a -> option<float>
    let (succeeded, value) = System.Double.TryParse(string s)
    if succeeded then Some value else None

"42.0" 
|> parse 
|> Option.bind (fun x -> x*2. |> Some) 
|> describe

"foo" 
|> parse 
|> Option.bind (fun x -> x*2. |> Some) 
|> describe


(fun (x:float option) -> x.Value * 2) |> describe

(Some 42.0) |> (fun x -> printfn "%A" x)


let parse s = // ‘a -> option<float>
    let (succeeded, value) = System.Double.TryParse(string s)
    if succeeded then Some value else None

parse "1.0"
parse "foo"



match describeOptionInt with
| Some x -> printfn "the valid value is %A" x
| None -> printfn "the value is None"

open System

let parse s =
    let (succeeded, value) = Double.TryParse(string s)
    if succeeded then Some value else None

"42" |> parseToDouble |> square |> format |> Console.WriteLine // prints:The value is 42.0
"foo" |> parseToDouble |> square |> format |> Console.WriteLine // prints: "Nothing"

let square (something : float option) =
    match something with
    | Some v -> Some (v * v)
    | None -> None
let format = function
| Some v -> $"The value is {v}"
| None -> "Nothing"
"42" |> parseToDouble |> square |> format |> Console.WriteLine // prints:The value is 42.0
"foo" |> parseToDouble |> square |> format |> Console.WriteLine // prints:The value is 42.0

let square x:float = x * x
"42" |> parse |> square |> format |> Console.WriteLine // error square
"42" |> parse
     |> Option.bind (fun x -> square x |> Some)
     |> format
     |> Console.WriteLine



let format = function
    | Some v -> $"{v}"
    | None -> "None"

let someSquare x = square x |> Some


let foo = Some (1.)
Option.bind (fun x -> x * x |> Some) foo

"42" |> parse |> Option.bind (fun x -> square |> Some) |> format |> Console.WriteLine

(*
"foobar" |> parseToDouble |> square |> format |> Console.WriteLine

let square x = x * x
"42" |> parseToDouble |> square

"42" |> parseToDouble |> Option.bind square

let double = function
    | Some v -> v*v
    | _ -> None



Option.bind (fun  o -> parseToDouble o) (Some "42")
Option.bind (fun  o -> parseToDouble o) (Some "foo")



Some "42"
    |> Option.bind 

Option.bind 


let print = function
    | Some v -> $"{v}"
    | None -> "Nothing"

let toNumberAndSquare v =
    Option.bind (fun s -> 
            let (succeeded, value) = Double.TryParse(string s)
            if succeeded then Some value else None) v
    |> Option.bind(fun n -> n * n |> Some)


toNumberAndSquare (Some "1.0")
toNumberAndSquare (Some "foo")



Some "5" |> toNumberAndSquare |> print |> Console.WriteLine
Some "foo" |> toNumberAndSquare |> print |> Console.WriteLine



 let tryParse (input: string) =
     match System.Int32.TryParse input with
     | true, v -> Some v
     | false, _ -> None
 None |> Option.bind tryParse // evaluates to None
 Some "42" |> Option.bind tryParse // evaluates to Some 42
 Some "Forty-two" |> Option.bind tryParse // evaluates to None

let isItSomething = function
    | None -> "nope, it's nothing"
    | Some i -> $"Yes, it is something: {i}"

*)