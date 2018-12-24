using System;
using System.Collections.Generic;

namespace _5588ScoutingApp
{
    public class FormQuestionSet
    {
        List<Question> questionSet;
        public FormQuestionSet()
        {
            questionSet = new List<Question>();
        }

        public void addQuestion(Question question)
        {
            questionSet.Add(question);
            //Console.WriteLine(question.GetText());
        }
    }
}
