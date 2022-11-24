namespace LineStats
{
    public class DummyService
    {
        public static int DoSomething(int a)
        {
            try
            {
                var result = 5;
                if (a < 0)
                {
                    result *= -a;
                    string s = null;
                    var x = s.Length;
                }
                else
                {
                    result *= a;
                }

                if (a % 2 == 0)
                {
                    result++;
                }
                else
                {
                    result -= 1000 / a;
                }
                return result;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }

        }
    }
}
