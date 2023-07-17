// See https://aka.ms/new-console-template for more information
using MultiValuesDictionary_ServiceTitan;

Console.WriteLine("Hello, World!");


Console.WriteLine("Start Our Application");

var dictionary = new MultiValueDictionary<int, string>();
dictionary.Add(1, "value1");
dictionary.Add(1, "value2");
dictionary.Add(2, "value3");

foreach (var value in dictionary)
{
    Console.WriteLine(value.Key);
    Console.WriteLine(value.Value);

}

Console.ReadLine();