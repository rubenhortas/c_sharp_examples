using System;

namespace ExamQuestions
{
    class Program
    {
        static void Main()
        {
            //SqlOrderBy.Start();

            var multipleInterfaces = new MultipleInterfaces();

            ((IFile)multipleInterfaces).Open();
            ((IDbConnection)multipleInterfaces).Open();
            Console.ReadLine();
        }
    }
}
