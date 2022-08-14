module DbApp

open Domain
open CompositionRoot
open DatabaseInit

initDb()

putPerson { Id = 1; FirstName = "John"; LastName = "Doe" }
let person = getPerson 2
printfn "%A" person
