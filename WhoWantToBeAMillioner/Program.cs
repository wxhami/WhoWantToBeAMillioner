using System.Net.Mime;
using WhoWantToBeAMillioner;

int capital = 0;

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
        Console.WriteLine("Game over!");
        break;
    }
    else
    {
        Console.WriteLine("You so smart ;)");
        capital += 1000 * i;
        Console.WriteLine("Your money: " + capital);
    }
}

if (capital == 55000)
{
    Console.WriteLine("You win!");
}