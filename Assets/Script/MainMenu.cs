using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string gameScene;
    public GameObject Title;
    public GameObject HOW;
    public void HowtPlayGame()
    {

        HOW.SetActive(true);
        Title.SetActive(false);
        Debug.Log("How to play");
    }
    public void TitleMenu()
    {
        HOW.SetActive(false);
        Title.SetActive(true);
        Debug.Log("FirstMenu");
    }
    public void PlayGame()
    {

        SceneManager.LoadScene(gameScene);

    }
    public void QuitGame()
    {

        Application.Quit();
    }
    public void backTomune()
    {
        HOW.SetActive(false);
        Title.SetActive(true);
        Debug.Log("the Mune");
    }

}

