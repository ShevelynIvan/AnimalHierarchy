namespace AnimalHierarchy
{
    internal class Animal
    {
        /// <summary>
        /// Field of age. Can be null (same to unknown age)
        /// </summary>
        private int? _age;

        /// <summary>
        /// The name of the animal. Setting to "no name" if it missing
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// This property responsible for the age of the animal in years
        /// </summary>
        public virtual int? Age { get => _age; set => _age = ValidationOfAge(value, 0, 1000); }

        /// <summary>
        /// Creating the animal without data. Setting name to "no name" and age in null
        /// </summary>
        public Animal()
        {
            Name = "no name";
            _age = null;
        }

        /// <summary>
        /// Constructor to create the animal
        /// </summary>
        /// <param name="name">Name of animal</param>
        /// <param name="age">Age of animal in years</param>
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        /// <summary>
        /// Method describes that the animal is moving  
        /// </summary>
        public virtual void Move()
        {
            Console.WriteLine($"The animal {Name} is moving");
        }

        /// <summary>
        /// Shows info about the animal 
        /// </summary>
        public virtual void Speak()
        {
            Console.WriteLine($"Animal:\nName is {Name}\nAge is {AgeToString()}");
        }

        /// <summary>
        /// Helper method to validation age. It is protected method to use it in inheritance classes
        /// </summary>
        /// <param name="ageValue">age</param>
        /// <param name="minValue">Min possible value to age</param>
        /// <param name="maxValue">Max possible value to age</param>
        /// <returns></returns>
        protected int? ValidationOfAge(int? ageValue, int minValue = 0, int maxValue = 1000)
        {
            if (ageValue < minValue)
                return minValue;

            if (ageValue > maxValue)
                return maxValue;

            return ageValue;
        }

        /// <summary>
        /// Converting age's field to string. Used in Speak() method to show information about the age
        /// </summary>
        /// <returns></returns>
        private string? AgeToString() => _age is null ? "unknown" : _age.ToString();
    }
}
