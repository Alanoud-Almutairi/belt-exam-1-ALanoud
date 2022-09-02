using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private GameObject bullet;
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Debug.Log("Shot");

            Instantiate(bullet, bulletSpawnPoint.position, transform.rotation);
        }
    }
}

