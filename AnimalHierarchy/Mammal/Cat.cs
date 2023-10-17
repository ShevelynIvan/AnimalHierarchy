namespace AnimalHierarchy.Mammal
{
    internal sealed class Cat : Mammal
    {
        /// <summary>
        /// This property responsible for the age of the animal in years.
        /// It is overridden to set max possible value for cats
        /// </summary>
        public override int? Age { get => base.Age; set => base.Age = ValidationOfAge(value, 0, 35); }

        /// <summary>
        /// Creating the cat without data. Setting name to "no name" and age in null
        /// </summary>
        public Cat() : base() { }

        /// <summary>
        /// Constructor to create the cat
        /// </summary>
        /// <param name="name">Name of animal</param>
        /// <param name="age">Age of animal in years</param>
        public Cat(string name, int age) : base(name, age) { }

        /// <summary>
        /// Shows info about the cat
        /// </summary>
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Kind of mammal: Cat!");
        }
    }
}
