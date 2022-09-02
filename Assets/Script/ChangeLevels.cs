using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevels : MonoBehaviour
{
    [SerializeField] private string level1, level2, level3;
    [SerializeField] private KeyCode one, two, three;

    private void Update()
    {
        if (Input.GetKeyDown(one))
            SceneManager.LoadScene(level1);

        if (Input.GetKeyDown(two))
            SceneManager.LoadScene(level2);

        if (Input.GetKeyDown(three))
            SceneManager.LoadScene(level3);
    }

}