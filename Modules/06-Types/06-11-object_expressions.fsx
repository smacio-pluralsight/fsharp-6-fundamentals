let oe = { new System.Object() with member x.ToString() = "F#" }
System.Console.WriteLine(oe)

//================================================================================

type IPrintable = abstract member Print : unit -> unit

let makePrintable (x: int) (y: float) =
    { new IPrintable with
        member this.Print() = printfn "%d %f" x y }

let x = makePrintable 1 2.0
x.Print ()

//================================================================================

