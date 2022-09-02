using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu1 : MonoBehaviour

{
    [SerializeField] private string gameScene;
    public void BackGame()
    {
        SceneManager.LoadScene(gameScene);

    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
