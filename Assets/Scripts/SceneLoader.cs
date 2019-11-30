using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance = null;

    private void Awake() //реализация паттерна Singleton
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    public void LoadMainMenu() //загрузка главного меню
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void StartTest(int questionsNumber) //начало теста с указанием колличества вопросов
    {
        ResultsSave.UpdateParameters(questionsNumber);
        
        SceneManager.LoadScene("Level" + ResultsSave.RandomSceneIndex() + "Scene"); //в принципе можно убрать Level+... и оставить только SceneMixer.RandomSceneIndex() что бы сцены загружались по индексу.
    }

    public void NextQuestion() //загрузка следующего вопроса или сцены с результатами
    {
        if (ResultsSave.QuestionsNumber > 0)
            SceneManager.LoadScene("Level" + ResultsSave.RandomSceneIndex() + "Scene");
        else
            SceneManager.LoadScene("ResultsScene");
    }
}
