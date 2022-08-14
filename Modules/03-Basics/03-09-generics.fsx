// implicit, inferred by compiler
let swapImplicit (a, b) = (b, a)

let swapExplicit ((a: 'a), (b: 'b)) = (b, a)

//================================================================================

type GenericRecord<'a, 'b> = // C# would be GenericRecord<T,V>
    {
        Field1: 'a;
        Field2: 'b; 
    }

let record1 = { Field1=1.0; Field2=2 }
let record2 = { Field1="x"; Field2=true }

