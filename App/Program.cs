
List<int> numeros = new List<int> { 1, 2, 3};

var lista = numeros.Select(x => x + 1);

foreach (var i in lista)
    Console.WriteLine(i);
