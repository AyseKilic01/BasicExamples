using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> vs = new List<int>();
            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                vs.Add(gradesItem);
            }
            gradingStudents(vs);
            foreach(var item in vs)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            
        }
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> grade = new List<int>();
            List<int> success = new List<int>();
            int kalan = 0;
            for (int i = 40; i <= 100; i = i + 5)
            {
                grade.Add(i);
            }
            for (int i = 0; i < grades.Count; i++)
            {
                for (int j = 0; j < grade.Count; j++)
                {
                    if (grade[j] - grades[i] < 3 && grades[i] > 33 && grade[j] - grades[i] > 0)
                    {
                        kalan = grades[i] % 5;

                    }
                }
                if (grades[i] > 33 && kalan != 0)
                {
                    grades[i] = grades[i] + (5 - kalan);
                    kalan = 0;
                }
            }
            return grades;
        }
    }
}
