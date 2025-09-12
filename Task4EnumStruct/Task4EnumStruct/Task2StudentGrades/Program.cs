using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2StudentGrades
{

    internal class Program
    { 
        public enum YearLevel
        {
        Freshman, 
        Sophomore, 
        Junior, 
        Senior
        }
        public static float GradeAvg(float[] Grades)
        {
            float sum = 0;
            for (int i = 0; i < Grades.Length; i++)
            {
                sum += Grades[i];
            }
            float avg = sum / Grades.Length;
            return avg;
        }
        public struct Student
        {
            public string name;
            public YearLevel level;
            public float[] grades;
            public float gradeAvg;
            
        }
        //public float[] Avgs;
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.name = "Hosam";
            student1.level = YearLevel.Freshman;
            student1.grades = new float[] { 45, 68, 39, 95, 75 };
            student1.gradeAvg = GradeAvg(student1.grades);
            Console.WriteLine($"Student name: {student1.name}\nStudent year level: {student1.level}\nStudent grade average: {student1.gradeAvg}\n\n");
            
            Student student2 = new Student();
            student2.name = "ramy";
            student2.level = YearLevel.Junior;
            student2.grades = new float[] { 45, 76, 39, 17, 75 };
            student2.gradeAvg = GradeAvg(student2.grades);
            Console.WriteLine($"Student name: {student2.name}\nStudent year level: {student2.level}\nStudent grade average: {student2.gradeAvg}\n\n");

            Student student3 = new Student();
            student3.name = "Naseem";
            student3.level = YearLevel.Freshman;
            student3.grades = new float[] { 70, 68, 90, 95, 75 };
            student3.gradeAvg = GradeAvg(student3.grades);
            Console.WriteLine($"Student name: {student3.name}\nStudent year level: {student3.level}\nStudent grade average: {student3.gradeAvg}\n\n");

            Student student4 = new Student();
            student4.name = "Fady";
            student4.level = YearLevel.Freshman;
            student4.grades = new float[] { 45, 100, 39, 95, 66 };
            student4.gradeAvg = GradeAvg(student4.grades);
            Console.WriteLine($"Student name: {student4.name}\nStudent year level: {student4.level}\nStudent grade average: {student4.gradeAvg}\n\n");

            Student student5 = new Student();
            student5.name = "Layla";
            student5.level = YearLevel.Freshman;
            student5.grades = new float[] { 45, 68, 90, 95, 80 };
            student5.gradeAvg = GradeAvg(student5.grades);
            Console.WriteLine($"Student name: {student5.name}\nStudent year level: {student5.level}\nStudent grade average: {student5.gradeAvg}\n\n");

            float[] studentsGradeAvgs = new float[] {student1.gradeAvg, student2.gradeAvg, student3.gradeAvg, student4.gradeAvg,student5.gradeAvg };
            float highstAvgGrade =studentsGradeAvgs[0];
            foreach ( float avgs in studentsGradeAvgs)
            {
                if (highstAvgGrade < avgs)
                highstAvgGrade = avgs ;
            }
            
            Console.WriteLine($"highest average grade = {highstAvgGrade}");
        }
    }
}
