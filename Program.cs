namespace LineComparisionProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welome To Line Comparision Problem");

            LineComparision lineComparision = new LineComparision();
            lineComparision.checkLength();
            lineComparision.checkEquality();           
        }
    }
       
}