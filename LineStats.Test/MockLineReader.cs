namespace LineStats.Test
{
    internal class MockLineReader : ILineReader
    {
        private readonly string[] _lines;
        private int _lineIndex;

        public MockLineReader(string text)
        {
            _lines = text.Length == 0 ? new string[0] : text.Split('\n');
            _lineIndex = 0;
        }

        public string GetLine()
        {
            if (_lineIndex == _lines.Length) return null;
            var line = _lines[_lineIndex];
            _lineIndex++;
            return line;
        }
    }
}
