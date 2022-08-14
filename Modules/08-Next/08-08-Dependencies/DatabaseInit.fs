module DatabaseInit

open System.IO
open System.Data.SQLite

let initDb () =
    if File.Exists("data.db") then 
        File.Delete("data.db")

    let createSql = 
        """
        BEGIN TRANSACTION;
            CREATE TABLE IF NOT EXISTS 'Person' (
	        'Id'	INTEGER PRIMARY KEY AUTOINCREMENT,
	        'FirstName'	TEXT NOT NULL,
	        'LastName'	TEXT NOT NULL
            );
        COMMIT;"""

    let connection = new SQLiteConnection("Data Source=data.db")
    connection.Open()
    let command = new SQLiteCommand(createSql, connection)
    command.ExecuteNonQuery() |> ignore
    |> ignore
    ()