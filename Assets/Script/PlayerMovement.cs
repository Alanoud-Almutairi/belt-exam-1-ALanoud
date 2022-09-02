using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float speed;
    private Rigidbody rb;

    private void Start()
    {

        rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        float xMovement = Input.GetAxis("Horizontal") * speed;
        float zMovement = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(xMovement, 0, zMovement);
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
    }
}
