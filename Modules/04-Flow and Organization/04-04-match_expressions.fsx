let describe x =
    match x with
    | 0 -> "Zero"
    | 1 -> "One"
    | _ -> "Neither zero or one"

describe 0 // val it: string = "Zero"
describe 1 // val it: string = "Neither zero nor three"
describe 2 // val it: string = "Neither zero nor three"
describe 3 // val it: string = "Three"

//================================================================================

// pattern matching function syntax
let describe = function
    | 0 -> "Zero"
    | 1 -> "One"
    | _ -> "Neither zero or one"

//================================================================================

// OR pattern
let describe = function
    | 0 | 1 | 2 -> "Found 0, 1, or 2!"
    | a -> $"Something else {a}?"

describe 0
describe 1
describe 2
describe 3

//================================================================================

let detectZeroAND = function
    | (0, 0) -> "Both values zero."
    | (var1, var2) & (0, _) -> $"First value is 0 in ({var1}, {var2})" 
    | (var1, var2)  & (_, 0) -> $"Second value is 0 in ({var1}, {var2})"
    | _ -> "Both nonzero."
detectZeroAND (0, 0)
detectZeroAND (1, 0)
detectZeroAND (0, 10)
detectZeroAND (10, 15)

//================================================================================

// CONS and "as" patterns
let head::tail = [1;2;3;4]
let h1::(h2::t) = [1;2;3]
let h1::(h2::_ as t) = [1;2;3]

//================================================================================

let detectZeroAND point =
    match point with
    | (0, 0) -> printfn "Both values zero."
    | (var1, var2) & (0, _) -> printfn "First value is 0 in (%d, %d)" var1 var2
    | (var1, var2)  & (_, 0) -> printfn "Second value is 0 in (%d, %d)" var1 var2
    | _ -> printfn "Both nonzero."
detectZeroAND (0, 0)
detectZeroAND (1, 0)
detectZeroAND (0, 10)
detectZeroAND (10, 15)

//================================================================================

let rec pairs = function // val pairs: _arg1: 'a list -> ('a * 'a) list
    | h1::(h2::_ as t) -> (h1, h2) :: pairs t
    | _ -> []
pairs [1;2;3] 

//================================================================================

// return positive values in list
let rec positive = function
    | [] -> []
    | h::t when h<0 -> positive t
    | h::t -> h::positive t

positive [-2..2] 

//================================================================================

// only works in a WinForms app project

open System.Windows.Forms

let RegisterControl(control:Control) =
    match control with
    | :? Button as button -> button.Text <- "Registered."
    | :? CheckBox as checkbox -> checkbox.Text <- "Registered."
    | _ -> ()
    