namespace AnimalHierarchy.Fish
{
    internal class Fish : Animal
    {
        /// <summary>
        /// This property responsible for the age of the animal in years.
        /// It is overridden to set max possible value for fish
        /// </summary>
        public override int? Age { get => base.Age; set => base.Age = ValidationOfAge(value, 0, 100); }

        /// <summary>
        /// Creating the fish without data. Setting name to "no name" and age in null
        /// </summary>
        public Fish() : base() { }

        /// <summary>
        /// Constructor to create the fish
        /// </summary>
        /// <param name="name">Name of animal</param>
        /// <param name="age">Age of animal in years</param>
        public Fish(string name, int age) : base(name, age) { }

        /// <summary>
        /// Method describes that the fish is swimming. It set to sealed, because of all fish can swim. 
        /// </summary>
        public override sealed void Move()
        {
            Console.WriteLine($"The fish {Name} is swimming");
        }

        /// <summary>
        /// Shows info about the fish
        /// </summary>
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Kind of animal: Fish");
        }
    }
}
