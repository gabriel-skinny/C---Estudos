using System;

Console.WriteLine(Teste.GetName(2));


class Teste {
    private static string[] names = { "Spencer", "Sally", "Doug" };
    public static string GetName(int ID){
    if (ID < names.Length)
        return names[ID];
    else
        return String.Empty;
    }
}


var mane = new Mane("teste");

Console.WriteLine(mane.teste);
Console.WriteLine(mane.teste);

mane.teste = "tester";
Console.WriteLine(mane.teste);

public class Mane {
    public string teste {get; set;}

    public Mane(string name) {
        teste = name;
    } 
}


public struct Coords {
    public int x, y;

    public Coords(int i, int b)
    {
        x = i;
        y = b;
    }
}








