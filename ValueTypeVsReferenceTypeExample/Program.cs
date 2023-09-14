namespace ValueTypeVsReferenceTypeExample
{
    /// <summary>
    /// Represents a point in a two-dimensional space.
    /// </summary>
    struct Point
    {
        public int X;
        public int Y;
    }

    /// <summary>
    /// Represents a person with a name and age.
    /// </summary>
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Value types
            int age = 30; // Age of a person
            char grade = 'A'; // Grade of a student
            bool isValid = true; // Validity flag

            Console.WriteLine("Value Types:");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"IsValid: {isValid}");

            // Using a struct as a value type
            Point p1 = new Point { X = 10, Y = 20 };
            Point p2 = p1; // Creates a copy of p1

            Console.WriteLine("\nValue Type Struct:");
            Console.WriteLine($"Point p1: X={p1.X}, Y={p1.Y}");
            Console.WriteLine($"Point p2: X={p2.X}, Y={p2.Y}");

            // Update p2 and show the effect on p1
            p2.X = 100;
            Console.WriteLine("\nUpdated Value Type Struct (p2):");
            Console.WriteLine($"Point p1: X={p1.X}, Y={p1.Y} (Unaffected)");
            Console.WriteLine($"Point p2: X={p2.X}, Y={p2.Y} (Updated)");

            // Arrays of value types
            int[] numbers = { 1, 2, 3, 4, 5 }; // An array of integers

            Console.WriteLine("\nArray of Value Types:");
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            // Passing value types to functions
            int num = 10; // An integer value
            ModifyValue(num);
            Console.WriteLine($"\nModified Value Type: {num}");

            // Reference types
            // Using a class as a reference type
            Person homerSimpson = new Person { Name = "Homer Simpson", Age = 42 };
            Person margeSimpson = homerSimpson; // Both variables reference the same object

            Console.WriteLine("\nReference Types (Class):");
            Console.WriteLine($"Person 1: Name={homerSimpson.Name}, Age={homerSimpson.Age}");
            Console.WriteLine($"Person 2: Name={margeSimpson.Name}, Age={margeSimpson.Age}");

            // Using strings as immutable reference types
            string greeting1 = "Hello"; // A string containing a greeting
            string greeting2 = greeting1; // Both variables reference the same string in memory

            Console.WriteLine("\nReference Type (String):");
            Console.WriteLine($"Greeting 1: {greeting1}");
            Console.WriteLine($"Greeting 2: {greeting2}");

            // Modifying a reference type
            homerSimpson.Name = "Bart Simpson"; // Since margeSimpson references the same object, it will reflect the change

            Console.WriteLine("\nModified Reference Type (Class):");
            Console.WriteLine($"Person 1: Name={homerSimpson.Name}, Age={homerSimpson.Age}");
            Console.WriteLine($"Person 2: Name={margeSimpson.Name}, Age={margeSimpson.Age}");

            // Update margeSimpson and show the effect on homerSimpson
            margeSimpson.Name = "Marge Simpson";
            Console.WriteLine("\nUpdated Reference Type (Class - margeSimpson):");
            Console.WriteLine($"Person 1: Name={homerSimpson.Name} (Unaffected)");
            Console.WriteLine($"Person 2: Name={margeSimpson.Name} (Updated)");

            // Constructor vs. object initialization
            // Using a constructor
            Person lisaSimpson = new Person();
            lisaSimpson.Name = "Lisa Simpson";
            lisaSimpson.Age = 9;

            // Using object initialization
            Person maggieSimpson = new Person { Name = "Maggie Simpson", Age = 1 };

            Console.WriteLine("\nConstructor vs. Object Initialization:");
            Console.WriteLine($"Person 3: Name={lisaSimpson.Name}, Age={lisaSimpson.Age}");
            Console.WriteLine($"Person 4: Name={maggieSimpson.Name}, Age={maggieSimpson.Age}");

            // Null references
            Person unknownCharacter = null; // Assigning a null reference

            Console.WriteLine("\nNull Reference:");
            Console.WriteLine($"Person 5 is {(unknownCharacter == null ? "null" : "not null")}");

            // Reference type arrays
            Person[] simpsonsFamily = new Person[5];
            simpsonsFamily[0] = new Person { Name = "Homer Simpson", Age = 42 };
            simpsonsFamily[1] = new Person { Name = "Marge Simpson", Age = 38 };
            simpsonsFamily[2] = new Person { Name = "Bart Simpson", Age = 12 };
            simpsonsFamily[3] = new Person { Name = "Lisa Simpson", Age = 9 };
            simpsonsFamily[4] = new Person { Name = "Maggie Simpson", Age = 1 };

            Console.WriteLine("\nReference Type Arrays (Simpsons Family):");
            foreach (var simpson in simpsonsFamily)
            {
                if (simpson != null)
                    Console.WriteLine($"Name={simpson.Name}, Age={simpson.Age}");
            }

            // Passing reference types to functions
            Person lisaClone = new Person { Name = "Lisa Clone", Age = 9 };
            ModifyPersonName(lisaClone); // Changes the original object

            Console.WriteLine("\nModified Reference Type (Class) in a Function:");
            Console.WriteLine($"Original Lisa: Name={lisaSimpson.Name}, Age={lisaSimpson.Age}");
            Console.WriteLine($"Lisa Clone: Name={lisaClone.Name}, Age={lisaClone.Age}");

            Console.ReadKey();
        }

        /// <summary>
        /// Modifies a value type (integer).
        /// </summary>
        /// <param name="value">The value to modify.</param>
        static void ModifyValue(int value)
        {
            value = 42; // Changes the local copy, not the original value
        }

        /// <summary>
        /// Modifies the name property of a Person object.
        /// </summary>
        /// <param name="person">The Person object to modify.</param>
        static void ModifyPersonName(Person person)
        {
            person.Name = "Updated Name";
        }
    }
}
