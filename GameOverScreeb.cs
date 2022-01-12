using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreeb : MonoBehaviour
{

    public string SampleScene;

    public MoveCam position;
    public void Setup()
    {
        gameObject.SetActive(true);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SampleScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
