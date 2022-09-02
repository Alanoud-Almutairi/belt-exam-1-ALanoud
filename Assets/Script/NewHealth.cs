using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class NewHealth : MonoBehaviour
{
    [SerializeField] private Image healthBar;

    [SerializeField] private float healthAmount;

   private Transform enemy;
 
    private void Update()
    {
        if (healthAmount <= 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        healthBar.fillAmount = healthAmount;
        if (Input.GetButton("Fire1"))
            healthAmount -= 0.5f * Time.deltaTime;
        else if (Input.GetButton("Fire2"))
            healthAmount += 0.5f * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hazard"))
        {
            healthAmount-=0.25f;
            enemy = collision.gameObject.transform;
       
        }
    }

 
}
