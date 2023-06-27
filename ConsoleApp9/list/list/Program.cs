List<int> numbers = new List<int>() { 1, 4, 5, 2, 3, 6, 7, 213, 32, 4214 };
numbers.Sort();
Console.Write("sort list: ");
foreach (int number in numbers)
{
    Console.Write("\t"+number);
}
Console.WriteLine();
var result = numbers.Where(x => x % 2 == 0).ToList();
Console.Write("even numbers: ");
foreach (int number in result)
{
    Console.Write("\t"+number);
}
Console.WriteLine();
var result2 = numbers.Where(x => x > 42).ToList();
Console.Write("more then 42: ");
var result3 = numbers.Sum();
Console.Write("\t" + result3);
Console.WriteLine();


List<string> sTring = new List<string>() { "eqwe xcsad23", "sadxvThdfqw23er", "Sdsad33xzc" };
var result5 = sTring.FindAll(x => !x.Contains(" ")).ToList();
Console.Write("string without space:  ");
foreach (var t in result5)
{
    Console.Write("\t"+t);
}
Console.WriteLine();
var result33 = sTring.FindAll(x => Char.IsUpper(x.First())).ToList();
foreach (var t in result33)
{
    Console.Write($"string have UpperSumvol: "+t);
}
Console.WriteLine();

Console.WriteLine($"string have numbers: {sTring.Any(x => x.Any(Char.IsDigit))}");


var substring = "qwe";
var result4 = sTring.FindAll(x => x.Contains(substring)).ToList();
Console.Write("sting have substring: ");
foreach (var t in result4)
{
    Console.Write("\t"+t);
}