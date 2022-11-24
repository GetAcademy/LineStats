namespace LineStats
{
    internal class KeyboardLineReader : ILineReader
    {
        public string GetLine()
        {
            var line = Console.ReadLine();
            return line.Length == 0 ? null : line;
        }
    }
}
