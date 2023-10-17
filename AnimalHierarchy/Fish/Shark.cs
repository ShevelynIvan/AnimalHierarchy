namespace AnimalHierarchy.Fish
{
    internal sealed class Shark : Fish
    {
        /// <summary>
        /// This property responsible for the age of the animal in years.
        /// It is overridden to set max possible value for sharks
        /// </summary>
        public override int? Age { get => base.Age; set => base.Age = ValidationOfAge(value, 0, 30); }

        /// <summary>
        /// Creating the shark without data. Setting name to "no name" and age in null
        /// </summary>
        public Shark() : base() { }

        /// <summary>
        /// Constructor to create the shark
        /// </summary>
        /// <param name="name">Name of animal</param>
        /// <param name="age">Age of animal in years</param>
        public Shark(string name, int age) : base(name, age) { }

        /// <summary>
        /// Shows info about the shark
        /// </summary>
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Kind of fish: Shark!");
        }
    }
}
