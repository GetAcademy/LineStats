namespace LineStats
{
    internal class LineStatsService
    {
        public static Stats Count(string filename)
        {
            var totalLines = 0;
            var linesWithExactWordCount = 0;
            var linesWithWordIgnoreCaseCount = 0;

            foreach (string line in System.IO.File.ReadLines(@"c:\test.txt"))
            {
                System.Console.WriteLine(line);
                counter++;
            }
        }
    }
}
