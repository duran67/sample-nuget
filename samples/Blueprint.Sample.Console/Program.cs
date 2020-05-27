using System;
using Blueprint.Sample.CSharpLib;

class Program
{
    static void Main(string[] args)
    {
        var world = new World();
        var text = world.Hello();
        Console.WriteLine(text);
    }
}

