using System.Net;

namespace LineStats
{
    internal class WebDemo
    {
        public static void Run()
        {
            var webClient = new WebClient();
            using var stream = webClient.OpenRead("https://www.vg.no/");
            using var reader = new StreamReader(stream);
            string line = null;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
