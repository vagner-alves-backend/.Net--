bool? isNull = null;
//isNull.HasValue == Nesse cenario se o valor for null, ele irá retornar false.

// if (!isNull.HasValue)
// {
//     Console.WriteLine("Value null.");
// } else
// {
//     Console.WriteLine($"Value is {isNull}.");
// }

Console.WriteLine($"O valor é {(isNull.HasValue ? isNull: "Null")}.");
