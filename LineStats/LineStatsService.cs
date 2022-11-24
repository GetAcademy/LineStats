namespace LineStats
{
    internal class LineStatsService
    {
        public static Stats Count(string filename, string word)
        {
            var total= 0;
            var exactCount = 0;
            var ignoreCaseCount = 0;
            var wordUpper = word.ToUpper();
            using var fileStream = new FileStream(filename, FileMode.Open);
            using var reader = new StreamReader(fileStream);

            string line = null;
            while((line = reader.ReadLine())!=null)
            {
                total++;
                if (line.Contains(word)) exactCount++;
                if (line.ToUpper().Contains(wordUpper)) ignoreCaseCount++;
            }
            return new Stats(total, exactCount, ignoreCaseCount);

        }
    }
}
