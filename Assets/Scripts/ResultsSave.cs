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

    //answers
    private static int rightAnswersNumber;
    public static int RightAnswersNumber
    {
        get { return rightAnswersNumber; }
    }

    //other
    public const int SCENE_START = 1; // минимальный индекс сцены
    public const int SCENE_FINISH = 1; // финальная сцена, где пишется, что игра окончена

    private static List<int> sceneIndexes = new List<int>(); // список сцен
    private static System.Random random = new System.Random(); // генератор случайных чисел
    private static int curSceneIndex = SCENE_START; // приватное поле с текущим количеством сцен

    //methods
    public static void UpdateParameters(int numberOfQuestions)
    {
        questionsNumber = numberOfQuestions;
        rightAnswersNumber = 0;

        sceneIndexes.Clear();
        for (int i = SCENE_START; i < SCENE_FINISH; i++)
            sceneIndexes.Add(i);
    }

    public static void DecrementQuestionsNumber()
    {
        questionsNumber--;
    }

    public static void IncrementRightAnswersNumber()
    {
        rightAnswersNumber++;
    }

    // выбираем рандомный индекс сцены которая не была разыграна
    public static int RandomSceneIndex()
    {
        int tmp = -1;

        if (sceneIndexes.Count != 0)
        {
            int randomIndex = random.Next(0, sceneIndexes.Count);
            tmp = sceneIndexes[randomIndex];
            sceneIndexes.RemoveAt(randomIndex);
        }

        return tmp;
    }
}
