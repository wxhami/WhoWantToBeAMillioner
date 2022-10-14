namespace WhoWantToBeAMillioner;

public class QuestionStore
{
    public List<Question> Questions;

    public QuestionStore()
    {
        Questions = new List<Question>();
        AddQuestion(1,"Что растет в огороде?", "лук", "пистолет", "пулемет", "ракета");
        AddQuestion(1, "Как называют микроавтобусы, совершающие поездки по определённым маршрутам?", "маршрутка", "путевка", "рейсовка", "курсовка");
       AddQuestion(2, "Что такое десница?", "рука", "шея", "глаз", "бровь");
       AddQuestion(2, "Какой специалист занимается изучением неопознанных летающих объектов?", "уфолог", "сексопатолог", "психолог", "стоматолог");
       AddQuestion(3, "В какое море впадает река урал?", "Каспийское", "Черное", "Белое", "Красное");
       AddQuestion(3, "На что кладут руку члены английского общества лысых во время присяги?", "бильярдный шар", "баскетбольный мяч", "шар для боулинга", "лук");
       AddQuestion(4,"Какое животное имеет второе название — кугуар?", "Пума", "Пантера", "Ягуар", "Лев");
       AddQuestion(4,"Что в России 19 века делали в дортуаре?", "Спали", "Срали", "Ели", "Мылись");
       AddQuestion(5, "Какой химический элемент назван в честь злого подземного гнома?", "Кобальт", "Гафний", "Теллур", "Хуюр");
    }
    
    public void AddQuestion(int level, string text, string rightAnswer, string answerOne, string answerTwo, string answerThree)
    {
        Question question = new Question()
        {
            Answers = new List<Answer>()
            {
                new Answer(rightAnswer, true), 
                new Answer(answerOne, false),
                new Answer(answerTwo, false),
                new Answer(answerThree, false)
            },
            Level = level,
            Text = text
            
        };
        Questions.Add(question);
    }
    
}


