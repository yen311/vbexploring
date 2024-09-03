internal class Program
{
    private static void Main(string[] args)
    {
        VBLib.Demos vb = new VBLib.Demos();
        var outputs = vb.LoadFile();

        Console.WriteLine("VB.NET methods");
        foreach (var output in outputs)
        {
            System.Console.WriteLine(output);
        }

        Console.WriteLine();
        Console.WriteLine();

        CSharpLib.Demos cs = new CSharpLib.Demos();
        var outputs2 = cs.LoadFile();

        Console.WriteLine("C# methods");
        foreach (var output in outputs2)
        {
            System.Console.WriteLine(output);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}