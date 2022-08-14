module PersonRepository
open System.Linq
open DataContext
open Domain

let put (context:PersonDbContext) (person:Person) =
    context.Person.Add(person) |> ignore
    context.SaveChanges true |> ignore

let get (context: PersonDbContext) id =
    try
        Some (context.Person.First(fun p -> p.Id = id))
    with e -> None