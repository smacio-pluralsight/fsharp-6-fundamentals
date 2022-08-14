type ISprintable =
    abstract member Print : format:string -> unit

type IRepository<'T> = {
    Get: int -> Result<'T, string>
    Put: 'T -> Result<'T, string>
}

//================================================================================

type IPrintable =
   abstract member Print : unit -> unit

type SomeClass1(x: int, y: float) =
   interface IPrintable with
      member this.Print() = printfn "%d %f" x y

let x1 = new SomeClass1(1, 2.0)
(x1 :> IPrintable).Print()

//================================================================================

type INumericFSharp =
    abstract Add: x: int -> y: int -> int

type INumericDotNet =
    abstract Add: x: int * y: int -> int

