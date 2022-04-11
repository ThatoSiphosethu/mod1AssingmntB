namespace mod1AssingmntB
{
    class Program
    {
        static void Main(string[] args)
        {
            var OutFile = new FileOutput("animals.txt");
            var InFile = new FileInput("animals.txt");

            IList<Talkable> zoo = new List<Talkable>();

            zoo.Add(new Dog(true, "Bean"));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44, "Stacy Read"));

            foreach (Talkable item in zoo)
            {
                Console.WriteLine($"{item.GetName()} says: {item.Talk()}");
                OutFile.WriteFile($"{item.GetName()} | {item.Talk()}");
            }
        }
    }
}