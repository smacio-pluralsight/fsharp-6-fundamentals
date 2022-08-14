using MyFsharpLib;

var aDU = Abc.NewC(new Record("John", 55));

var result = aDU switch {
    Abc.B v => $"{v}",
    Abc.C r  => $"Name: {r.Item.Name} Age: {r.Item.Age}",
    _ => "Is an A"
};

Console.WriteLine(result);
