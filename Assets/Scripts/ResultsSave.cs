using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ResultsSave
{
    //questions
    private static int questionsNumber;
    public static int QuestionsNumber
    {
        get { return questionsNumber; }
    }
    public static void DecrementQuestionsNumber()
    {
        questionsNumber--;
    }

    //answers
    private static int rightAnswersNumber;
    public static int RightAnswersNumber
    {
        get { return rightAnswersNumber; }
    }
    public static void IncrementRightAnswersNumber()
    {
        rightAnswersNumber++;
    }

    //other
    public static void UpdateParameters(int numberOfQuestions)
    {
        questionsNumber = numberOfQuestions;
        rightAnswersNumber = 0;
    }
}
