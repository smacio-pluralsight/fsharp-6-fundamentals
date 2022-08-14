type Line = class
    val X1 : float
    val Y1 : float
    val X2 : float
    val Y2 : float
    
    new (x1, y1, x2, y2) as this =
        { X1 = x1;Y1 = y1;X2 =x2;Y2 = y2;}
        then
            printfn " Creating Line: {(%g, %g), (%g, %g)}\nLength: %g"
                this.X1 this.Y1 this.X2 
                this.Y2 this.Length
    member x.Length =
        let sqr i = i * i
        sqrt(sqr(x.X1 - x.X2) + 
           sqr(x.Y1 - x.Y2) )
end

let aLine = new Line(1.0, 1.0, 4.0, 5.0)
aLine.Length  // val it: float = 5.0

//================================================================================

type vec2(x: float, y: float) =
    member r.X = x
    member r.Y = y
    member r.Length = sqrt(r.X * r.X + 
                           r.Y * r.Y)

//================================================================================

type vec2 = { mutable x:float; mutable y:float} with
    member r.Length
        with get () =
            sqrt(r.x * r.x + r.y * r.y)
        and set len =
            let s = len / r.Length
            r.x <- s * r.x
            r.y <- s * r.y
