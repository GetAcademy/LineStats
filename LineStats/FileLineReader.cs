namespace LineStats
{
    internal class FileLineReader : ILineReader
    {
        private StreamReader _reader;

        public FileLineReader(string filename)
        {
            var fileStream = new FileStream(filename, FileMode.Open);
            _reader = new StreamReader(fileStream);
        }

        public string GetLine()
        {
            return _reader.ReadLine();
        }
    }
}
