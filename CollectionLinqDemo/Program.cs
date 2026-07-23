using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsLinqDemo
{
    internal class Program
    {
        static void Main()
        {
            // List<T> stores an ordered collection of students.
            List<Student> students = new List<Student>
            {
                new Student(
                    "Alice",
                    85,
                    new Dictionary<string, int>
                    {
                        { "Mathematics", 90 },
                        { "English", 80 }
                    }),

                new Student(
                    "Bob",
                    72,
                    new Dictionary<string, int>
                    {
                        { "Mathematics", 70 },
                        { "English", 74 }
                    }),

                new Student(
                    "Charlie",
                    92,
                    new Dictionary<string, int>
                    {
                        { "Mathematics", 95 },
                        { "English", 89 }
                    }),

                new Student(
                    "Diana",
                    78,
                    new Dictionary<string, int>
                    {
                        { "Mathematics", 76 },
                        { "English", 80 }
                    })
            };

            Console.WriteLine("All Students");
            Console.WriteLine();

            foreach (Student student in students)
            {
                Console.WriteLine(
                    $"{student.Name}: {student.Score}"
                );
            }

            // LINQ filters students with a score of at least 80
            // and sorts them from highest to lowest.
            List<Student> highScoringStudents = students
                .Where(student => student.Score >= 80)
                .OrderByDescending(student => student.Score)
                .ToList();

            Console.WriteLine();
            Console.WriteLine("Students Scoring 80 or Higher");
            Console.WriteLine();

            foreach (Student student in highScoringStudents)
            {
                Console.WriteLine(
                    $"{student.Name}: {student.Score}"
                );
            }

            // Dictionary<TKey, TValue> provides access using a key.
            Student alice = students[0];

            Console.WriteLine();
            Console.WriteLine("Alice's Subject Marks");
            Console.WriteLine();

            foreach (
                KeyValuePair<string, int> subjectMark
                in alice.SubjectMarks)
            {
                Console.WriteLine(
                    $"{subjectMark.Key}: {subjectMark.Value}"
                );
            }

            Console.WriteLine();
            Console.WriteLine(
                $"Alice's Mathematics mark: " +
                $"{alice.SubjectMarks["Mathematics"]}"
            );

            // Additional LINQ calculation.
            double averageScore = students.Average(
                student => student.Score
            );

            Console.WriteLine();
            Console.WriteLine(
                $"Average student score: {averageScore:F2}"
            );
        }
    }
}