using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class Gradebook : GradeTracker
    {
        

        public Gradebook()
        {
            _name = "Empty";
            GradeList = new List<float>();

        }
        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("Inside of Gradebook");
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;

            foreach (float grade in GradeList)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / GradeList.Count;


            return stats;
        }

        public override void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < GradeList.Count; i++)
            {
                destination.WriteLine(GradeList[i]);
            }
        }


        public override void AddGrade(float grade)
        {
            GradeList.Add(grade);
        }


        public override IEnumerator GetEnumerator()
        {
            return GradeList.GetEnumerator();
        }

        protected List<float> GradeList;


    }
}
