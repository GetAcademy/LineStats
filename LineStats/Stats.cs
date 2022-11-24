namespace LineStats
{
    internal class Stats
    {
        public int TotalLines { get; set; }
        public int LineCountExact { get; set; }
        public int LineCountIgnoreCase { get; set; }

        public override string ToString()
        {
            return $"Ant linjer: ${TotalLines} Ant med eksakt treff: {LineCountExact} Ant med treff sett bort fra casing: {LineCountIgnoreCase}"
        }
    }
}
