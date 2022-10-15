namespace WhoWantToBeAMillioner;

public class QuestionProvider
{
    public List<Question> Questions;
    
    public QuestionProvider()

    public Question GetQuestion(int level)
    {
        var questions = new List<Question>();
        
        foreach (Question question in Questions)
        {
            if (level == question.Level)
            {
                questions.Add(question);
            }
        }

        var random = new Random();

        return questions[random.Next(0, questions.Count)];
    }
}

