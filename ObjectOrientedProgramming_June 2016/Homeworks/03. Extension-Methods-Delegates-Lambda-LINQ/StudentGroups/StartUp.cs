namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Ani", "Boteva", "123406", "0888123456", "ani@abv.bg", new List<double> {5, 4.5, 6, 6}, 1),
                new Student("Kiril", "Stoev", "234567", "028946568", "kiro@mail.bg", new List<double> {5, 4.5, 6, 6}, 1),
                new Student("Stoyan", "Petrov", "345678", "032568915", "spetrov@gmail.com", new List<double> {5, 4.5, 6, 6}, 2),
                new Student("Krasen", "Iliev", "456789", "02123123", "krasi@abv.bg", new List<double> {3, 4.5, 4.5, 5},
                    2),
                new Student("Maria", "Peeva", "987654", "0888123456", "peeva@abv.bg", new List<double> {2, 2, 3, 3}, 3),
                new Student("Emil", "Paunov", "951306", "02999999", "emilpaunov@abv.bg", new List<double> {5, 6, 5, 6}, 3)
            };

            var studentsSecondGroup = students.Where(s => s.GroupNumber == 2).OrderBy(s => s.FirstName);
            Console.WriteLine("Students from group 2:");
            foreach (var student in studentsSecondGroup)
            {
                Console.WriteLine("{0} {1}, group: {2}", student.FirstName, student.LastName, student.GroupNumber);
            }

            Console.WriteLine();

            // Problem 11. Extract students by email
            var studentsByEmail = students.Where(s => s.Email.Contains("abv.bg"));
            Console.WriteLine("Students that have email in abv.bg:");
            foreach (var student in studentsByEmail)
            {
                Console.WriteLine("{0} {1}, email: {2}", student.FirstName, student.LastName, student.Email);
            }

            Console.WriteLine();

            // Problem 12. Extract students by phone
            var studentsByPhone = students.Where(s => s.Phone.StartsWith("02"));
            Console.WriteLine("Students with phone in Sofia:");
            foreach (var student in studentsByPhone)
            {
                Console.WriteLine("{0} {1}, phone: {2}", student.FirstName, student.LastName, student.Phone);
            }

            Console.WriteLine();

            // Problem 13. Extract students by marks  
            var studentsByMarkExcellent = students.Where(s => s.Marks.Any(m => m.Equals(6)));
            var stud = new
            {
                FullName = studentsByMarkExcellent.Select(x => x.FirstName + ' ' + x.LastName),
                Marks = studentsByMarkExcellent.Select(x => x.Marks)
            };

            Console.WriteLine("Students that have at least one mark Excellent (6):");
            foreach (var student in studentsByMarkExcellent)
            {
                Console.WriteLine("{0}", student.FirstName + ' ' + student.LastName);
            }

            Console.WriteLine();

            //Problem 14. Extract students with two marks
            var studentsByMarkWeek = students.Where(s => s.Marks.Where(m => m.Equals(2)).ToList().Count == 2);
            Console.WriteLine("Students with two marks \"2\":");
            foreach (var student in studentsByMarkWeek)
            {
                Console.WriteLine("{0}", student.FirstName + ' ' + student.LastName);
            }

            Console.WriteLine();

            // Problem 15. Extract marks
            var studentsByYear = students.Where(s => s.FNumber.EndsWith("06"));
            Console.WriteLine("All marks of the students that enrolled in 2006:");
            foreach (var student in studentsByYear)
            {
                Console.WriteLine("{0} {1}, faculty number: {2}, marks: {3}", 
                    student.FirstName, student.LastName, student.FNumber, string.Join(", ", student.Marks));;
            }

            Console.WriteLine();

            // Problem 18. Grouped by GroupNumber
            var studentsByGroupNumber1 = from s in students
                group s.FirstName + ' ' + s.LastName by s.GroupNumber
                into g
                select new {GroupNumber = g.Key, Names = g.ToList()};

            Console.WriteLine("Students grouped by GroupNumber: ");
            foreach (var grouped in studentsByGroupNumber1)
            {
                Console.WriteLine("Group {0}: {1}", grouped.GroupNumber, string.Join(", ", grouped.Names));
            }

            Console.WriteLine();

            // Problem 19. Grouped by GroupName extensions
            var studentsByGroupNumber = students.GroupBy(s => s.GroupNumber,
                s => s.FirstName = s.FirstName + ' ' + s.LastName,
                (key, g) => new
                {
                    GroupNumber = key,
                    Name = g.ToList()
                });

            foreach (var grouped in studentsByGroupNumber)
            {
                Console.WriteLine("Group {0}: {1}", grouped.GroupNumber, string.Join(", ", grouped.Name));
            }
        }
    }
}
