using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
struct Student
{
    public string Name;
    public string GroupNumber;
    public int[] Grades;

    public double GetAverageGrade()
    {
        return Grades.Average();
    }

    public bool HasExcellentGrades()
    {
        return Grades.All(grade => grade == 4 || grade == 5);
    }
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[10];

        students[0] = new Student { Name = "Иванов И.И.", GroupNumber = "Группа 1", Grades = new int[] { 5, 4, 5, 4, 5 } };
        students[1] = new Student { Name = "Петров П.П.", GroupNumber = "Группа 2", Grades = new int[] { 4, 4, 3, 5, 4 } };
        students[2] = new Student { Name = "Сидоров С.С.", GroupNumber = "Группа 1", Grades = new int[] { 3, 3, 4, 4, 5 } };
        students[3] = new Student { Name = "Козлов К.К.", GroupNumber = "Группа 2", Grades = new int[] { 5, 5, 5, 5, 5 } };
        students[4] = new Student { Name = "Михайлов М.М.", GroupNumber = "Группа 3", Grades = new int[] { 4, 4, 4, 4, 4 } };
        students[5] = new Student { Name = "Александров А.А.", GroupNumber = "Группа 3", Grades = new int[] { 3, 3, 3, 3, 3 } };
        students[6] = new Student { Name = "Егоров Е.Е.", GroupNumber = "Группа 1", Grades = new int[] { 5, 4, 5, 5, 4 } };
        students[7] = new Student { Name = "Николаев Н.Н.", GroupNumber = "Группа 2", Grades = new int[] { 3, 5, 4, 4, 5 } };
        students[8] = new Student { Name = "Дмитриев Д.Д.", GroupNumber = "Группа 3", Grades = new int[] { 4, 4, 3, 4, 5 } };
        students[9] = new Student { Name = "Андреев А.А.", GroupNumber = "Группа 2", Grades = new int[] { 5, 5, 5, 4, 5 } };

        var sortedStudents = students.OrderBy(student => student.GetAverageGrade()).ToArray();

        Console.WriteLine("Студенты, отсортированные по среднему баллу:");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"{student.Name}, Средний балл: {student.GetAverageGrade()}");
        }

        Console.WriteLine("\nСтуденты с оценками 4 или 5 во всех предметах:");
        foreach (var student in students)
        {
            if (student.HasExcellentGrades())
            {
                Console.WriteLine($"{student.Name}, Группа: {student.GroupNumber}");
            }
        }
    }
}
}
