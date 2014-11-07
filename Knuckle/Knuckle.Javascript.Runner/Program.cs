namespace Knuckle.Javascript.Runner
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var jsCommand = System.Console.ReadLine();
            JavascriptExecuter.Execute(jsCommand);
        }
    }
}
