namespace AnimalHierarchy.Bird
{
    internal class Bird : Animal
    {
        /// <summary>
        /// Creating the bird without data. Setting name to "no name" and age in null
        /// </summary>
        public Bird() : base() { }

        /// <summary>
        /// Constructor to create the bird
        /// </summary>
        /// <param name="name">Name of animal</param>
        /// <param name="age">Age of animal in years</param>
        public Bird(string name, int age) : base(name, age) { }

        /// <summary>
        /// Method describes that the bird is moving. It set to sealed, because of all birds can fly. 
        /// </summary>
        public override sealed void Move()
        {
            Console.WriteLine($"The bird {Name} is flying");
        }

        /// <summary>
        /// Shows info about the bird
        /// </summary>
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Kind of animal: Bird");
        }
    }
}
