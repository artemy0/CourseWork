using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void StartTest()
    {
        ResultsSave.UpdateParameters(10);

        SceneMixer.Recreate();
        
        SceneManager.LoadScene("Level" + SceneMixer.RandomSceneIndex()); //в принципе можно убрать Level+... и оставить только SceneMixer.RandomSceneIndex() что бы сцены загружались по индексу.
    }

    public void NextQuestion(bool isRightAnswer)
    {
        if (isRightAnswer)
        {
            ResultsSave.IncrementRightAnswersNumber();
        }
        ResultsSave.DecrementQuestionsNumber();

        if(ResultsSave.QuestionsNumber > 0)
            SceneManager.LoadScene("Level" + SceneMixer.RandomSceneIndex());
        else
            SceneManager.LoadScene("Results");
    }
}

public static class SceneMixer
{
    public const int SCENE_START = 1; // минимальный индекс сцены
    public const int SCENE_FINISH = 1; // финальная сцена, где пишется, что игра окончена

    private static List<int> sceneIndexes = new List<int>(); // список сцен
    private static System.Random random = new System.Random(); // генератор случайных чисел
    private static int curSceneIndex = SCENE_START; // приватное поле с текущим количеством сцен

    // публичное свойство с текущим количеством сцен
    public static int SceneCount
    {
        get { return curSceneIndex; }
        private set { curSceneIndex = value; }
    }

    // заполняет список индексами сцен, кроме финальной
    public static void Recreate()
    {
        sceneIndexes.Clear();
        for (int i = SCENE_START; i < SCENE_FINISH; i++)
            sceneIndexes.Add(i);
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
