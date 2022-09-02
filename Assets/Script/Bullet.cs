using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float bulletLifSpan;
    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.right * bulletSpeed);
        Invoke("Delete", bulletLifSpan);

    }
    private void Delete()
    {
        Destroy(gameObject);
    }


    
    void Update()
    {
        
    }
}
