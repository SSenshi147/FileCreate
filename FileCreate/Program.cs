namespace FileCreate;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");

        const string path = "out.txt";
        if (!File.Exists(path))
        {
            // add the using here, so it won't lock the file after creation
            using var _ =  File.Create(path);
        }

        File.WriteAllText(path, "test");
        var content = File.ReadAllText(path);

        Console.WriteLine(content);
    }
}
