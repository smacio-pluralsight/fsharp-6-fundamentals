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

//================================================================================

let parse s = 
    let (succeeded, value) = System.Double.TryParse(string s)
    if succeeded then Some value else None

parse "1.0"
parse "foo"

//================================================================================

let describe = function
    | Some x -> $"The value is {x}"
    | None -> $"There is no value"

"42.0" |> parse |> describe
"foo" |> parse |> describe

//================================================================================

"42.0" |> parse |> Option.map (fun x ->  x*2.) |> describe
"foo" |> parse |> Option.map (fun (x:float) ->  x*2.) |> describe

//================================================================================

"42.0" 
|> parse 
|> Option.bind (fun x -> x*2. |> Some) 
|> describe

"foo" 
|> parse 
|> Option.bind (fun x -> x*2. |> Some) 
|> describe

