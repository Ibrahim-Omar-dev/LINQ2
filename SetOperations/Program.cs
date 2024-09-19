using ShareProject2;
namespace SetOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunDistinctAndConcat();
            //RunUnion();
            //RunExcept();
            RunIntersect();
            Console.ReadKey();
        }
        private static void RunDistinctAndConcat()
        {
            var meeting1 = Repository.Meeting1.Participants;
            var meeting2 = Repository.Meeting2.Participants;
            meeting1.Print("meeting1 participants");
            meeting2.Print("meeting2 participants");
            var Participants = meeting1.Concat(meeting2);
            Participants.Print("All Participants without remove diplicates");
            var Participants2 = Participants.Distinct();//if override of Equels is remove act as concat()
            Participants2.Print("All Participants with remove diplicates");
            var Participants3 = Participants.DistinctBy(x => x.EmployeeNo);//if override of Equels is remove nothing happen
            Participants3.Print("All Participants with remove diplicates");
        }
        private static void RunUnion()
        {
            var meeting1 = Repository.Meeting1.Participants;
            var meeting2 = Repository.Meeting2.Participants;
            var meeting3 = Repository.Meeting3.Participants;
            meeting3.Print("Meeting 3 Participants");
            var Participants = meeting1.Union(meeting2);
            Participants.Print("meeting 1 and meeting 2 Participants");
            var Participants2 = Participants.Union(meeting3);
            Participants2.Print("meeting 1 and meeting 2 and meeting 3 Participants");

            var Participants3 = Participants.UnionBy(meeting3, x => x.Name);
            Participants3.Print("meeting 1 and meeting 2 and meeting 3 Participants");
        }
        private static void RunExcept()
        {
            var meeting1=Repository.Meeting1.Participants;
            var meeting2=Repository.Meeting2.Participants;
            var meeting3=Repository.Meeting3.Participants;
            meeting1.Print("participants in meeting 1");
            meeting2.Print("participants in meeting 2");
            meeting3.Print("participants in meeting 3");
            var Participants=meeting1.Except(meeting2);
            Participants.Print("Participants in meeting 1 and not in meeting 2 ");
            var Participants2=meeting2.ExceptBy(meeting3.Select(x=>x.Name),x=>x.Name);
            Participants2.Print("Participants in meeting 2 and not in meeting 3 ");
        }
        private static void RunIntersect()
        {
            var meeting1 = Repository.Meeting1.Participants;
            var meeting2 = Repository.Meeting2.Participants;
            meeting1.Print("participants in meeting 1");
            meeting2.Print("participants in meeting 2");
            var Participants = meeting1.Intersect(meeting2);
            Participants.Print("Participants in meeting 1 and in meeting 2 ");

            var Participants2 = meeting1.IntersectBy(meeting2.Select(x => x.Name), x => x.Name);
            Participants2.Print("Participants in meeting 1 and in meeting 2 ");

        }
    }
}
