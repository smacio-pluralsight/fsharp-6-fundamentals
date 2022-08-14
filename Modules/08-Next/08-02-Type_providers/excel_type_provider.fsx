//#r "nuget: ExcelProvider"
#r "ExcelProvider"
open FSharp.Interop.Excel

type MyExcelProvider = ExcelFile<"data.xlsx">
let file = new MyExcelProvider()
let row = file.Data |> Seq.head
(row.Date, row.Item)