using System.Net;

namespace LineStats
{
    internal class WebLineReader : ILineReader
    {
        private readonly StreamReader _reader;

        public WebLineReader(string url)
        {
            var webClient = new WebClient();
            var fileStream = webClient.OpenRead(url);
            _reader = new StreamReader(fileStream);
        }

        public string GetLine()
        {
            return _reader.ReadLine();
        }
    }
}
