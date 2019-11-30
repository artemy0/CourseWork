using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ResultsSave //статический класс для хранения всей информации об игре и игровом процессе
{
    //questions
    private static int totalQuestions; //всего вопросов в тесте
    public static int TotalQuestions
    {
        get { return totalQuestions; }
    }

    private static int questionsNumber; //осталось вопросов в тесте
    public static int QuestionsNumber
    {
        get { return questionsNumber; }
    }

    //answers
    private static int rightAnswersNumber; //правильных ответов
    public static int RightAnswersNumber
    {
        get { return rightAnswersNumber; }
    }

    //other
    [SerializeField] public const int SCENE_START = 1; //минимальный индекс лвл сцены
    [SerializeField] public const int SCENE_FINISH = 20; //максимальный индекс лвл сцены
    public static bool isSoundOn = true;

    private static List<int> sceneIndexes = new List<int>(); //список индексов сцен
    private static System.Random random = new System.Random(); //генератор случайных чисел
    private static int curSceneIndex = SCENE_START; //приватное поле с текущим количеством сцен

    //methods
    public static void UpdateParameters(int numberOfQuestions) //сбросить все параметры (чесло оставшихся вопросов, ответов, правильных ответов и допустимые вопросы)
    {
        totalQuestions = numberOfQuestions;
        questionsNumber = numberOfQuestions;
        rightAnswersNumber = 0;

        sceneIndexes.Clear();
        for (int i = SCENE_START; i <= SCENE_FINISH; i++)
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

    public static int RandomSceneIndex() // выбираем рандомный индекс уровня, которая не была разыграна
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
