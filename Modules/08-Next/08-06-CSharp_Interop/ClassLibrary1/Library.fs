namespace MyFsharpLib

type Record = { Name: string; Age: int }
type Abc =
    | A
    | B of double
    | C of Record
