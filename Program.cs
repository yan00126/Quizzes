using System.ComponentModel;
using Quizzes;

internal class Program
{
  enum Action {
    Add = 1, // 1
    Play, // 2
    Exit // 3
  }

  // private static Quiz quiz = new Quiz(Helper.GetAvailableQuestions());
  private static Quiz quiz = new Quiz([]);

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
    
      switch ((Action)action)
      {
        case Action.Add:
          //adding
          Add();
          break;
        case Action.Play:
          try 
          {
          //
            quiz.PlayQuiz();
          } 
          catch (Exception e) 
          {
            Console.WriteLine(e.Message);
          }
          break;
        case Action.Exit:
          //
          break;
        default:
          Console.WriteLine("Not a valid response.");
          break;
      }

    }
  }

  private static void Add()
  {
    string? text = null;
    string? answer = null;

    while (string.IsNullOrWhiteSpace(text))
    {
      Console.WriteLine("Enter the Question: ");
      text = Console.ReadLine();
    }

    while (string.IsNullOrWhiteSpace(answer))
    {
      Console.WriteLine("Enter the Question: ");
      answer = Console.ReadLine();
    }
    quiz.AddQuestion(text, answer);
  }
}