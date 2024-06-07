internal class Program
{
  private static void Main(string[] args)
  {
    bool isActive = true;

    while (isActive)
    {
      Console.WriteLine("\nQuiz Application");
      Console.WriteLine("1. Add Question");
      Console.WriteLine("2. Play Quiz");
      Console.WriteLine("3. Exit");
      Console.Write("Enter an action: ");
      
      bool isValid = int.TryParse(Console.ReadLine(), out int action);
    }
  }
}