using System.Net.Mime;
using WhoWantToBeAMillioner;

QuestionProvider questionProvider = new QuestionProvider();


for (int i = 1; i <= 10; i++)
{
    Question question = questionProvider.GetQuestion(i);
    Console.WriteLine(question.Text);
    Console.WriteLine("Choose answer");
    for (int j = 1; j <= 4; j++)
    {
        
        Console.WriteLine(question.Answers[j]);
    }

    int playerChoice = Convert.ToInt32(Console.ReadLine());
    if (question.Answers[playerChoice].IsRight == false)
    {
        break;
    }
    else
    {
        Console.WriteLine("You so smart ;)");
    }
}