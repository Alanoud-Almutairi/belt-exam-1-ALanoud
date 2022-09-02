using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    public class EndGoal : MonoBehaviour
{
    [SerializeField] private GameObject winScreen;
    void OnTriggerEnter(Collider other)
    {
        winScreen.SetActive(true);
        if (other.gameObject.tag == "Player")
        {

        }
      
    }

}
