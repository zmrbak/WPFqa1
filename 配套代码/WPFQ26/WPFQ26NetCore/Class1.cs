namespace WPFQ26NetCore
{
    internal class Class1
    {
        public void Test()
        {
            Stopwatch stopwatch= new Stopwatch();
            stopwatch.Start();

            Thread.Sleep(2000);
            stopwatch.Stop();

            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
