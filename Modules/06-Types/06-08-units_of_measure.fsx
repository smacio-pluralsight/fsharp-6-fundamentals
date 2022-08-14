[<Measure>] type cm
[<Measure>] type inch
[<Measure>] type m
[<Measure>] type sec
[<Measure>] type kg
[<Measure>] type lbs

//================================================================================

let x = 1<cm>
let y = 1.0<cm>
let z = 1.0m<cm> 

let x2 = x + 3<cm>

let x_m = 1<m>

x = x_m

//================================================================================

let distance = 1.0<m>
let time = 2.0<sec>
let speed = 2.0<m/sec>
let acceleration = 2.0<m/sec^2>
let force = 5.0<kg m/sec^2>

//================================================================================

[<Measure>] type N = kg m/sec^2
let force1 = 5.0<kg m/sec^2>
let force2 = 5.0<N>
force1 = force2 // true

//================================================================================

[<Measure>] type degC
[<Measure>] type degF
let convertDegCToF c =
    c * 1.8<degF/degC> + 32.0<degF>
// test
convertDegCToF 0.0<degC>

let centimetersPerMeter = 100.0<cm/m>
let distanceInCentimeters = 2.0<m> * centimetersPerMeter
