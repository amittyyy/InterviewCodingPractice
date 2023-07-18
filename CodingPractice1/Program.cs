// See https://aka.ms/new-console-template for more information
using CodingPractice;
using MultiMapConcept;
using System.Collections;

Console.WriteLine("Hello, World!");


//MultiMaps mps = new MultiMaps();

//mps.addList(1, "once in lifetime");
//mps.addList(2, "twihce in lifetime");
//mps.addList(1, "once again");

//foreach(object o in mps.Keys())
//{
//    Console.WriteLine(o.ToString()); ;
//}


//ArrayList elements = mps.FindByKey(1);

//foreach (object item in elements)
//{
//    Console.WriteLine(item.ToString());
//}


//var data = mps.FindByKey(1);


//Using Generic 

//DicGentMultiMap<bool> dict = new DicGentMultiMap<bool>();

//dict.Add("amit", true);
//dict.Add("isfemale", false);
//dict.Add("amit", false);

//foreach(string item in dict.Keys())
//{
//	foreach (var data in dict.FindByKey(item))
//	{
//		Console.WriteLine( " Multi Map key = " + item + "     Values = " + data);
//	}
//}


//AsyncAwaitConcurrency conc = new AsyncAwaitConcurrency();

//HttpClient httpClient = new HttpClient();

//var urls = conc.SetupURLS();

//List<Task<(int length, long milliSecond)>> download = urls.Select(
//    url =>
//    {
//        return conc.ProcessURL(url, httpClient);
//    }).ToList();

//while (download.Count > 0)
//{
//    // Identify the first task that completes.
//    Task<(int length, long milisecond)> firsttask = await Task.WhenAny(download);

//    //do not let process more than once
//    download.Remove(firsttask);

//    // Await the completed task.
//    var (length, milisecond) = await firsttask;

//    // add a new task 
//    //downloadTasks.Add(ProcessURL("https://davemateer.com", httpClient));
//    Console.WriteLine($"Length of download: {length} in {milisecond}ms");

//}

// Reverse String 
//Console.WriteLine( ReverseString.reverseString("amittimalsina"));
//Console.WriteLine(ReverseString.reverseStringLinq("amittimalsina"));

//Palindrome 
//Console.WriteLine(Palindrome.palindromes("amistima"));
//Console.WriteLine(Palindrome.isPalindrome("amit tima"));
//Console.WriteLine(Palindrome.isPalindromeInt(231432));

//Occurance of Char in String
//Console.WriteLine(OccuranceCharOfString.CountOcurance('a', "amittaaaaAimalsina"));
//Console.WriteLine(OccuranceCharOfString.countOccuranceLinq('a', "amittaaaaAimalsina"));
//Console.WriteLine(OccuranceCharOfString.countOccuranceRecursive('a', "amittaaaaAimalsina"));

//Anagram 

//Console.WriteLine(anagram.isAnagram("amit", "tima"));
//Console.WriteLine(anagram.isAnagram("amitt", "atima"));


//Fibonacci Serise
//int[] arrayInt = new int[] {0,1,2,3,5,8,13,21};

//Console.WriteLine(FibonacciSeries.fibonacciSer(10));
//Console.WriteLine(FibonacciSeries.generateFibonacci(21));

//Is Prime Condition
Console.WriteLine(PrimeNumbers.isPrimeLinq(17));
Console.WriteLine(PrimeNumbers.isPrimeFor(17));

Console.Read();


