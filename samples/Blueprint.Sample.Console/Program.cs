using System;
using Blueprint.Sample.CSharpLib;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        var world = new World();
        JsonConvert.SerializeObject(world, Formatting.Indented);
        var text = world.Hello();
        Console.WriteLine(text);
    }
}

