namespace AnimalHierarchy.Fish
{
    internal sealed class Dorado : Fish
    {
        /// <summary>
        /// This property responsible for the age of the animal in years.
        /// It is overridden to set max possible value for dorados
        /// </summary>
        public override int? Age { get => base.Age; set => base.Age = ValidationOfAge(value, 0, 11); }

        /// <summary>
        /// Creating the dorado without data. Setting name to "no name" and age in null
        /// </summary>
        public Dorado() : base() { }

        /// <summary>
        /// Constructor to create the dorado
        /// </summary>
        /// <param name="name">Name of animal</param>
        /// <param name="age">Age of animal in years</param>
        public Dorado(string name, int age) : base(name, age) { }

        /// <summary>
        /// Shows info about the dorado
        /// </summary>
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Kind of fish: Dorado!");
        }
    }
}
