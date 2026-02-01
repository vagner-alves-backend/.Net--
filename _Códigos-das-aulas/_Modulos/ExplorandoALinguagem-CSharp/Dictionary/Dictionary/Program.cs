Dictionary<string, string> pessoas = new()
{
    {"123", "Vágner"},
    {"234", "Sofia"},
    {"345", "Laura"}
};

foreach (KeyValuePair<string, string> pessoa in pessoas)
{
    Console.WriteLine($"{pessoa.Value} - {pessoa.Key}");
}

Console.WriteLine("------------------------");
pessoas.Remove("345"); // Está removendo a Laura
pessoas["234"] = "Sabrine";

foreach (KeyValuePair<string, string> pessoa in pessoas)
{
    Console.WriteLine($"{pessoa.Value} - {pessoa.Key}");
}
