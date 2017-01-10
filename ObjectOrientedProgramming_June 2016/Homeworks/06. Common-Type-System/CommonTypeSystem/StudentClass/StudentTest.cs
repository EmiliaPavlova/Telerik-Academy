namespace StudentClass
{
    using System;
    using System.Linq;
    using Models;

    class StudentTest
    {
        static void Main(string[] args)
        {
            var studentPesho = new Student("Pesho Peshev Peshev", "Sofia", "0888123456", "pesho@gmail.com", "su1234", 2, Universities.SU, Faculties.BackEndDeveloper, Specialties.DotNet_Developer);
            var studentGosho = new Student("Gosho Goshov Goshov", "Sofia", "0888987654", "gosho@gmail.com", "su1280", 2, Universities.SU, Faculties.FrontEndDeveloper, Specialties.JavaScript_Developer);
            Student empty = null;
            var studentIlko = new Student("Ilko Ilkov Ilkov", "Sofia", "0888888888", "iii@gmail.com", "tu1111", 2, Universities.TU, Faculties.FrontEndDeveloper, Specialties.JavaScript_Developer);

            var students = new Student[] { studentIlko, studentGosho, studentPesho }.OrderBy(x => x).ToArray();

            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }
    }
}
