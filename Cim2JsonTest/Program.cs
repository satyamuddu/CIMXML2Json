// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string file = "esca60_gev_original.xml";

string filePath = Path.Combine(Environment.CurrentDirectory, "data", file);
if (File.Exists(filePath))
{
    CimXml2Json.TransformCim2Json transformCim2Json = new CimXml2Json.TransformCim2Json();
    transformCim2Json.Parse(filePath);
    transformCim2Json.ToJson();
    string outputPath = Path.Combine(Environment.CurrentDirectory, "output", "ratings.json");
    transformCim2Json.WriteToFile(outputPath);
}
else
{
    Console.WriteLine($"File not found: {filePath}");
}
