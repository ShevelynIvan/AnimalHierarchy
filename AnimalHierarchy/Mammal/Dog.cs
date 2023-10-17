namespace AnimalHierarchy.Mammal
{
    internal sealed class Dog : Mammal
    {
        /// <summary>
        /// This property responsible for the age of the animal in years.
        /// It is overridden to set max possible value for dogs
        /// </summary>
        public override int? Age { get => base.Age; set => base.Age = ValidationOfAge(value, 0, 25); }

        /// <summary>
        /// Creating the dog without data. Setting name to "no name" and age in null
        /// </summary>
        public Dog() : base() { }

        /// <summary>
        /// Constructor to create the dog
        /// </summary>
        /// <param name="name">Name of animal</param>
        /// <param name="age">Age of animal in years</param>
        public Dog(string name, int age) : base(name, age) { }

        /// <summary>
        /// Shows info about the dog
        /// </summary>
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Kind of mammal: Dog!");
        }
    }
}
