using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            this.Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade) 
        {
            List<Student> sorted = new List<Student>(Students);
            sorted = sorted.sort();
            
            if (Student.length < 5) 
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");

            return 'F';
        }
            
    }

    
}
