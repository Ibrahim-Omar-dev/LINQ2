namespace Extensionmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = Repository.Employees;
            var page = 2;
            var pageSize = 4;
            // page 1 = Skip(0)
            //var page1 = employees.Skip((page - 1) * pageSize).Take(pageSize);

            var page2x4 = emp.Paginate(page, pageSize);
            //page2x4.Print("page #2  [4 emps]");

            var page1x10 = emp.Paginate();
            //page1x10.Print("page #1  [10 emps]");

            var page7x10 = emp.Paginate(7);
            //page7x10.Print("page #7  [10 emps]");

            var page1x7 = emp.Paginate2(null, 7);
            //page1x7.Print("page #1  [7 emps]");

            var page1x7Covered = emp.whereWithPaginate(x => x.HasHealthInsurance, 1, 7);
            //page1x7Covered.Print("page #1  [7 covered emps]");

            var randomEmployee = emp.Random(x => true);
            Console.WriteLine("Random Employee");
            Console.WriteLine(randomEmployee);

            var randomEmployeeWithoutPensionPlan = emp.Random(x => !x.HasPensionPlan);
            Console.WriteLine("Random Employee without pension plan");
            Console.WriteLine(randomEmployeeWithoutPensionPlan);
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
