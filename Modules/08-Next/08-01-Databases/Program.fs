module DbApp

open Microsoft.EntityFrameworkCore

open Domain
open DatabaseInit
open DataContext
open PersonRepository

initDb()

let optionsBuilder = new DbContextOptionsBuilder<PersonDbContext>();
optionsBuilder.UseSqlite("Data Source=data.db") |> ignore
let context = new PersonDbContext(optionsBuilder.Options)

put context { Id = 1; FirstName = "John"; LastName = "Doe" }
printfn "%A" (get context 1)
