let map mapper items =
    [for value in items -> mapper value]

map (fun x -> x*x) [1..3]

List.map (fun x -> x*x) [1..3]

//================================================================================

type Person = { Name: string; Age: int }
let people = [{ Name="John"; Age=35 }; { Name="Jane"; Age = 30 }]
List.map (fun person -> person.Name) people

//================================================================================

let filter f list=
    let rec loop f list accumulator=
        match list with
        | [] -> accumulator
        | head :: tail -> 
            if f head then loop f tail (accumulator @ [head])
                      else loop f tail accumulator
    loop f list []
filter (fun person -> person.Age < 32) people

List.filter (fun person -> person.Age < 32) people

//================================================================================

let aggregate f start items  =
    let rec loop f accumulator items =
        match items with
        | [] -> accumulator
        | head :: tail -> loop f (f accumulator head) tail 
    loop f start items
aggregate (+) 0 (List.map (fun person -> person.Age) people)

List.fold (+) 0 (List.map (fun person -> person.Age) people)
List.sum (List.map (fun person -> person.Age) people)

//================================================================================

let getLogger medium =
    let log writer text = 
        writer text
        text
    match medium with
    | "console" -> log (fun (text:string) -> System.Console.WriteLine(text)) 
    | "file" -> log (fun text -> System.IO.File.AppendAllLines("log.txt", [text]))
    | _ -> fun text -> text

//================================================================================

let consoleLogger = getLogger "console" 
let fileLogger = getLogger "file"

consoleLogger "Console only"
fileLogger "File only"

let composite = fileLogger >> consoleLogger
composite "Goes to console and file"
