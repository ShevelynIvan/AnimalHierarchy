namespace AnimalHierarchy.Bird
{
    internal sealed class Owl : Bird
    {
        /// <summary>
        /// This property responsible for the age of the animal in years.
        /// It is overridden to set max possible value for owls
        /// </summary>
        public override int? Age { get => base.Age; set => base.Age = ValidationOfAge(value, 0, 30); }

        /// <summary>
        /// Creating the owl without data. Setting name to "no name" and age in null
        /// </summary>
        public Owl() : base() { }

        /// <summary>
        /// Constructor to create the owl
        /// </summary>
        /// <param name="name">Name of animal</param>
        /// <param name="age">Age of animal in years</param>
        public Owl(string name, int age) : base(name, age) { }

        /// <summary>
        /// Shows info about the owl
        /// </summary>
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Kind of bird: Owl!");
        }
    }
}
