using System;
namespace GradeBook.GradeBooks
{
    public class StandardGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        {
            this.Type = GradeBookType.Standard;
        }
    }
}
