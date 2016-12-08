using System;

namespace ExamQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //SqlOrderBy.Start();

            var multipleInterfaces = new MultipleInterfaces();
            ((IFile)multipleInterfaces).Open();
            ((IDbConnection)multipleInterfaces).Open();
            Console.ReadLine();

        }
    }
}
