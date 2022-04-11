namespace mod1AssingmntB
{
    public class Teacher : Person, Talkable
    {
        public int age {get; set;}

        public string GetName() => Name;

        public Teacher (int Age, string name) : base(name) => age = Age;

        public string Talk() => "Don't forget to do the assigned reading";

    }
}