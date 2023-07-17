// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Diagnostics;

Console.WriteLine("Hello, World!");

var httpClient = new HttpClient();

var urlConnections = SetupConnection();

List<Task<(int length, long miliSecond)>> downloadTask = urlConnections.Select(
    url =>
    {
        return ProcessURL(url, httpClient);
    }
).ToList();


//Create a loop to process task one at a time 
while(downloadTask.Count > 0)
{
    Task<(int length, long miliSecond)> firstTask = await Task.WhenAny(downloadTask);

    //Remove the task when you done
    downloadTask.Remove(firstTask);

    //await for the completion of task
    var (length, miliSecond) = await firstTask;

    Console.WriteLine($"Length of download: {length} in {miliSecond}ms");
}


static List<string> SetupConnection() =>
    new List<string>
    {
        "https://msdn.microsoft.com",
        "https://msdn.microsoft.com/library/windows/apps/br211380.aspx",
        "https://msdn.microsoft.com/library/hh290136.aspx",
        "https://msdn.microsoft.com/library/dd470362.aspx",
        "https://msdn.microsoft.com/library/aa578028.aspx",
        "https://msdn.microsoft.com/library/ms404677.aspx",
        "https://msdn.microsoft.com/library/ff730837.aspx"
    };

async Task<(int length, long miliSecond)> ProcessURL(string url, HttpClient client)
{
    var sw = Stopwatch.StartNew();

    var httpResponse = await client.GetAsync(url);

    byte[] content = await httpResponse.Content.ReadAsByteArrayAsync();

    return (content.Length, sw.ElapsedMilliseconds);
}
