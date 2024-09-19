using ShareProject;
namespace AggregateOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunAggregate();
            //RunCount();
            //RunMaxAndMaxBy();
            //RunMinAndMinBy();
            SumAndAverage();
        }
        private static void RunAggregate()
        {
            string[] names = { "Ali", "Salem", "Abeer", "Reem", "Jalal" };
            var result = names.Aggregate((a, b) => $"{a} , {b}");
            Console.WriteLine(result);
            var quiz = QuestionBank.All;
            var result2 = quiz.Aggregate((a, b) => a.Title.Length > b.Title.Length ? a : b);
            Console.WriteLine("longest question is " + result2);
        }
        private static void RunCount()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(0, 10));
            var result = quiz.Count();
            Console.WriteLine(result);
            var result2 = quiz.Count(x => x.Marks < 2);
            Console.WriteLine(result2);
            var result3 = quiz.Where(x => x.Marks < 2).Count();
            Console.WriteLine(result3);
        }
        private static void RunMaxAndMaxBy()
        {
            var q = QuestionBank.All;
            var result = q.Max(x => x.Marks);
            Console.WriteLine(result);
            var result2 = q.MaxBy(x => x.Marks);
            Console.WriteLine(result2);
        }
        private static void RunMinAndMinBy()
        {
            var q = QuestionBank.GetQuestionRange(Enumerable.Range(0, 10));
            var result = q.Min(x => x.Marks);
            Console.WriteLine(result);
            var result2 = q.MinBy(q => q.Marks);
            Console.WriteLine(result2);
        }
        private static void SumAndAverage()
        {
            var quiz = QuestionBank.GetQuestionRange(Enumerable.Range(0, 10));
            var result=quiz.Sum(x=> x.Marks);
            Console.WriteLine(result);
            var result2=quiz.Average(x=> x.Marks);
            Console.WriteLine(result2);
        }

    }
}
