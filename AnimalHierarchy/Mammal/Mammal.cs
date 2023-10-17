namespace AnimalHierarchy.Mammal
{
    internal class Mammal : Animal
    {
        /// <summary>
        /// This property responsible for the age of the animal in years.
        /// It is overridden to set max possible value for mammals
        /// </summary>
        public override int? Age { get => base.Age; set => base.Age = ValidationOfAge(value, 0, 200); }

        /// <summary>
        /// Creating the mammal without data. Setting name to "no name" and age in null
        /// </summary>
        public Mammal() : base() { }

        /// <summary>
        /// Constructor to create the mammal
        /// </summary>
        /// <param name="name">Name of animal</param>
        /// <param name="age">Age of animal in years</param>
        public Mammal(string name, int age) : base(name, age) { }

        /// <summary>
        /// Method describes that the mammal is walking. It set to sealed, because of all mammals can walk. 
        /// </summary>
        public override sealed void Move()
        {
            Console.WriteLine($"The mammal {Name} is walking");
        }

        /// <summary>
        /// Shows info about the mammal
        /// </summary>
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Kind of animal: Mammal");
        }
    }
}
