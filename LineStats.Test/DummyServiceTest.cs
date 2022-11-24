namespace LineStats.Test
{
    internal class DummyServiceTest
    {
        [Test]
        public void Test1()
        {
            DummyService.DoSomething(2);
        }

        [Test]
        public void Test2()
        {
            DummyService.DoSomething(-1);
        }
    }
}
