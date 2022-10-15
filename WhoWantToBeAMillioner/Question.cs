namespace WhoWantToBeAMillioner;

public class Question
{
    
    public string Text;
    public List<Answer> Answers;
    public int Level;

    public void ShakeAnswers()
    {
        Random random = new Random();
        int n = Answers.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            var value = Answers[k];
            Answers[k] = Answers[n];
            Answers[n] = value;
        }
    }
}