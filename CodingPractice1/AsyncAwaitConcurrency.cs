using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiMapConcept
{
    public class AsyncAwaitConcurrency
    {
        public AsyncAwaitConcurrency()
        {
            

        }

        public async Task<(int length, long elapsedMilliseconds)> ProcessURL(string url, HttpClient client)
        {
            var sw = Stopwatch.StartNew();
            var httpresponse = await client.GetAsync(url);

            //retrieve website content
            byte[] content = await httpresponse.Content.ReadAsByteArrayAsync();

            return (content.Length, sw.ElapsedMilliseconds);
        }



        public List<string> SetupURLS() =>
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
    }
}
