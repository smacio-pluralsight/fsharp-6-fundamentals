module DataContext

open Microsoft.EntityFrameworkCore
open Domain

type PersonDbContext = 
    inherit DbContext 

    new() = { inherit DbContext() }

    new(options: DbContextOptions<PersonDbContext>) = 
        { inherit DbContext(options) }

    override __.OnModelCreating modelBuilder = 
        modelBuilder.Entity<Person>() |> ignore

    [<DefaultValue>] 
    val mutable person:DbSet<Person> 

    member this.Person 
        with get() = this.person 
        and  set p = this.person <- p
