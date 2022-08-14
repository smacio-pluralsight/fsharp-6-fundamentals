module CompositionRoot
open Microsoft.EntityFrameworkCore
open DataContext

let configureSqliteContext = 
    (fun () ->
        let optionsBuilder = new DbContextOptionsBuilder<PersonDbContext>();
        optionsBuilder.UseSqlite("Data Source=data.db") |> ignore
        new PersonDbContext(optionsBuilder.Options)
    )
let getContext = configureSqliteContext()
let getPerson = PersonRepository.get getContext
let putPerson = PersonRepository.put getContext
