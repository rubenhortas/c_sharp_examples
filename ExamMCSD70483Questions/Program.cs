namespace ExamMCSD70483Questions
{
    class Program
    {
        static void Main()
        {
            // SqlOrderBy.Start();

            var multipleInterfaces = new MultipleInterfaces();

            ((IFile)multipleInterfaces).Open();
            ((IDbConnection)multipleInterfaces).Open();
        }
    }
}
