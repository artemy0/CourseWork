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

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void StartTest()
    {
        ResultsSave.UpdateParameters(1);
        
        SceneManager.LoadScene("Level" + ResultsSave.RandomSceneIndex() + "Scene"); //в принципе можно убрать Level+... и оставить только SceneMixer.RandomSceneIndex() что бы сцены загружались по индексу.
    }

    public void NextQuestion()
    {
        if (ResultsSave.QuestionsNumber > 0)
            SceneManager.LoadScene("Level" + ResultsSave.RandomSceneIndex() + "Scene");
        else
            SceneManager.LoadScene("ResultsScene");
    }
}
