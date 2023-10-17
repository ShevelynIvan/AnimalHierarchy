namespace AnimalHierarchy.Bird
{
    internal class Eagle : Bird
    {
        /// <summary>
        /// This property responsible for the age of the animal in years.
        /// It is overridden to set max possible value for eagles
        /// </summary>
        public override int? Age { get => base.Age; set => base.Age = ValidationOfAge(value, 0, 80); }

        /// <summary>
        /// Creating the eagle without data. Setting name to "no name" and age in null
        /// </summary>
        public Eagle() : base() { }

        /// <summary>
        /// Constructor to create the eagle
        /// </summary>
        /// <param name="name">Name of animal</param>
        /// <param name="age">Age of animal in years</param>
        public Eagle(string name, int age) : base(name, age) { }

        /// <summary>
        /// Shows info about the eagle
        /// </summary>
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Kind of bird: Eagle!");
        }
    }
}
