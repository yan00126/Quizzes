namespace Quizzes;

public class Quiz
{
    // fields
    private List<Question> questions;

    //constructor
    public Quiz (List<Question> questions)
    {
        this.questions = questions;

    }

    //methods

    public void AddQuestion (string text, string answer)
    {
        questions.Add(new Question(text, answer));
    }

    public void PlayQuiz ()
    {
        if (questions.Count == 0)
        {
            throw new Exception("No Question in the quiz.");
        }
        // Randomiz the order of questions
        var shuffled = Helper.Shuffle(questions);

        // play through all questions one at a time
        foreach (var question in shuffled)
        {

        // asking user the questions
            Console.WriteLine(question.Text);

        // check user's answers
            string? response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response) && question.CheckAnswer(response))
            {
        // responding
                //is correct
                Console.WriteLine("Correct!");
            }
            else
            {
                // incorrect
                Console.WriteLine($"Incorrect. Thre correct answer is: {question.Answer}");

            }


        }
    }
}
