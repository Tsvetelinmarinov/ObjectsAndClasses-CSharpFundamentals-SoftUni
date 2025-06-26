/*
 * 04.Students
 */

namespace _04.Students
{
    class Program
    {
        static void Main()
        {
            List<Student> studentsList = new();
            string[] definition = Console.ReadLine()!
                .Split();

            while (definition[0] != "end")
            {
                Student currentStudent = new()
                {
                    Name = definition[0],
                    FamilyName = definition[1],
                    Age = byte.Parse(definition[2]),
                    BornPlace = definition[3]
                };

                studentsList.Add(currentStudent);
                definition = Console.ReadLine()!
                    .Split();
            }

            string bornPlace = Console.ReadLine()!;
            List<Student> filteredList = studentsList
                .Where(student => student.BornPlace!.Equals(bornPlace))
                .ToList();

            //= Pattern =//
            //  Jack Lewis is 14 years old.
            //= Pattern =//
            filteredList.ForEach(student =>
                Console.WriteLine($"{student.Name} {student.FamilyName} is {student.Age} years old.")
            );
        }
    }
}
