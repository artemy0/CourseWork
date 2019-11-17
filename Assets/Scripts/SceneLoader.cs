using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public void StartTest()
    {
        ResultsSave.UpdateParameters(10);
        
        SceneManager.LoadScene("Level" + ResultsSave.RandomSceneIndex() + "Scene"); //в принципе можно убрать Level+... и оставить только SceneMixer.RandomSceneIndex() что бы сцены загружались по индексу.
    }

    public void NextQuestion(bool isRightAnswer)
    {
        if (isRightAnswer)
        {
            ResultsSave.IncrementRightAnswersNumber();
        }
        ResultsSave.DecrementQuestionsNumber();

        if (ResultsSave.QuestionsNumber > 0)
            SceneManager.LoadScene("Level" + ResultsSave.RandomSceneIndex() + "Scene");
        else
            SceneManager.LoadScene("ResultsScene");
    }
}
