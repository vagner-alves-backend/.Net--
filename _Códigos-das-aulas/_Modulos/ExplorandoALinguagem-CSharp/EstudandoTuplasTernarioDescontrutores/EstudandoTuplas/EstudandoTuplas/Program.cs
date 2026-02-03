Console.Clear();

var (name, idade) = ("vágner", 20);
Console.WriteLine(
    $"Name: {name}\n"+
    $"Idade: {idade}\n"+
    "--------------------"
);

var tuplaVar = (name: "Sofia", idade: 19);
Console.WriteLine(
    $"Name: {tuplaVar.name}\n"+
    $"Idade: {tuplaVar.idade}\n"+
    "--------------------"
);

(string nome, int age) = ("Lucas", 24);
Console.WriteLine(
    $"Name: {nome}\n"+
    $"Idade: {age}\n"+
    "--------------------"
);

(string nome, int age) tupla = ("Amanda", 18);
Console.WriteLine(
    $"Name: {tupla.nome}\n"+
    $"Idade: {tupla.age}\n"+
    "--------------------"
);
