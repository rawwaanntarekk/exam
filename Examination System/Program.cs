namespace Examination_System
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TFQuestion tfQuestion = new TFQuestion();
            Question question = tfQuestion.CreateQuestion();
            Console.WriteLine(question);


            MultipleChoiceQuestion multipleChoiceQuestion = new MultipleChoiceQuestion();
            Question question1 = multipleChoiceQuestion.CreateQuestion();
            Console.WriteLine(question1);


            





        }
    }
}
