namespace FirstBeforeLast
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student("Ivan", "Ivanov", 18),
                new Student("Andrey", "Ivanov", 36),
                new Student("Andrey", "Mihov", 24),
                new Student("Yana", "Vasileva", 17),
                new Student("Ana", "Koleva", 32),
                new Student("Kalin", "Botev", 20),
            };

            GetAlphabeticallyOrderedStudents(students);
        }

        public static void GetAlphabeticallyOrderedStudents(Student[] students)
        {
            var filteredStudentsByNames = from student in students
                                          where student.FirstName.CompareTo(student.LastName) == -1
                                          select student;

            Console.WriteLine("Students whose first name is before its last name alphabetically:");
            foreach (var student in filteredStudentsByNames)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine();

            // Age range
            var filteredStudentsByAge = from student in students
                                        where student.Age >= 18 && student.Age <= 24
                                        select student;

            Console.WriteLine("Students with age between 18 and 24:");
            foreach (var student in filteredStudentsByAge)
            {
                Console.WriteLine("{0} {1}, age: {2}", student.FirstName, student.LastName, student.Age);
            }

            Console.WriteLine();

            // Sort the students by first name and last name in descending order
            var sortedStudents = students
                .OrderByDescending(s => s.FirstName)
                .ThenByDescending(s => s.LastName);

            Console.WriteLine("Students sorted by first name and last name in descending order:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine();
            var sortedStudentsWithLinq = from student in students
                                         orderby student.FirstName descending, student.LastName descending 
                                         select student;

            foreach (var student in sortedStudentsWithLinq)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
