namespace mod1AssingmntB
{
    public class Cat : Pet, Talkable
    {
        public int MousesKilled { get; }

        public Cat(int mousesKilled, string name) : base(name) => MousesKilled = mousesKilled;

        public string Talk() => "Meow";
    
        public string GetName() => Name;

        public override string ToString() => $"Cat: name={Name} mousesKilled={MousesKilled}";
    }
}