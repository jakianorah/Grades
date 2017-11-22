using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class ThrowAwayGradeBook : Gradebook
    {
        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("Inside of ThrowAway");
            float lowest = float.MaxValue;
            foreach(float grades in GradeList)
            {
                lowest = Math.Min(grades, lowest);
            }
            GradeList.Remove(lowest);
            return base.ComputeStatistics();
        }
    }
}
