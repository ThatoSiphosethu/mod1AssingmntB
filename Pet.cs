namespace mod1AssingmntB
{
    public abstract class Pet
    {
        public Pet(string name) => Name = name;
        protected string Name { get; }
    }
}