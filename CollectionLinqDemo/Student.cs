using System.Collections.Generic;

namespace CollectionsLinqDemo
{
    public class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Dictionary<string, int> SubjectMarks { get; set; }

        public Student(
            string name,
            int score,
            Dictionary<string, int> subjectMarks)
        {
            Name = name;
            Score = score;
            SubjectMarks = subjectMarks;
        }
    }
}