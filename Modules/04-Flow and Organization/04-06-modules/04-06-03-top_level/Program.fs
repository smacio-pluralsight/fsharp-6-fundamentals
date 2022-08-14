// Program.fs

printfn "%A %A %A %A %A"
    Mathematics.addResult
    (Mathematics.add 1 2)
    (Mathematics.FloatingPoint.add 2. 3.)
    Mathematics.AnotherModule.value1    
    Mathematics.AnotherModule.value2