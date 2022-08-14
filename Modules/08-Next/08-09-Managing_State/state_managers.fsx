let mutable state = 100.0
let modify action = 
    state <- state -
        match action with
        | "half" -> state / 2.0
        | "small" -> 1.0
        | "large" -> 10.0
        | _ -> 0.0
modify "half"
modify "large"
modify "small"
state

//===========================================================================================

let modify state action = 
    match action with
    | "half" -> state / 2.0
    | "small" -> state - 1.0
    | "large" -> state - 10.0
    | _ -> state
let initialState = 100.0
let newState1 = modify initialState "half"
let newState2 = modify newState1 "large"
let endState = modify newState2 "small"
endState

//===========================================================================================

let modify state action = 
    match action with
    | "half" -> state / 2.0
    | "small" -> state - 1.0
    | "large" -> state - 10.0
    | _ -> state

let mutable currentState = 100.0

while true do
    let action = System.Console.ReadLine()
    let newState = modify currentState action
    currentState <- newState

//===========================================================================================

let main () =
    // tail recursive loop solely for repeating a task with a new state
    let rec loop state =
        let action = System.Console.ReadLine()
        let newState = modify state action
        loop newState // tail recurse with the new state
    loop 100.0 // start recursive loop with initial state

//===========================================================================================

type Person = { ID:int; Name:string }
type PersonRepository = { FindById: int -> Person; Update: Person -> bool }
let updatePersonName personRepository personId newName=
    let user = personRepository.FindById personId
    let updatedUser = { user with Name = newName }
    personRepository.Update updatedUser

//===========================================================================================

