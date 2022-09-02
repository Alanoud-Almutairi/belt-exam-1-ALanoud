using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPController : MonoBehaviour
{
    [SerializeField] private Transform cameraTarget;
    private Camera mainCamera;
    private float verticalRotationLimit;
    [SerializeField] private float mouseSensitivity;
    [SerializeField] private float lookUpConstraint;
    [SerializeField] private float lookDownConstraint;
    [SerializeField] private bool invertMouse = false;
    [SerializeField] private float WalkSpeed;
    [SerializeField] private float RunSpeed;
    private Vector3 movement;

    void Start()
    {
     
        mainCamera = Camera.main;
    }
    private void Update()
    {
     
        Vector2 mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")) * mouseSensitivity;
        float yRotation = transform.rotation.eulerAngles.y + mouseInput.x;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, yRotation, transform.rotation.eulerAngles.z);

        float invert = (!invertMouse) ? -1f : 1f;
        verticalRotationLimit += (mouseInput.y * invert);
        verticalRotationLimit = Mathf.Clamp(verticalRotationLimit, lookDownConstraint, lookUpConstraint);
        cameraTarget.rotation = Quaternion.Euler(verticalRotationLimit, cameraTarget.eulerAngles.y, cameraTarget.eulerAngles.z);

        Vector3 moveForward = transform.forward * Input.GetAxisRaw("Vertical");
        Vector3 moveRight = transform.right * Input.GetAxisRaw("Horizontal");
        float currentSpeed = (Input.GetKey(KeyCode.LeftShift)) ? RunSpeed : WalkSpeed;
        movement = (moveForward + moveRight).normalized * currentSpeed;
    }
    void LateUpdate()
    {
        mainCamera.transform.position = cameraTarget.position;
        mainCamera.transform.rotation = cameraTarget.rotation;
    }
}
