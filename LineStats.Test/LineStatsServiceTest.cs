using Moq;

namespace LineStats.Test
{
    public class LineStatsServiceTest
    {
        [Test]
        public void Test1()
        {
            // arrange
            var mock = new MockLineReader("Hei på deg\n er du glad\n henter du bla bla banl");
            var lineStatsService = new LineStatsService(mock);

            // act
            var stats = lineStatsService.Count("er");

            // assert
            Assert.AreEqual(2, stats.LineCountExact);
            Assert.AreEqual(2, stats.LineCountIgnoreCase);
            Assert.AreEqual(3, stats.TotalLines);
        }

        [Test]
        public void Test2()
        {
            // arrange
            var mock = new MockLineReader("");
            var lineStatsService = new LineStatsService(mock);

            // act
            var stats = lineStatsService.Count("er");

            // assert
            Assert.AreEqual(0, stats.LineCountExact);
            Assert.AreEqual(0, stats.LineCountIgnoreCase);
            Assert.AreEqual(0, stats.TotalLines);
        }

        [Test]
        public void Test3()
        {
            // arrange
            var mock = new MockLineReader("er\n ER\n eR\n Er");
            var lineStatsService = new LineStatsService(mock);

            // act
            var stats = lineStatsService.Count("er");

            // assert
            Assert.AreEqual(1, stats.LineCountExact);
            Assert.AreEqual(4, stats.LineCountIgnoreCase);
            Assert.AreEqual(4, stats.TotalLines);
        }

        [Test]
        public void Test2moq()
        {
            // arrange
            var mock = new Mock<ILineReader>();
            mock.Setup(lr => lr.GetLine())
                .Returns((string) null);
            var lineStatsService = new LineStatsService(mock.Object);

            // act
            var stats = lineStatsService.Count("er");

            // assert
            Assert.AreEqual(0, stats.LineCountExact);
            Assert.AreEqual(0, stats.LineCountIgnoreCase);
            Assert.AreEqual(0, stats.TotalLines);
        }

        [Test]
        public void Test1moq()
        {
            // arrange
            var mock = new Mock<ILineReader>();
            mock.SetupSequence(lr => lr.GetLine())
                .Returns("Hei på deg Erlend!")
                .Returns("Bla bla bla er")
                .Returns((string) null);
            var lineStatsService = new LineStatsService(mock.Object);

            // act
            var stats = lineStatsService.Count("er");

            // assert
            Assert.AreEqual(1, stats.LineCountExact);
            Assert.AreEqual(2, stats.LineCountIgnoreCase);
            Assert.AreEqual(2, stats.TotalLines);
        }
    }
}