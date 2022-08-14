type DaysOfWeek =  Sunday | Monday | Tuesday | Wednesday | Friday | Saturday

let day = Sunday; // DaysOfWeek

day = Sunday 
day = Monday 

//================================================================================

type DaysOfWeek = 
    | Sunday 
    | Monday  
    | Tuesday 
    | Wednesday  
    | Friday  
    | Saturday

//================================================================================

type Shape =
    | Rectangle of width : float * height : float
    | Circle of radius : float
    | Triangle of s1:float * s2:float * s3:float

let rect = Rectangle(width = 1, height = 2)
let circ = Circle (1.0)
let tri = Triangle(1., 2., 3.)

//================================================================================

let perimeter shape = 
    match shape with
    | Rectangle (width, length) -> 2. * (width + length)
    | Circle radius -> 2. * System.Math.PI * radius
    | Triangle (s1, s2, s3) -> s1 + s2 + s3
perimeter rect, perimeter circ, perimeter tri

//================================================================================

let isSquare shape = 
    match shape with
    | Rectangle (width, height) -> width=height
    | _ -> false

isSquare rect, isSquare (Rectangle(width=1., height=1.)), isSquare circ

//================================================================================

let (Rectangle (width, height)) = rect

type BinaryTree = 
    | Leaf of int
    | Node of BinaryTree * BinaryTree;;

//================================================================================

let root = Node(Leaf(1), Node(Leaf(2), Leaf(3)));;

let sum tree=
    let rec walk current accum =
        match current with
        | Node (left, right) -> (walk left accum) + (walk right accum)
        | Leaf value -> accum + value
    walk tree 0
sum root